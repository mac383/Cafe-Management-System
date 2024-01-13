using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES;
using Cafe_Management_System.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Settings.UserControls
{

    public partial class UC_Permissions : UserControl
    {

        long _Permissions;

        public event EventHandler<long> OnPermissionsSelected;

        private void OnPermissionsSelectedHandler(long Permissions)
        {
            
            if (OnPermissionsSelected != null)
                OnPermissionsSelected(this, Permissions);

        }

        enum EN_Mode { AddNew = 1, Update = 2 }
        EN_Mode _Mode;

        public UC_Permissions()
        {

            InitializeComponent();
            _Mode = EN_Mode.AddNew;

        }

        public UC_Permissions(long Permissions, bool ReadOnly)
        {

            InitializeComponent();

            this._Permissions = Permissions;
            btn_createkey.Enabled = !ReadOnly;
            _Mode = EN_Mode.Update;

        }

        private void UC_Permissions_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void _ResetCheckBoxes()
        {

            foreach (Control ctrl in this.Controls)
                if (ctrl is Guna2CheckBox)
                    ((Guna2CheckBox)ctrl).Checked = false;

        }

        private void _SetPermissions()
        {

            if (this._Permissions == -1)
            {
                chb_selectall.Checked = true;
                return;
            }

            if (this._Permissions == 0)
                _ResetCheckBoxes();

            foreach (Control ctrl in this.Controls)
                if (ctrl is Guna2CheckBox)
                    if ((this._Permissions & Convert.ToInt64(ctrl.Tag)) == Convert.ToInt64(ctrl.Tag))
                        ((Guna2CheckBox)ctrl).Checked = true;

        }

        private void _AddNewMode()
        {

            _ResetCheckBoxes();

        }

        private void _UpdateMode()
        {

            _SetPermissions();

        }

        private void _SetPage()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    _AddNewMode();
                    break;

                case EN_Mode.Update:
                    _UpdateMode();
                    break;

            }

        }

        private void chb_selectall_CheckedChanged(object sender, EventArgs e)
        {

            if (!chb_selectall.Checked)
                return;

            foreach (Control ctrl in this.Controls)
                if (ctrl is Guna2CheckBox && ctrl != chb_selectall)
                    ((Guna2CheckBox)ctrl).Checked = false;

        }

        private void chb_showrequests_CheckedChanged(object sender, EventArgs e)
        {

            if (((Guna2CheckBox)sender).Checked)
                chb_selectall.Checked = false;

        }

        private void btn_createkey_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
                if (ctrl is Guna2CheckBox)
                    if (((Guna2CheckBox)ctrl).Checked)
                    {
                        OnPermissionsSelectedHandler(_GetPermissionsValue());
                        return;
                    }

        }

        private long _GetPermissionsValue()
        {

            long Permissions = 0;

            foreach (Control ctrl in this.Controls)
                if (ctrl is Guna2CheckBox)
                    if (((Guna2CheckBox)ctrl).Checked)
                        Permissions += Convert.ToInt64(((Guna2CheckBox)ctrl).Tag);

            return Permissions;

        }

    }
}
