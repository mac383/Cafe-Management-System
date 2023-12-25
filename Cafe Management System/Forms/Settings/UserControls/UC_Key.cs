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

            //lbl_key.Text = cls_util.GetRandomKey(3, 6, cls_util.EN_KeyType.CapitalLetters) + "-383-mac383";

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

        private void btn_deletekey_Click(object sender, EventArgs e)
        {

            frm_DeleteKey frm = new frm_DeleteKey();
            frm.Show();

        }
    }
}
