using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Settings.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Settings.frms
{
    public partial class frm_KeyPermissions : Form
    {

        public delegate void DateBackEventHandler();
        public event DateBackEventHandler DataBack;

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        string _Key;
        long _Permissions;
        bool _ReadOnly;

        public frm_KeyPermissions()
        {
            InitializeComponent();
            _Mode = EN_Mode.addnew;
        }

        public frm_KeyPermissions(string Key, long Permissions, bool ReadOnly)
        {

            InitializeComponent();

            _Key = Key;
            this._Permissions = Permissions;
            _ReadOnly = ReadOnly;
            _Mode = EN_Mode.update;

        }

        void _KeyCompletedSuccessfully(object sender, cls_Key e)
        {
            
            switch (_Mode)
            {

                case EN_Mode.addnew:
                    MessageBox.Show("تم إنشاء المفتاح بنجاح\nالمفتاح: " + e.Key, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case EN_Mode.update:
                    MessageBox.Show("تم تعديل صلاحيات المفتاح بنجاح", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

            if (DataBack != null)
                DataBack();

            this.Close();

        }

        void _OnPermissionsSelected(object sender, long e)
        {

            frm_ConfirmKeyPassword frm;

            switch (_Mode)
            {

                case EN_Mode.addnew:
                    frm = new frm_ConfirmKeyPassword(e);
                    frm.OnKeyCompletedSuccessfully += _KeyCompletedSuccessfully;
                    frm.ShowDialog();
                    break;

                case EN_Mode.update:
                    frm = new frm_ConfirmKeyPassword(_Key, e);
                    frm.OnKeyCompletedSuccessfully += _KeyCompletedSuccessfully;
                    frm.ShowDialog();
                    break;

            }

        }

        void _AddNewMode()
        {

            UC_Permissions uc = new UC_Permissions();
            uc.Location = new Point(19, 67);
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uc.OnPermissionsSelected += this._OnPermissionsSelected;
            pnl_body.Controls.Add(uc);

        }

        void _UpdateMode()
        {

            UC_Permissions uc = new UC_Permissions(_Permissions, _ReadOnly);
            uc.Location = new Point(19, 67);
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uc.OnPermissionsSelected += this._OnPermissionsSelected;
            pnl_body.Controls.Add(uc);

        }

        void _SetPage()
        {
            
            switch (_Mode)
            {

                case EN_Mode.addnew:
                    _AddNewMode();
                    break;

                case EN_Mode.update:
                    _UpdateMode();
                    break;

            }
        }

        private void frm_KeyPermissions_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

    }
}
