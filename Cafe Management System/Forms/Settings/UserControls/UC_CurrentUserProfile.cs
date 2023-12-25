using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Users.UserControls;
using Cafe_Management_System.GLOBAL_CLASSES;
using Cafe_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Settings.UserControls
{
    public partial class UC_CurrentUserProfile : UserControl
    {

        public event Action<int> OnUpdate;
        protected virtual void HandleOnUpdateEvent()
        {

            if (OnUpdate != null)
                OnUpdate(_User.UserID);

        }

        cls_ManagementAppUser _User;

        public UC_CurrentUserProfile()
        {
            
            InitializeComponent();
            _User = cls_Global.User;

        }

        private void lbl_changepassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            txt_oldpassword.Text = string.Empty;
            txt_oldpassword.UseSystemPasswordChar = true;
            txt_oldpassword.IconLeft = Resources.show_password;

            txt_newpassword.Text = string.Empty;
            txt_newpassword.UseSystemPasswordChar = true;
            txt_newpassword.IconLeft = Resources.show_password;

            if (this._User != null)
            {

                if (this.Height == this.MinimumSize.Height)
                {
                    this.Height = this.MaximumSize.Height;
                    lbl_changepassword.Text = "عرض اقل";
                    lbl_changepassword.Location = new Point((this.Width - lbl_changepassword.Width) / 2, lbl_changepassword.Location.Y);
                }

                else
                {
                    this.Height = this.MinimumSize.Height;
                    lbl_changepassword.Text = "تغيير كلمة المرور";
                    lbl_changepassword.Location = new Point((this.Width - lbl_changepassword.Width) / 2, lbl_changepassword.Location.Y);
                }

            }

        }

        private void _ResetPage()
        {

            pic_userimage.Image = Resources.empty_image;

            lbl_fullname.Text = "????";
            lbl_username.Text = "????";
            lbl_phone.Text = "????";

            txt_oldpassword.Text = string.Empty;
            txt_newpassword.Text = string.Empty;

            this.Height = this.MinimumSize.Height;

        }

        private void _LoadUserInfo()
        {

            _User = cls_ManagementAppUser.Find(1);

            if (_User == null)
            {
                _ResetPage();
                return;
            }

            if (!string.IsNullOrEmpty(_User.PersonImage))
                pic_userimage.ImageLocation = _User.PersonImage;

            lbl_fullname.Text = _User.FirstName + " " + _User.SecondName + " " + _User.LastName;
            lbl_username.Text = _User.UserName;
            lbl_phone.Text = _User.Phone1;

        }

        private void UC_CurrentUserProfile_Load(object sender, EventArgs e)
        {
            _LoadUserInfo();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (_User == null)
                return;

            HandleOnUpdateEvent();

        }

        private void btn_savepassword_Click(object sender, EventArgs e)
        {

            if (_User == null)
                return;

            if (string.IsNullOrEmpty(txt_oldpassword.Text))
            {
                MessageBox.Show("أدخل كلمة السر القديمة");
                return;
            }

            if (string.IsNullOrEmpty(txt_newpassword.Text))
            {
                MessageBox.Show("أدخل كلمة السر الجديدة");
                return;
            }

            if (_User.Password != txt_oldpassword.Text.Trim())
            {
                MessageBox.Show("كلمة السر غير صحيحة    ");
                return;
            }

            if (txt_oldpassword.Text.Trim() == txt_newpassword.Text.Trim())
            {
                MessageBox.Show("يجب تغيير كلمة السر الجديدة");
                return;
            }

            if (_User.ChangePassword(txt_newpassword.Text.Trim()))
            {
                MessageBox.Show("تم تعديل كلمة السر بنجاح");
                lbl_changepassword_LinkClicked(null, null);
            }
            else
                MessageBox.Show("خطأ اثناء تعديل كلمة السر");

        }

        private void txt_oldpassword_IconLeftClick(object sender, EventArgs e)
        {

            if (txt_oldpassword.UseSystemPasswordChar)
            {
                txt_oldpassword.PasswordChar = '\0';
                txt_oldpassword.UseSystemPasswordChar = false;
                txt_oldpassword.IconLeft = Resources.hide_password;
            }
            else
            {
                txt_oldpassword.PasswordChar = '●';
                txt_oldpassword.UseSystemPasswordChar = true;
                txt_oldpassword.IconLeft = Resources.show_password;
            }

        }

        private void txt_newpassword_IconLeftClick(object sender, EventArgs e)
        {

            if (txt_newpassword.UseSystemPasswordChar)
            {
                txt_newpassword.PasswordChar = '\0';
                txt_newpassword.UseSystemPasswordChar = false;
                txt_newpassword.IconLeft = Resources.hide_password;
            }
            else
            {
                txt_newpassword.PasswordChar = '●';
                txt_newpassword.UseSystemPasswordChar = true;
                txt_newpassword.IconLeft = Resources.show_password;
            }

        }
    }
}
