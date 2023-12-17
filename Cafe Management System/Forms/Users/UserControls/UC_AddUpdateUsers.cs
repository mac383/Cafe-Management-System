using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Users.UsersEventsArgsClasses;
using Cafe_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cafe_Management_System.GLOBAL_CLASSES;

namespace Cafe_Management_System.Forms.Users.UserControls
{
    public partial class UC_AddUpdateUsers : UserControl
    {

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick; 

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        cls_ManagementAppUser _ManagementUser;
        cls_ServicesAppUser _ServicesUser;

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

            pic_userimage.ImageLocation = null;
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

            lbl_department.Text = (_UserDepartment == cls_ShowUserEventArgs.EN_UserDepartment.Management) ?
                "قسم الإدارة" : "قسم الخدمات";

            lbl_showpermissions.Visible = (_UserDepartment == cls_ShowUserEventArgs.EN_UserDepartment.Management);

            dtp_dob.Value = dtp_dob.MaxDate;
            btn_deletepic.Visible = false;

        }

        void _LoadUserInfo()
        {

            switch (_UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:

                    _ManagementUser = cls_ManagementAppUser.Find(_UserID);

                    if (_ManagementUser != null)
                    {

                        if (!string.IsNullOrEmpty(_ManagementUser.PersonImage))
                            pic_userimage.ImageLocation = _ManagementUser.PersonImage;

                        txt_firstname.Text = _ManagementUser.FirstName;
                        txt_secondname.Text = _ManagementUser.SecondName;
                        txt_lastname.Text = (string.IsNullOrEmpty(_ManagementUser.LastName)) ? string.Empty : _ManagementUser.LastName;
                        txt_username.Text = _ManagementUser.UserName;
                        dtp_dob.Value = Convert.ToDateTime(_ManagementUser.DOB.ToShortDateString());
                        txt_idnumber.Text = (string.IsNullOrEmpty(_ManagementUser.IDNumber)) ? string.Empty : _ManagementUser.IDNumber;
                        txt_address.Text = _ManagementUser.Address;

                        if (_ManagementUser.Gender == cls_Person.EN_Gender.male)
                            rb_male.Checked = true;
                        else
                            rb_female.Checked = true;

                        txt_phone1.Text = _ManagementUser.Phone1;
                        txt_phone2.Text = (string.IsNullOrEmpty(_ManagementUser.Phone2)) ? string.Empty : _ManagementUser.Phone2;

                    }

                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:

                    _ServicesUser = cls_ServicesAppUser.Find(_UserID);

                    if (_ServicesUser != null)
                    {

                        if (!string.IsNullOrEmpty(_ServicesUser.PersonImage))
                            pic_userimage.ImageLocation = _ServicesUser.PersonImage;

                        txt_firstname.Text = _ServicesUser.FirstName;
                        txt_secondname.Text = _ServicesUser.SecondName;
                        txt_lastname.Text = (string.IsNullOrEmpty(_ServicesUser.LastName)) ? string.Empty : _ServicesUser.LastName;
                        txt_username.Text = _ServicesUser.UserName;
                        dtp_dob.Value = Convert.ToDateTime(_ServicesUser.DOB.ToShortDateString());
                        txt_idnumber.Text = (string.IsNullOrEmpty(_ServicesUser.IDNumber)) ? string.Empty : _ServicesUser.IDNumber;
                        txt_address.Text = _ServicesUser.Address;

                        if (_ServicesUser.Gender == cls_Person.EN_Gender.male)
                            rb_male.Checked = true;
                        else
                            rb_female.Checked = true;

                        txt_phone1.Text = _ServicesUser.Phone1;
                        txt_phone2.Text = (string.IsNullOrEmpty(_ServicesUser.Phone2)) ? string.Empty : _ServicesUser.Phone2;

                    }

                    break;

            }

            btn_deletepic.Visible = (pic_userimage.ImageLocation != null);

        }

        void _SetPageAsAddNew()
        {

            txt_password.Visible = true;

            switch (_UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:
                    _ManagementUser = new cls_ManagementAppUser();
                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:
                    _ServicesUser = new cls_ServicesAppUser();
                    break;
            }

        }

        void _SetPageAsUpdate()
        {

            txt_password.Visible = false;
            _LoadUserInfo();

        }

        void _SetPage()
        {

            _ResetPage();

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

        bool _CheckControlsValues()
        {

            if (string.IsNullOrEmpty(txt_firstname.Text))
                return false;

            if (string.IsNullOrEmpty(txt_secondname.Text))
                return false;

            if (string.IsNullOrEmpty(txt_username.Text))
                return false;

            if (_Mode == EN_Mode.addnew)
                if (string.IsNullOrEmpty(txt_password.Text))
                    return false;

            if (string.IsNullOrEmpty(txt_address.Text))
                return false;

            if (string.IsNullOrEmpty(txt_phone1.Text))
                return false;

            return true;

        }

        bool _HandleManagementAppUsersImage()
        {

            if (_ManagementUser.PersonImage != pic_userimage.ImageLocation)
            {

                if (!string.IsNullOrEmpty(_ManagementUser.PersonImage))
                {

                    try
                    {
                        File.Delete(_ManagementUser.PersonImage);
                    }

                    catch { return false; }

                }

                if (!string.IsNullOrEmpty(pic_userimage.ImageLocation))
                {

                    string _SelectedImagePath = pic_userimage.ImageLocation.ToString();

                    try
                    {

                        if (cls_util.CopyImageToProjectImagesFolder(ref _SelectedImagePath, cls_util.EN_Directory.ManagementAppUsersImages))
                        {
                            _ManagementUser.PersonImage = _SelectedImagePath;
                            return true;
                        }
                        else
                        {
                            _ManagementUser.PersonImage = null;
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _ManagementUser.PersonImage = null;
                        return false;
                    }
                }
                _ManagementUser.PersonImage = null;

            }

            return true;

        }

        bool _HandleServicesAppUsersImage()
        {

            if (_ServicesUser.PersonImage != pic_userimage.ImageLocation)
            {

                if (!string.IsNullOrEmpty(_ServicesUser.PersonImage))
                {

                    try
                    {
                        File.Delete(_ServicesUser.PersonImage);
                    }

                    catch { return false; }

                }

                if (!string.IsNullOrEmpty(pic_userimage.ImageLocation))
                {

                    string _SelectedImagePath = pic_userimage.ImageLocation.ToString();

                    try
                    {

                        if (cls_util.CopyImageToProjectImagesFolder(ref _SelectedImagePath, cls_util.EN_Directory.ServicesAppUsersImages))
                        {
                            _ServicesUser.PersonImage = _SelectedImagePath;
                            return true;
                        }
                        else
                        {
                            _ServicesUser.PersonImage = null;
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _ServicesUser.PersonImage = null;
                        return false;
                    }
                }
                _ServicesUser.PersonImage = null;

            }

            return true;

        }

        void _AddNewUser()
        {

            if (!_CheckControlsValues())
            {
                MessageBox.Show("يجب إدخال جميع البيانات في الحقول التي تحتوي علئ (*)", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            switch (_UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:

                    if (_ManagementUser == null)
                        _ManagementUser = new cls_ManagementAppUser();

                    if (!_HandleManagementAppUsersImage())
                        return;

                    _ManagementUser.FirstName = txt_firstname.Text.Trim();
                    _ManagementUser.SecondName = txt_secondname.Text.Trim();
                    _ManagementUser.LastName = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.Trim();
                    _ManagementUser.UserName = txt_username.Text.Trim();
                    _ManagementUser.Password = txt_password.Text.Trim();
                    _ManagementUser.DOB = dtp_dob.Value;
                    _ManagementUser.IDNumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim();
                    _ManagementUser.Address = txt_address.Text.Trim();
                    _ManagementUser.Gender = (rb_male.Checked) ? cls_Person.EN_Gender.male : cls_Person.EN_Gender.female;
                    _ManagementUser.Phone1 = txt_phone1.Text.Trim();
                    _ManagementUser.Phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();

                    _ManagementUser.Permissions = -1;

                    if (_ManagementUser.Save())
                    {
                        MessageBox.Show("تم إضافة المستخدم بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        _ManagementUser = null;
                        GC.Collect();
                        _ResetPage();
                    }
                    else
                        MessageBox.Show("حدث خطأ اثناء الإضافة يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:

                    if (_ServicesUser == null)
                        _ServicesUser = new cls_ServicesAppUser();

                    if (!_HandleServicesAppUsersImage())
                        return;

                    _ServicesUser.FirstName = txt_firstname.Text.Trim();
                    _ServicesUser.SecondName = txt_secondname.Text.Trim();
                    _ServicesUser.LastName = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.Trim();
                    _ServicesUser.UserName = txt_username.Text.Trim();
                    _ServicesUser.Password = txt_password.Text.Trim();
                    _ServicesUser.DOB = dtp_dob.Value;
                    _ServicesUser.IDNumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim();
                    _ServicesUser.Address = txt_address.Text.Trim();
                    _ServicesUser.Gender = (rb_male.Checked) ? cls_Person.EN_Gender.male : cls_Person.EN_Gender.female;
                    _ServicesUser.Phone1 = txt_phone1.Text.Trim();
                    _ServicesUser.Phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();

                    if (_ServicesUser.Save())
                    {
                        MessageBox.Show("تم إضافة المستخدم بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        _ServicesUser = null;
                        GC.Collect();
                        _ResetPage();
                    }
                    else
                        MessageBox.Show("حدث خطأ اثناء الإضافة يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    break;

            }

        }

        void _UpdateUser()
        {

            string firstname, secondname, lastname, username, idnumber, address, phone1, phone2, personimage;
            DateTime dob;
            bool gender;

            switch (_UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:

                    if (!_HandleManagementAppUsersImage())
                        return;

                    firstname = txt_firstname.Text.ToString().Trim();
                    secondname = txt_secondname.Text.ToString().Trim();
                    lastname = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.ToString().Trim();
                    username = txt_username.Text.Trim();
                    dob = dtp_dob.Value;
                    idnumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim(); ;
                    address = txt_address.Text.Trim();
                    gender = (rb_male.Checked);
                    phone1 = txt_phone1.Text.Trim();
                    phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();
                    personimage = _ManagementUser.PersonImage;
                    
                    long permissions = -1;

                    _ManagementUser = new cls_ManagementAppUser(_UserID, permissions, firstname, secondname, lastname, gender, address, username,
                        dob, idnumber, phone1, phone2, personimage);

                    if (_ManagementUser.Save())
                    {
                        MessageBox.Show("تم التعديل بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        OnBackClick();
                    }
                    else
                        MessageBox.Show("حدث خطأ اثناء التعديل يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:

                    if (!_HandleServicesAppUsersImage())
                        return;

                    firstname = txt_firstname.Text.ToString().Trim();
                    secondname = txt_secondname.Text.ToString().Trim();
                    lastname = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.ToString().Trim();
                    username = txt_username.Text.Trim();
                    dob = dtp_dob.Value;
                    idnumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim(); ;
                    address = txt_address.Text.Trim();
                    gender = (rb_male.Checked);
                    phone1 = txt_phone1.Text.Trim();
                    phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();
                    personimage = _ServicesUser.PersonImage;

                    _ServicesUser = new cls_ServicesAppUser(_UserID, firstname, secondname, lastname, gender, address, username, dob, idnumber, phone1, phone2, personimage);

                    if (_ServicesUser.Save())
                    {
                        MessageBox.Show("تم التعديل بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        OnBackClick();
                    }
                    else
                        MessageBox.Show("حدث خطأ اثناء التعديل يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackClick();
        }

        private void btn_addpic_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "أختر صورة";
            openFileDialog1.InitialDirectory = @"C:\Users\2021\OneDrive\سطح المكتب";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Image Files |*.jpg;*.pnl;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pic_userimage.ImageLocation = openFileDialog1.FileName.ToString();
                btn_deletepic.Visible = true;

            }

        }

        private void UC_AddUpdateUsers_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void btn_deletepic_Click(object sender, EventArgs e)
        {
            pic_userimage.ImageLocation = null;
            pic_userimage.Image = Resources.empty_image;
            btn_deletepic.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            switch (_Mode)
            {

                case EN_Mode.addnew:
                    _AddNewUser();
                    break;

                case EN_Mode.update:
                    _UpdateUser();
                    break;

            }

        }
    }
}
