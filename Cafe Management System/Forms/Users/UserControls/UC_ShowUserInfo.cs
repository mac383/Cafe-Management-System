using Cafe_Management_System.Forms.Users.UsersEventsArgsClasses;
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
    public partial class UC_ShowUserInfo : UserControl
    {

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick;

        int _UserID;
        cls_ShowUserEventArgs.EN_UserDepartment _UserDepartment;

        public UC_ShowUserInfo(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            InitializeComponent();
            this._UserID = userID;
            this._UserDepartment = userDepartment;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.OnBackClick();
        }
    }
}
