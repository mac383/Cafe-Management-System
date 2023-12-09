using Cafe_Management_System.Forms.Services.frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Services.UserControls
{
    public partial class UC_ServicesSubButtons : UserControl
    {

        public event UserControlClickHandler SubButtonClick;
        public delegate void UserControlClickHandler(UserControl usercontrol);



        public UC_ServicesSubButtons()
        {
            InitializeComponent();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            UC_Services uc = new UC_Services();
            this.SubButtonClick(uc);
        }

        private void btn_servicesdepartment_Click(object sender, EventArgs e)
        {

            UC_ServicesDepartment uc = new UC_ServicesDepartment();
            this.SubButtonClick(uc);

        }

        private void UC_ServicesSubButtons_Load(object sender, EventArgs e)
        {
            btn_services.PerformClick();
        }
    }
}
