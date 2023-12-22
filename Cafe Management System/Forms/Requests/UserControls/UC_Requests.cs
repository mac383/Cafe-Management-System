using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Requests.UserControls
{
    public partial class UC_Requests : UserControl
    {

        static DataTable _Requests;

        public UC_Requests()
        {
            
            InitializeComponent();
            _Requests = cls_Requests.GetRequests();

        }

        private void UC_Requests_Load(object sender, EventArgs e)
        {
            _LoadRequests(_Requests.DefaultView);
        }

        private void _LoadRequests(DataView dv)
        {

            dgv_requests.Rows.Clear();

            for (int i = 0; i < dv.Count; i++)
            {

                string _status = (Convert.ToInt16(dv[i]["Status"]) == 2) ? "مكتمل" :
                   (Convert.ToInt16(dv[i]["Status"]) == 1) ? "سيتم المحاسبة لاحقاً" : "في إنتظار المحاسبة..";

                string _byUserName = (string.IsNullOrEmpty(dv[i]["UserName"].ToString())) ?
                    "لم يتم التعيين بعد" : dv[i]["UserName"].ToString();

                dgv_requests.Rows.Add((i + 1).ToString(), dv[i]["ReservationName"],
                            _status, dv[i]["RequestCode"], _byUserName, dv[i]["RequestID"],
                            dv[i]["Status"], "أنقر للعرض");

            }

        }

        void _Refresh()
        {

            _Requests = cls_Requests.GetRequests();
            _LoadRequests(_Requests.DefaultView);

        }

        private void dgv_requests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_requests.SelectedRows.Count <= 0)
                return;

            if (dgv_requests.SelectedRows[0].Cells["col_requestcode"].ColumnIndex != e.ColumnIndex)
                return;

            Clipboard.SetText(dgv_requests.SelectedRows[0].Cells["col_requestcode"].Value.ToString());

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            if (dgv_requests.SelectedRows.Count <= 0)
                return;

            short requestStatus = Convert.ToInt16(dgv_requests.SelectedRows[0].Cells["col_statusvalue"].Value);


            switch ((cls_Requests.EN_RequestStatus)requestStatus)
            {

                case cls_Requests.EN_RequestStatus.RequestsToAccounting:

                    cmb_addtoaccountinglater.Visible = true;
                    cmb_accountrequest.Visible = true;
                    cms_separator2.Visible = true;

                    break;

                case cls_Requests.EN_RequestStatus.RequestsWillBeAccountingLater:

                    cmb_addtoaccountinglater.Visible = false;
                    cmb_accountrequest.Visible = true;
                    cms_separator2.Visible = true;

                    break;

                case cls_Requests.EN_RequestStatus.RequestsHaveBeenAccouted:

                    cmb_addtoaccountinglater.Visible = false;
                    cmb_accountrequest.Visible = false;
                    cms_separator2.Visible = false;

                    break;

            }

        }

        private void cmb_addtoaccountinglater_Click(object sender, EventArgs e)
        {

            if (dgv_requests.SelectedRows.Count <= 0) return;

            if ((cls_Requests.EN_RequestStatus)Convert.ToInt16(dgv_requests.SelectedRows[0].Cells["col_statusvalue"].Value) != cls_Requests.EN_RequestStatus.RequestsToAccounting)
                return;

            int requestID = Convert.ToInt32(dgv_requests.SelectedRows[0].Cells["col_requestid"].Value);
            int userID = 1; // يتم إضافة المستخدم الحالي هنا عند اكتمال برمجته

            if (cls_Requests.SetRequestAs(requestID, (short)cls_Requests.EN_RequestStatus.RequestsWillBeAccountingLater, userID))
            {
                MessageBox.Show("تم إضافة الطلب الئ المحاسبة لاحقاً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                _Refresh();
            }
            else
                MessageBox.Show("حدث خطأ اثناء إضافة الطلب الئ المحاسبة لاحقاً, يرجئ المحاولة مرة اخرئ.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void cmb_accountrequest_Click(object sender, EventArgs e)
        {

            if (dgv_requests.SelectedRows.Count <= 0) return;

            if ((cls_Requests.EN_RequestStatus)Convert.ToInt16(dgv_requests.SelectedRows[0].Cells["col_statusvalue"].Value) == cls_Requests.EN_RequestStatus.RequestsHaveBeenAccouted)
                return;

            int requestID = Convert.ToInt32(dgv_requests.SelectedRows[0].Cells["col_requestid"].Value);
            int userID = 1; // يتم إضافة المستخدم الحالي هنا عند اكتمال برمجته

            if (cls_Requests.SetRequestAs(requestID, (short)cls_Requests.EN_RequestStatus.RequestsHaveBeenAccouted, userID))
            {
                MessageBox.Show("تم محاسبة الطلب بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                _Refresh();
            }
            else
                MessageBox.Show("حدث خطأ اثناء محاسبة الطلب, يرجئ المحاولة مرة اخرئ.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void cmb_deleterequest_Click(object sender, EventArgs e)
        {

            if (dgv_requests.SelectedRows.Count <= 0) return;

            if (MessageBox.Show("هل متأكد من حذف الطلب؟", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {

                if (cls_Requests.Delete(Convert.ToInt32(dgv_requests.SelectedRows[0].Cells["col_requestid"].Value)))
                {
                    MessageBox.Show("تم حذف الطلب بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    _Refresh();
                }
                else
                    MessageBox.Show("حدث خطأ اثناء حذف الطلب, يرجئ المحاولة لاحقاً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }

        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataView _dv = _Requests.DefaultView;

            switch (cb_filter.SelectedItem.ToString())
            {

                case "الكل":
                    _dv.RowFilter = "";
                    break;

                case "طلبات المحاسبة":
                    _dv.RowFilter = "Status = 0";
                    break;

                case "طلبات سيتم محاسبتها لاحقا":
                    _dv.RowFilter = "Status = 1";
                    break;

                case "طلبات تم محاسبتها":
                    _dv.RowFilter = "Status = 2";
                    break;


            }

            _LoadRequests(_dv);
            txt_resertvationname.Text = string.Empty;

        }

        private void cmb_reservationname_Click(object sender, EventArgs e)
        {

            if (dgv_requests.Rows.Count <= 1)
                return;

            DataView _dv = _Requests.DefaultView;

            char _FirstDigitInFirstRow = dgv_requests.Rows[0].Cells["col_reservationname"].Value.ToString()[0];
            char _FirstDigitInLastRow = dgv_requests.Rows[dgv_requests.Rows.Count - 1].Cells["col_reservationname"].Value.ToString()[0];

            _dv.Sort = (_FirstDigitInFirstRow < _FirstDigitInLastRow) ?
                "ReservationName DESC" : "ReservationName ASC";

            _LoadRequests(_dv);

        }

        private void cmb_requeststatus_Click(object sender, EventArgs e)
        {
            
            DataView _dv = _Requests.DefaultView;
            _dv.Sort = "Status ASC";
            _LoadRequests(_dv);

        }

        private void txt_resertvationname_TextChanged(object sender, EventArgs e)
        {

            DataView _dv = _Requests.DefaultView;

            switch (cb_filter.SelectedItem.ToString())
            {

                case "الكل":
                    _dv.RowFilter = string.Format("ReservationName LIKE '{0}%'", txt_resertvationname.Text.Trim());
                    break;

                case "طلبات المحاسبة":
                    _dv.RowFilter = string.Format("ReservationName LIKE '{0}%' AND Status = 0", txt_resertvationname.Text.Trim());
                    break;

                case "طلبات سيتم محاسبتها لاحقا":
                    _dv.RowFilter = string.Format("ReservationName LIKE '{0}%' AND Status = 1", txt_resertvationname.Text.Trim());
                    break;

                case "طلبات تم محاسبتها":
                    _dv.RowFilter = string.Format("ReservationName LIKE '{0}%' AND Status = 2", txt_resertvationname.Text.Trim());
                    break;


            }

            _LoadRequests(_dv);

        }

        private void cmb_refresh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
