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
    public partial class UC_AddUpdateUsers : UserControl
    {

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick; 

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        int _UserID;
        cls_ShowUserEventArgs.EN_UserDepartment _UserDepartment;

        public UC_AddUpdateUsers(cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            InitializeComponent();

            this._UserDepartment = userDepartment;
            this._Mode = EN_Mode.addnew;

        }

        public UC_AddUpdateUsers(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            InitializeComponent();

            this._UserID = userID;
            this._UserDepartment = userDepartment;
            this._Mode = EN_Mode.update;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.OnBackClick();
        }
    }
}
