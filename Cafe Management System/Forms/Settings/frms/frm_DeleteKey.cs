using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Settings.frms
{
    public partial class frm_DeleteKey : Form
    {

        public delegate void OnDataBack();
        public event OnDataBack HandleOnDataBack;

        cls_Key _Key;
        public frm_DeleteKey(int keyID)
        {
            InitializeComponent();
            _Key = cls_Key.Find(keyID);
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

        private void frm_DeleteKey_Load(object sender, EventArgs e)
        {

            if (_Key == null)
                return;

            lbl_title.Text = string.Format("{0} {1}", "حذف المفتاح - ", _Key.Key.Trim());
            lbl_key.Text = _Key.Key.Trim();
            lbl_username.Text = _Key.ByUser.UserName;
            lbl_createdkeydate.Text = _Key.CreatedKeyDate.ToShortDateString().Trim();

        }

        private void btn_deletekey_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_keypassword.Text) || _Key == null)
                return;

            if (txt_keypassword.Text.Trim() != _Key.KeyPassword)
            {

                txt_keypassword.BorderColor = Color.FromArgb(164, 14, 38);
                txt_keypassword.PlaceholderForeColor = Color.FromArgb(164, 14, 38);
                txt_keypassword.PlaceholderText = "كلمة السر خاطئة";
                txt_keypassword.Text = string.Empty;
                return;

            }

            if (cls_Key.Delete(_Key.KeyID))
            {

                MessageBox.Show("تم حذف المفتاح بنجاح");
                
                if (HandleOnDataBack != null)
                    HandleOnDataBack();
                
                this.Close();

            }
            else
                MessageBox.Show("حصل خطأ اثناء حذف المفتاح");

        }
    }
}
