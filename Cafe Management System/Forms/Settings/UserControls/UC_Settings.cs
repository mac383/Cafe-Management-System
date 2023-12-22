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
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {

            foreach (Control c in flp_container.Controls)
            {
                c.Width = flp_container.Width - (int)(flp_container.Width * 0.1);
                c.Margin = new Padding((flp_container.Width - c.Width) / 2, 3, (flp_container.Width - c.Width) / 2, 3);
            }

        }

        private void UC_Settings_SizeChanged(object sender, EventArgs e)
        {

            foreach (Control c in flp_container.Controls)
            {
                c.Width = flp_container.Width - (int)(flp_container.Width * 0.1);
                c.Margin = new Padding((flp_container.Width - c.Width) / 2, 3, (flp_container.Width - c.Width) / 2, 3);
            }

        }
    }
}
