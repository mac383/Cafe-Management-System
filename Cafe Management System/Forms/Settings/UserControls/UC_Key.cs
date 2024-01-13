using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES;
using Cafe_Management_System.Forms.Settings.frms;
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
    public partial class UC_Key : UserControl
    {

        public delegate void OnDataBack();
        public event OnDataBack HandleOnDataBack;

        cls_Key _Key;

        public UC_Key(int keyID, bool ShowSeparaterLine = true)
        {
            
            InitializeComponent();
            _Key = cls_Key.Find(keyID);
            separaterline.Visible = ShowSeparaterLine;

        }

        private void _ResetKey()
        {

            lbl_key.Text = "????-????-????-????";
            lbl_username.Text = "????";
            lbl_createdkeydate.Text = "????/????/????";

        }

        private void UC_Key_Load(object sender, EventArgs e)
        {

            if (_Key != null)
            {

                lbl_key.Text = _Key.Key.Trim();
                lbl_username.Text = _Key.ByUser.UserName.Trim();
                lbl_createdkeydate.Text = _Key.CreatedKeyDate.ToString().Trim();

            }
            else
                _ResetKey();

        }

        private void btn_copykey_Click(object sender, EventArgs e)
        {

            if (_Key != null)
                Clipboard.SetText(lbl_key.Text.Trim());

        }

        private void DataBack()
        {
            HandleOnDataBack();
        }

        private void btn_deletekey_Click(object sender, EventArgs e)
        {

            frm_DeleteKey frm = new frm_DeleteKey(_Key.KeyID);
            frm.HandleOnDataBack += DataBack;
            frm.ShowDialog();

        }

        private void btn_showmore_Click(object sender, EventArgs e)
        {

            frm_KeyPermissions frm = new frm_KeyPermissions(_Key.Key, _Key.KeyPower, true);
            frm.ShowDialog();

        }

        private void btn_editkey_Click(object sender, EventArgs e)
        {

            frm_KeyPermissions frm = new frm_KeyPermissions(_Key.Key, _Key.KeyPower, false);
            frm.ShowDialog();
            HandleOnDataBack();

        }

        
    }
}
