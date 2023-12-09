using CAFE_MANAGEMENT_BUSINESS.CLASSES;
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
    public partial class frm_AddUpdateOptions : Form
    {

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler DataBack;

        enum EN_Mode { AddNew = 1, Update = 2 }
        EN_Mode _Mode;

        cls_Options _Option;

        public frm_AddUpdateOptions(int ServiceID)
        {
            InitializeComponent();
            _Option = new cls_Options(ServiceID);
            _Mode = EN_Mode.AddNew;
        }

        public frm_AddUpdateOptions(int OptionID, string OptionName, double OptionPrice, long OptionValue)
        {
            InitializeComponent();
            _Option = new cls_Options(OptionID, OptionName, OptionPrice, OptionValue);
            _Mode = EN_Mode.Update;
        }

        void _LoadServices()
        {

            cb_services.Items.Clear();
            DataTable _Services = cls_Services.GetServices();

            foreach (DataRow row in _Services.Rows)
                cb_services.Items.Add(row["ServiceName"]);

        }

        void _SetAddNewMode()
        {
            
            lbl_pagetitle.Text = "إضافة خيار جديد";
            txt_optionname.Text = string.Empty;
            nud_optionprice.Value = 0;

            if (cb_services.Items.Count > 0)
                cb_services.SelectedIndex = cb_services.FindString(_Option.Service.ServiceName);

            btn_addupdate.Text = "إضافة";

        }

        void _SetUpdateMode()
        {

            lbl_pagetitle.Text = "تعديل بيانات الخيارات";
            txt_optionname.Text = _Option.OptionName;
            nud_optionprice.Value = Convert.ToDecimal(_Option.OptionPrice);

            if (cb_services.Items.Count > 0)
                cb_services.SelectedIndex = cb_services.FindString(_Option.Service.ServiceName);

            btn_addupdate.Text = "تعديل";

        }

        void _SetPage()
        {

            _LoadServices();

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    _SetAddNewMode();
                    break;

                case EN_Mode.Update:
                    _SetUpdateMode();
                    break;

            }

        }

        private void frm_AddUpdateOptions_Load(object sender, EventArgs e)
        {

            lbl_optionpricelbl.Text += " (" + cls_SystemInfo.GetSystemInfo().Currency + ").";
            _SetPage();

        }

        private void btn_addupdate_Click(object sender, EventArgs e)
        {

            if (_Mode == EN_Mode.AddNew)
                _Option.OptionValue = cls_Options.GetMaximumOptionValue() * 2;

            if (string.IsNullOrEmpty(txt_optionname.Text))
            {

                MessageBox.Show("الرجاء إدخال أسم الخيار.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_optionname.Focus();
                return;

            }

            switch (_Mode)
            {

                case EN_Mode.AddNew:

                    if (cls_Options.IsExist(txt_optionname.Text.ToString().Trim()))
                    {
                        MessageBox.Show("أسم الخيار موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_optionname.Focus();
                        return;
                    }
                    break;

                case EN_Mode.Update:
                    if (cls_Options.IsExist(_Option.OptionID, txt_optionname.Text.ToString().Trim()))
                    {
                        MessageBox.Show("أسم الخيار موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_optionname.Focus();
                        return;
                    }
                    break;

            }

            _Option.OptionName = txt_optionname.Text;
            _Option.OptionPrice = Convert.ToDouble(nud_optionprice.Value);

            if (_Option.Save())
            {

                MessageBox.Show("تم حفظ المعلومات بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                DataBack?.Invoke();

                switch (_Mode)
                {

                    case EN_Mode.AddNew:
                        txt_optionname.Text = string.Empty;
                        nud_optionprice.Value = 0;
                        txt_optionname.Focus();
                        _Option = new cls_Options(this._Option.Service.ServiceID);
                        break;

                    case EN_Mode.Update:
                        this.Close();
                        break;

                }

            }
            else
            {

                MessageBox.Show("حدث خطأ اثناء حفظ المعلومات, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_optionname.Focus();

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
