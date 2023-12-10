using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Services.frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cafe_Management_System.Forms.Tables.UserControls;
using Cafe_Management_System.Forms.Requests.UserControls;

namespace Cafe_Management_System.Forms.Services.UserControls
{
    public partial class UC_Services : UserControl
    {

        DataTable _Services;

        public UC_Services()
        {
            InitializeComponent();
            _Services = cls_Services.GetServices();
        }

        private void UC_Services_Load(object sender, EventArgs e)
        {
            _LoadDepartments();
            _LoadServices(_Services.DefaultView);
        }

        void _LoadDepartments()
        {

            cb_filter.Items.Clear();
            cb_filter.Items.Add("الكل");
            cb_filter.SelectedIndex = 0;

            DataTable _Departments = cls_ServicesDepartments.GetDepartments();

            foreach (DataRow row in _Departments.Rows)
                cb_filter.Items.Add(row["DepartmentName"]);

        }

        void _LoadServices(DataView dv)
        {

            dgv_services.Rows.Clear();

            for (int i = 0; i < dv.Count; i++)
            {

                string OptionsCountColumn = (Convert.ToInt32(dv[i]["COUNTOFOPTIONS"]) > 0) ?
                    dv[i]["COUNTOFOPTIONS"].ToString() + " " + "(انقر للعرض)"
                    :
                    dv[i]["COUNTOFOPTIONS"].ToString() + " " + "(لا يوجد خيارات)";

                dgv_services.Rows.Add((i + 1).ToString(), dv[i]["ServiceName"], dv[i]["ServiceDescription"],
                    dv[i]["DepartmentName"], OptionsCountColumn, dv[i]["ServiceID"],
                    dv[i]["ServiceImage"]);

            }

        }

        void _Refresh()
        {

            _Services = cls_Services.GetServices();
            _LoadServices(_Services.DefaultView);

            txt_servicename.Text = string.Empty;

            if (cb_filter.Items.Count > 0)
                cb_filter.SelectedIndex = 0;

        }

        private void cmb_addnew_Click(object sender, EventArgs e)
        {

            frm_AddUpdateService frm = new frm_AddUpdateService();
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_update_Click(object sender, EventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0) return;

            int serviceid = Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value);
            string servicename = dgv_services.SelectedRows[0].Cells["col_servicename"].Value.ToString();
            string servicedescription = dgv_services.SelectedRows[0].Cells["col_servicedescription"].Value.ToString();
            string serviceimage = dgv_services.SelectedRows[0].Cells["col_serviceimage"].Value.ToString();
            string departmentname = dgv_services.SelectedRows[0].Cells["col_departmentname"].Value.ToString();

            frm_AddUpdateService frm = new frm_AddUpdateService(serviceid, servicename, servicedescription,
                serviceimage, departmentname);
            frm.DataBack += _Refresh;
            frm.ShowDialog();


        }

        private void cmb_delete_Click(object sender, EventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0)
                return;


            if (MessageBox.Show("أمتاكد من حذف هذا القسم؟", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {

                if (cls_Services.IsServiceReferences(Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value)))
                {

                    MessageBox.Show("لا يمكن حذف هذه الخدمة لانها مرتبطة ببيانات اخرئ في النظام.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;

                }

                if (cls_Services.Delete(Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value)))
                {

                    MessageBox.Show("تم حذف الخدمة بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    if (File.Exists(dgv_services.SelectedRows[0].Cells["col_serviceimage"].Value.ToString()))
                        try
                        {
                            File.Delete(dgv_services.SelectedRows[0].Cells["col_serviceimage"].Value.ToString());
                        }
                        catch { }

                    _Refresh();

                }
                else
                    MessageBox.Show("حدث خطأ أثناء عملية الحذف, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            }

        }

        private void dgv_services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0)
                return;

            if (dgv_services.SelectedRows[0].Cells["col_serviceoptions"].ColumnIndex != e.ColumnIndex)
                return;

            frm_Options frm = new frm_Options(Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value));
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_showoptions_Click(object sender, EventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0)
                return;

            frm_Options frm = new frm_Options(Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value));
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void dgv_services_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0)
                return;

            int serviceid = Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value);
            string servicename = dgv_services.SelectedRows[0].Cells["col_servicename"].Value.ToString();
            string servicedescription = dgv_services.SelectedRows[0].Cells["col_servicedescription"].Value.ToString();
            string serviceimage = dgv_services.SelectedRows[0].Cells["col_serviceimage"].Value.ToString();
            string departmentname = dgv_services.SelectedRows[0].Cells["col_departmentname"].Value.ToString();

            frm_AddUpdateService frm = new frm_AddUpdateService(serviceid, servicename, servicedescription,
                serviceimage, departmentname);
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_addoption_Click(object sender, EventArgs e)
        {

            if (dgv_services.SelectedRows.Count <= 0)
                return;

            frm_AddUpdateOptions frm = new frm_AddUpdateOptions(Convert.ToInt32(dgv_services.SelectedRows[0].Cells["col_serviceid"].Value));
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_refresh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void cmb_sortbyname_Click(object sender, EventArgs e)
        {

            if (dgv_services.Rows.Count <= 1)
                return;

            DataView _dv = _Services.DefaultView;

            char _FirstDigitInFirstRow = dgv_services.Rows[0].Cells["col_servicename"].Value.ToString()[0];
            char _FirstDigitInLastRow = dgv_services.Rows[dgv_services.Rows.Count - 1].Cells["col_servicename"].Value.ToString()[0];

            _dv.Sort = (_FirstDigitInFirstRow < _FirstDigitInLastRow) ?
                "ServiceName DESC" : "ServiceName ASC";

            _LoadServices(_dv);

        }

        private void txt_searchtable_TextChanged(object sender, EventArgs e)
        {

            DataView _dv = _Services.DefaultView;

            _dv.RowFilter = (cb_filter.Text.Trim() == "الكل") ?
                    string.Format("ServiceName LIKE '{0}%'", txt_servicename.Text.Trim())
                :
                    string.Format("ServiceName LIKE '{0}%' AND DepartmentName = '{1}'", txt_servicename.Text.Trim(), cb_filter.Text.Trim());
            _LoadServices(_dv);

        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dgv_services.Rows.Count <= 0)
                return;

            DataView _dv = _Services.DefaultView;

            _dv.RowFilter = (cb_filter.Text.Trim() == "الكل") ?
                string.Empty : string.Format("DepartmentName = '{0}'", cb_filter.Text.Trim());

            _LoadServices(_dv);
            txt_servicename.Text = string.Empty;

        }

    }
}
