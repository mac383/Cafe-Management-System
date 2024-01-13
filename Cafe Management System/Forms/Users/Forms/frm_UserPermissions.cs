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

namespace Cafe_Management_System.Forms.Users.Forms
{
    public partial class frm_UserPermissions : Form
    {

        public delegate void DateBackEventHandler(long Permissions);
        public event DateBackEventHandler DataBack;

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        long _Permissions;

        public frm_UserPermissions()
        {
            InitializeComponent();
            _Mode = EN_Mode.addnew;
        }

        public frm_UserPermissions(long Permissions)
        {
            InitializeComponent();
            this._Permissions = Permissions;
            _Mode = EN_Mode.update;
        }

        void _DataBackHandler(object sender, long e)
        {

            if (DataBack != null)
                DataBack(e);

            this.Close();

        }

        void _AddNewMode()
        {

            UC_Permissions uc = new UC_Permissions();
            uc.Location = new Point(19, 67);
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uc.OnPermissionsSelected += this._DataBackHandler;

            pnl_body.Controls.Add(uc);

        }

        void _UpdateMode()
        {

            UC_Permissions uc = new UC_Permissions(_Permissions, false);
            uc.Location = new Point(19, 67);
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            uc.OnPermissionsSelected += this._DataBackHandler;
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

        private void frm_UserPermissions_Load(object sender, EventArgs e)
        {
            _SetPage();
        }
    }
}
