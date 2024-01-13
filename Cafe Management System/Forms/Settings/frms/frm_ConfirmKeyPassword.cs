using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES;
using Cafe_Management_System.Properties;
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
    public partial class frm_ConfirmKeyPassword : Form
    {

        public event EventHandler<cls_Key> OnKeyCompletedSuccessfully;
        
        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        cls_Key _CurrentKey;

        string _Key;
        long _Permissions;

        public frm_ConfirmKeyPassword(long Permissions)
        {

            InitializeComponent();
            _Permissions = Permissions;
            _Mode = EN_Mode.addnew;

        }

        public frm_ConfirmKeyPassword(string Key, long Permissions)
        {

            InitializeComponent();

            _CurrentKey = cls_Key.Find(Key);
            _Key = Key;
            _Permissions = Permissions;
            _Mode = EN_Mode.update;

        }

        void _ResetPage()
        {

            txt_keypassword.Text = string.Empty;

        }

        void _AddNewMode()
        {

            lbl_title.Text = "أنشئ كلمة مرور للمفتاح";

            do
            {

                lbl_key.Text = cls_util.GetRandomKey(4, 4, cls_util.EN_KeyType.CapitalLetters);

            } while (cls_Key.IsExist(lbl_key.Text.Trim()));

        }

        void _UpdateMode()
        {

            lbl_title.Text = "تأكيد كلمة المرور";
            lbl_key.Text = _Key.Trim();

        }

        void _SetPage()
        {

            _ResetPage();

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

        private void frm_ConfirmKeyPassword_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void txt_keypassword_IconLeftClick(object sender, EventArgs e)
        {

            if (txt_keypassword.UseSystemPasswordChar)
            {
                txt_keypassword.PasswordChar = '\0';
                txt_keypassword.UseSystemPasswordChar = false;
                txt_keypassword.IconLeft = Resources.hide_password;
            }
            else
            {
                txt_keypassword.PasswordChar = '●';
                txt_keypassword.UseSystemPasswordChar = true;
                txt_keypassword.IconLeft = Resources.show_password;
            }

        }

        private bool _CheckPassword()
        {

            switch (_Mode)
            {

                case EN_Mode.addnew:

                    if (string.IsNullOrEmpty(txt_keypassword.Text))
                    {

                        txt_keypassword.BorderColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderForeColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderText = "لا يمكن ان يكون كلمة المرور فارغة";
                        txt_keypassword.Text = string.Empty;
                        return false;

                    }

                    return true;

                case EN_Mode.update:

                    if (string.IsNullOrEmpty(txt_keypassword.Text))
                    {

                        txt_keypassword.BorderColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderForeColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderText = "لا يمكن ان يكون كلمة المرور فارغة";
                        txt_keypassword.Text = string.Empty;
                        return false;

                    }

                    else if (txt_keypassword.Text.Trim() != _CurrentKey.KeyPassword)
                    {

                        txt_keypassword.BorderColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderForeColor = Color.FromArgb(164, 14, 38);
                        txt_keypassword.PlaceholderText = "كلمة المرور خاطئة";
                        txt_keypassword.Text = string.Empty;
                        return false;

                    }

                    return true;

            }

            return false;

        }

        private void btn_complete_Click(object sender, EventArgs e)
        {

            cls_Key Key;

            switch (_Mode)
            {

                case EN_Mode.addnew:

                    Key = new cls_Key();

                    Key.Key = lbl_key.Text.Trim();
                    Key.KeyPower = _Permissions;
                    Key.CreatedKeyDate = DateTime.Now;
                    Key.ByUser = cls_ManagementAppUser.Find(1);

                    if (_CheckPassword())
                        Key.KeyPassword = txt_keypassword.Text.Trim();
                    else
                        return;

                    if (Key.Save())
                    {

                        if (OnKeyCompletedSuccessfully != null)
                            OnKeyCompletedSuccessfully(this, Key);

                        this.Close();

                    }

                    else
                        MessageBox.Show("حدث خطأ اثناء انشاء مفتاح جديد", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                case EN_Mode.update:

                    Key = new cls_Key(_Key, _Permissions);

                    if (_CheckPassword())
                        Key.KeyPassword = txt_keypassword.Text.Trim();
                    else
                        return;

                    if (Key.Save())
                    {

                        if (OnKeyCompletedSuccessfully != null)
                            OnKeyCompletedSuccessfully(this, Key);

                        this.Close();

                    }
                    else
                        MessageBox.Show("حدث خطأ اثناء تعديل صلاحيات المفتاح", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

            }

        }

    }
}
