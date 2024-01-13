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
using Guna.UI2.WinForms;
using static System.Net.Mime.MediaTypeNames;
using Cafe_Management_System.Forms.Users.Forms;

namespace Cafe_Management_System.Forms.Users.UserControls
{
    public partial class UC_AddUpdateManagementUsers : UserControl
    {

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick; 

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _mode;

        int _UserID;
        cls_ManagementAppUser _User;
        long _CurrentUserPermissions;

        public UC_AddUpdateManagementUsers()
        {

            InitializeComponent();
            _mode = EN_Mode.addnew;

        }

        public UC_AddUpdateManagementUsers(int userID)
        {
            
            InitializeComponent();

            _UserID = userID;
            _User = cls_ManagementAppUser.Find(_UserID);
            _mode = EN_Mode.update;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OnBackClick();
        }

        private void _ResetPage()
        {

            pic_userimage.ImageLocation = null;
            pic_userimage.Image = Resources.empty_image;

            txt_firstname.Text = string.Empty;
            txt_secondname.Text = string.Empty;
            txt_lastname.Text = string.Empty;

            txt_username.Text = string.Empty;
            txt_password.Text = string.Empty;

            txt_password.Visible = (_mode == EN_Mode.addnew);

            dtp_dob.MinDate = DateTime.Now.AddYears(-50);
            dtp_dob.MaxDate = DateTime.Now.AddDays(-18);
            dtp_dob.Value = dtp_dob.MinDate;

            txt_idnumber.Text = string.Empty;
            txt_address.Text = string.Empty;

            rb_male.Checked = true;

            txt_phone1.Text = string.Empty;
            txt_phone2.Text = string.Empty;

            btn_deletepic.Visible = false;

            _User = null;
            GC.Collect();

        }

        private void _SetPageAsAddNew()
        {
            btn_deletepic.Visible = false;
            txt_password.Visible = true;
        }

        private void _SetPageAsUpdate()
        {

            if (!string.IsNullOrEmpty(_User.PersonImage))
            {
                pic_userimage.ImageLocation = _User.PersonImage;
                btn_deletepic.Visible = true;
            }
            else
            {
                pic_userimage.Image = Resources.empty_image;
                btn_deletepic.Visible = false;
            }

            txt_firstname.Text = _User.FirstName;
            txt_secondname.Text = _User.SecondName;
            txt_lastname.Text = string.IsNullOrEmpty(_User.LastName) ? string.Empty : _User.LastName;

            txt_username.Text = _User.UserName;
            txt_password.Visible = false;

            dtp_dob.Value = Convert.ToDateTime(_User.DOB.ToShortDateString());

            txt_idnumber.Text = string.IsNullOrEmpty(_User.IDNumber) ? string.Empty : _User.IDNumber;
            txt_address.Text = _User.Address;

            if (_User.Gender == cls_Person.EN_Gender.male)
                rb_male.Checked = true;
            else
                rb_female.Checked = true;

            txt_phone1.Text = _User.Phone1;
            txt_phone2.Text = string.IsNullOrEmpty(_User.Phone2) ? string.Empty : _User.Phone2;

        }

        private void _SetPage()
        {

            switch (_mode)
            {

                case EN_Mode.addnew:
                    _SetPageAsAddNew();
                    break;

                case EN_Mode.update:
                    _SetPageAsUpdate();
                    break;

            }

        }

        private void UC_AddUpdateManagementUsers_Load(object sender, EventArgs e)
        {
            _SetPage();
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

                pic_userimage.ImageLocation = openFileDialog1.FileName;
                btn_deletepic.Visible = true;

            }

        }

        private void btn_deletepic_Click(object sender, EventArgs e)
        {

            pic_userimage.ImageLocation = null;
            pic_userimage.Image = Resources.empty_image;
            btn_deletepic.Visible = false;

        }

        private bool _HandleUserImage()
        {

            if (_User.PersonImage != pic_userimage.ImageLocation)
            {

                if (!string.IsNullOrEmpty(_User.PersonImage))
                {

                    if (File.Exists(_User.PersonImage))
                    {

                        try
                        {
                            File.Delete(_User.PersonImage);
                        }

                        catch
                        {
                            MessageBox.Show("لم يتم حذف صورة المستخدم القديمة");
                        }

                    }

                }

                if (pic_userimage.ImageLocation != null)
                {

                    string imagepath = pic_userimage.ImageLocation.ToString();

                    if (cls_util.CopyImageToProjectImagesFolder(ref imagepath, cls_util.EN_Directory.ManagementAppUsersImages))
                    {

                        _User.PersonImage = imagepath;
                        return true;

                    }

                    else
                    {

                        MessageBox.Show("لم يتم حفظ الصورة", "information");
                        _User.PersonImage = null;
                        return false;

                    }

                }

                _User.PersonImage = null;

            }

            return true;

        }

        private void _AddNewUser()
        {

            _User = new cls_ManagementAppUser();

            if (!_HandleUserImage())
            {

                _User = null;
                GC.Collect();
                return;
            }

            _User.FirstName = txt_firstname.Text.Trim();
            _User.SecondName = txt_secondname.Text.Trim();
            _User.LastName = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.Trim();
            _User.UserName = txt_username.Text.Trim();
            _User.Password = txt_password.Text.Trim();
            _User.DOB = dtp_dob.Value;
            _User.IDNumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim();
            _User.Address = txt_address.Text.Trim();
            _User.Gender = (rb_male.Checked) ? cls_Person.EN_Gender.male : cls_Person.EN_Gender.female;
            _User.Phone1 = txt_phone1.Text.Trim();
            _User.Phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();

            _User.Permissions = _CurrentUserPermissions;

            if (_User.Save())
            {

                MessageBox.Show("تم إضافة المستخدم بنجاح", "information");
                _ResetPage();

            }
            else
                MessageBox.Show("حدث خطأ اثناء الإضافة", "information");

        }

        private void _UpdateUser()
        {

            if (!_HandleUserImage())
                return;

            _User.FirstName = txt_firstname.Text.Trim();
            _User.SecondName = txt_secondname.Text.Trim();
            _User.LastName = (string.IsNullOrEmpty(txt_lastname.Text)) ? null : txt_lastname.Text.Trim();
            _User.UserName = txt_username.Text.Trim();
            _User.Password = txt_password.Text.Trim();
            _User.DOB = dtp_dob.Value;
            _User.IDNumber = (string.IsNullOrEmpty(txt_idnumber.Text)) ? null : txt_idnumber.Text.Trim();
            _User.Address = txt_address.Text.Trim();
            _User.Gender = (rb_male.Checked) ? cls_Person.EN_Gender.male : cls_Person.EN_Gender.female;
            _User.Phone1 = txt_phone1.Text.Trim();
            _User.Phone2 = (string.IsNullOrEmpty(txt_phone2.Text)) ? null : txt_phone2.Text.Trim();

            _User.Permissions = _CurrentUserPermissions;

            if (_User.Save())
            {

                MessageBox.Show("تم التعديل بنجاح", "information");
                this.OnBackClick();
            }
            else
                MessageBox.Show("حدث خطأ اثناء التعديل", "information");

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
                return;

            switch (_mode)
            {

                case EN_Mode.addnew:
                    _AddNewUser();
                    break;

                case EN_Mode.update:
                    _UpdateUser();
                    break;

            }

        }

        private bool _ValidateNullValues(Guna2TextBox txt, string message, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, message);
                return false;
            }
            else
            {
                errorProvider1.SetError(txt, null);
                return true;
            }

        }

        private void txt_firstname_Validating(object sender, CancelEventArgs e)
        {
            _ValidateNullValues((Guna2TextBox)sender, "هذا الحقل مطلوب", e);
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {

            if (!_ValidateNullValues((Guna2TextBox)sender, "هذا الحقل مطلوب", e))
                return;

            switch (_mode)
            {

                case EN_Mode.addnew:

                    if (cls_ManagementAppUser.IsUserExist(txt_username.Text.Trim()))
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_username, "أسم المستخدم غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_username, null);

                    break;

                case EN_Mode.update:

                    if (cls_ManagementAppUser.IsUserExist(_User.UserID, txt_username.Text.Trim()))
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_username, "أسم المستخدم غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_username, null);

                    break;
            }

        }

        private void txt_phone1_Validating(object sender, CancelEventArgs e)
        {

            if (!_ValidateNullValues((Guna2TextBox)sender, "هذا الحقل مطلوب", e))
                return;

            switch (_mode)
            {

                case EN_Mode.addnew:

                    if (cls_ManagementAppUser.IsUserExistByPhone(txt_phone1.Text.Trim()))
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_phone1, "الهاتف 1 غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_phone1, null);

                    break;

                case EN_Mode.update:

                    if (cls_ManagementAppUser.IsUserExistByPhone(_UserID, txt_phone1.Text.Trim()))
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_phone1, "الهاتف 1 غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_phone1, null);

                    break;
            }

        }

        private void txt_phone2_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_phone2.Text))
                return;

            switch (_mode)
            {

                case EN_Mode.addnew:

                    if (cls_ManagementAppUser.IsUserExistByPhone(txt_phone2.Text.Trim()) || txt_phone1.Text.Trim() == txt_phone2.Text.Trim())
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_phone2, "الهاتف 2 غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_phone2, null);

                    break;

                case EN_Mode.update:

                    if (cls_ManagementAppUser.IsUserExistByPhone(_User.UserID, txt_phone2.Text.Trim()) || txt_phone1.Text.Trim() == txt_phone2.Text.Trim())
                    {

                        e.Cancel = true;
                        errorProvider1.SetError(txt_phone2, "الهاتف 2 غير متاح");

                    }
                    else
                        errorProvider1.SetError(txt_phone2, null);

                    break;
            }

        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {

            switch (_mode)
            {

                case EN_Mode.addnew:

                    if (string.IsNullOrEmpty(txt_password.Text))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txt_password, "هذا الحقل مطلوب");
                    }
                    else
                        errorProvider1.SetError(txt_password, null);

                    return;

                case EN_Mode.update:
                    return;

            }

        }

        private void txt_idnumber_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_idnumber.Text))
                return;

            switch (_mode)
            {

                case EN_Mode.addnew:

                    if (cls_ManagementAppUser.IsUserExistByIDNumber(txt_idnumber.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txt_idnumber, "رقم الهوية غير متاح");
                    }
                    else
                        errorProvider1.SetError(txt_idnumber, null);

                    break;

                case EN_Mode.update:

                    if (cls_ManagementAppUser.IsUserExistByIDNumber(_UserID ,txt_idnumber.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txt_idnumber, "رقم الهوية غير متاح");
                    }
                    else
                        errorProvider1.SetError(txt_idnumber, null);

                    break;

            }

        }

        private void txt_idnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_password_IconLeftClick(object sender, EventArgs e)
        {

            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.PasswordChar = '\0';
                txt_password.UseSystemPasswordChar = false;
                txt_password.IconLeft = Resources.hide_password;
            }
            else
            {
                txt_password.PasswordChar = '●';
                txt_password.UseSystemPasswordChar = true;
                txt_password.IconLeft = Resources.show_password;
            }

        }

        void UserPermissionsDataBack(long Permissions)
        {

            _CurrentUserPermissions = Permissions;

        }

        private void lbl_showpermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frm_UserPermissions frm;

            switch (_mode)
            {

                case EN_Mode.addnew:

                    frm = new frm_UserPermissions();
                    frm.DataBack += UserPermissionsDataBack;
                    frm.ShowDialog();
                    break;

                case EN_Mode.update:

                    frm = new frm_UserPermissions(_User.Permissions);
                    frm.DataBack += UserPermissionsDataBack;
                    frm.ShowDialog();
                    break;

            }

        }
    }
}
