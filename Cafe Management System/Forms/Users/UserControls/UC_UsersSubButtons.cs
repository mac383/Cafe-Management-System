using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Users.UserControls
{
    public partial class UC_UsersSubButtons : UserControl
    {

        public event UserControlClickHandler SubButtonClick;
        public delegate void UserControlClickHandler(UserControl usercontrol);

        public UC_UsersSubButtons()
        {
            InitializeComponent();
        }

        private void btn_managementappusers_Click(object sender, EventArgs e)
        {
            UC_ManagementAppUsers uc = new UC_ManagementAppUsers();
            this.SubButtonClick(uc);
        }

        private void btn_servicesappusers_Click(object sender, EventArgs e)
        {
            UC_ServicesAppUsers uc = new UC_ServicesAppUsers();
            this.SubButtonClick(uc);
        }
    }
}
