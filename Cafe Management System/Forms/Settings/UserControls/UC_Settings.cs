using Cafe_Management_System.Forms.Users.UserControls;
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

        private void _LoadSettingsContain()
        {

            this.Controls.Clear();

            UC_SettingsContain uc = new UC_SettingsContain();
            uc.Dock = DockStyle.Fill;
            uc.OnUpdate += _LoadUpdateUser;
            this.Controls.Add(uc);

        }

        private void _LoadUpdateUser(int userID)
        {

            this.Controls.Clear();

            UC_AddUpdateManagementUsers uc = new UC_AddUpdateManagementUsers(userID);
            uc.Dock = DockStyle.Fill;
            uc.OnBackClick += _LoadSettingsContain;
            this.Controls.Add(uc);

        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            _LoadSettingsContain();
        }
    }
}
