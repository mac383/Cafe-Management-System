using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Tables.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Services.frms
{
    public partial class frm_Options : Form
    {

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler DataBack;

        cls_Services _Service;
        cls_SystemInfo _SystemInfo;
        DataTable _Options;

        public frm_Options(int ServiceID)
        {
            InitializeComponent();
            _Service = cls_Services.Find(ServiceID);
            _SystemInfo = cls_SystemInfo.GetSystemInfo();
        }

        void _LoadOptions()
        {

            dgv_options.Rows.Clear();

            int Counter = 1;

            foreach (DataRow row in _Options.Rows)
            {

                dgv_options.Rows.Add(Counter++.ToString(), row["OptionName"], Convert.ToInt32(row["OptionPrice"]), row["ServiceName"],
                    row["OptionID"], row["OptionValue"]);

            }

        }

        void _Refresh()
        {

            _Options = cls_Options.GetOptions(_Service.ServiceID);
            _LoadOptions();

        }

        private void frm_Options_Load(object sender, EventArgs e)
        {

            lbl_pagetitle.Text = "خيارات الخدمة (" + _Service.ServiceName + ")";
            dgv_options.Columns["col_optionprice"].HeaderText += " (" + _SystemInfo.Currency.ToString() + ")";
            _Options = cls_Options.GetOptions(_Service.ServiceID);
            _LoadOptions();

        }

        private void cmb_addnew_Click(object sender, EventArgs e)
        {

            frm_AddUpdateOptions frm = new frm_AddUpdateOptions(_Service.ServiceID);
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void frm_Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DataBack.Invoke();
        }

        private void cmb_update_Click(object sender, EventArgs e)
        {

            if (dgv_options.SelectedRows.Count <= 0)
                return;

            int optionid = Convert.ToInt32(dgv_options.SelectedRows[0].Cells["col_optionid"].Value);
            string optionname = dgv_options.SelectedRows[0].Cells["col_optionname"].Value.ToString();
            double optionprice = Convert.ToDouble(dgv_options.SelectedRows[0].Cells["col_optionprice"].Value);
            long optionvalue = Convert.ToInt64(dgv_options.SelectedRows[0].Cells["col_optionvalue"].Value);

            frm_AddUpdateOptions frm = new frm_AddUpdateOptions(optionid, optionname, optionprice, optionvalue);
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_delete_Click(object sender, EventArgs e)
        {

            if (dgv_options.SelectedRows.Count <= 0)
                return;

            if (MessageBox.Show("أمتاكد من حذف هذا الخيار؟", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                if (cls_Options.Delete(Convert.ToInt32(dgv_options.SelectedRows[0].Cells["col_optionid"].Value)))
                {
                    MessageBox.Show("تم حذف الخدمة بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    _Refresh();
                }
                else
                    MessageBox.Show("حدث خطأ أثناء عملية الحذف, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void dgv_options_DoubleClick(object sender, EventArgs e)
        {

            if (dgv_options.SelectedRows.Count <= 0)
                return;

            int optionid = Convert.ToInt32(dgv_options.SelectedRows[0].Cells["col_optionid"].Value);
            string optionname = dgv_options.SelectedRows[0].Cells["col_optionname"].Value.ToString();
            double optionprice = Convert.ToDouble(dgv_options.SelectedRows[0].Cells["col_optionprice"].Value);
            long optionvalue = Convert.ToInt64(dgv_options.SelectedRows[0].Cells["col_optionvalue"].Value);

            frm_AddUpdateOptions frm = new frm_AddUpdateOptions(optionid, optionname, optionprice, optionvalue);
            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }
    }
}
