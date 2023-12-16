using Cafe_Management_System.Forms.Users.UsersEventsArgsClasses;
using Cafe_Management_System.Properties;
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

namespace Cafe_Management_System.Forms.Users.UserControls
{
    public partial class UC_AddUpdateUsers : UserControl
    {

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick; 

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        int _UserID;
        cls_ShowUserEventArgs.EN_UserDepartment _UserDepartment;

        public UC_AddUpdateUsers(cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            InitializeComponent();

            this._UserDepartment = userDepartment;
            this._Mode = EN_Mode.addnew;

        }

        public UC_AddUpdateUsers(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            InitializeComponent();

            this._UserID = userID;
            this._UserDepartment = userDepartment;
            this._Mode = EN_Mode.update;

        }


        void _ResetPage()
        {

            dtp_dob.MaxDate = DateTime.Now.AddYears(-18);
            dtp_dob.MinDate = DateTime.Now.AddYears(-65);

            pic_userimage.Image = Resources.empty_image;

            txt_firstname.Text = string.Empty;
            txt_secondname.Text = string.Empty;
            txt_lastname.Text = string.Empty;
            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_idnumber.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_phone1.Text = string.Empty;
            txt_phone2.Text = string.Empty;

            dtp_dob.Value = dtp_dob.MaxDate;
            btn_deletepic.Visible = false;

        }

        void _SetPageAsAddNew()
        {

            

        }

        void _SetPageAsUpdate()
        {

        }

        void _SetPage()
        {

            _ResetPage();

            lbl_showpermissions.Visible = (_UserDepartment == cls_ShowUserEventArgs.EN_UserDepartment.Management);

            switch (_Mode)
            {

                case EN_Mode.addnew:
                    _SetPageAsAddNew();

                    break;

                case EN_Mode.update:
                    _SetPageAsUpdate();

                    break;

            }

        }



        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackClick();
        }

        private void btn_addpic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void UC_AddUpdateUsers_Load(object sender, EventArgs e)
        {
            _SetPage();
        }
    }
}
