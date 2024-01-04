using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Guna.UI2.WinForms;
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
    public partial class UC_KeysPart : UserControl
    {

        DataTable _Keys;

        public UC_KeysPart()
        {
            InitializeComponent();
        }

        private void UC_KeysPart_Load(object sender, EventArgs e)
        {

            _SetKeys();

        }

        private void _SetKeys()
        {

            gb_container.Controls.Clear();
            gb_container.Controls.Add(btn_update);

            _Keys = cls_Key.GetKeys();

            if (_Keys.Rows.Count == 0)
            {
                _ResetPage();
                return;
            }

            this.Height = gb_container.CustomBorderThickness.Top;

            int KeyLocation_Y = gb_container.CustomBorderThickness.Top;

            for (int i = 0; i < _Keys.Rows.Count; i++)
            {

                UC_Key key = new UC_Key(Convert.ToInt32(_Keys.Rows[i]["KeyID"]), !(i == _Keys.Rows.Count - 1));
                key.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
                key.Margin = new Padding(3);
                key.Width = this.Width - 40;
                key.Location = new Point((gb_container.Width - key.Width) / 2, KeyLocation_Y);
                
                key.HandleOnDataBack += _SetKeys;

                this.Height += key.Height + (key.Margin.Top + key.Margin.Bottom);

                gb_container.Controls.Add(key);
                KeyLocation_Y += key.Height + (key.Margin.Top + key.Margin.Bottom);

            }

        }

        private void _ResetPage()
        {
            
            gb_container.Controls.Clear();
            gb_container.Controls.Add(btn_update);

            this.Size = new Size(this.Size.Width, gb_container.CustomBorderThickness.Top + 100);

            Label lbl = new Label();
            lbl.Text = "لا توجد اي مفاتيح";
            lbl.AutoSize = false;
            lbl.Size = new Size(150, 30);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Location = new Point((this.Width - lbl.Width) / 2, this.Height - 50);
            lbl.Anchor = AnchorStyles.Top;
            gb_container.Controls.Add(lbl);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }
    }
}
