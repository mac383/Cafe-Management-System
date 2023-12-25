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
    public partial class UC_SettingsContain : UserControl
    {


        public event Action<int> OnUpdate;
        protected virtual void HandleOnUpdateEvent(int userID)
        {

            if (OnUpdate != null)
                OnUpdate(userID);

        }

        public UC_SettingsContain()
        {
            InitializeComponent();
        }

        private void UC_SettingsContain_Load(object sender, EventArgs e)
        {
            foreach (Control c in flp_container.Controls)
            {
                c.Width = flp_container.Width - (int)(flp_container.Width * 0.1);
                c.Margin = new Padding((flp_container.Width - (c.Width + 20)) / 2, 15, 0, 3);
            }
        }

        private void UC_SettingsContain_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control c in flp_container.Controls)
            {
                c.Width = flp_container.Width - (int)(flp_container.Width * 0.1);
                c.Margin = new Padding((flp_container.Width - (c.Width + 20)) / 2, 15, 0, 3);
            }
        }

        private void uC_CurrentUserProfile1_OnUpdate(int obj)
        {
            HandleOnUpdateEvent(obj);
        }
    }
}
