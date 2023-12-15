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
    public partial class UC_UsersMainPage : UserControl
    {

        public UC_UsersMainPage()
        {
            InitializeComponent();
        }

        private void UC_UsersMainPage_Load(object sender, EventArgs e)
        {
            _LoadUsersListPage();
        }

        void _LoadUsersListPage()
        {

            this.Controls.Clear();

            UC_UsersList uc = new UC_UsersList();

            uc.OnShowUserClicked += _LoadShowUserPage;
            uc.OnAddNewClicked += _LoadAddNewUserPage;
            uc.OnUpdateClicked += _LoadUpdateUserPage;

            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadAddNewUserPage(object sernder, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            this.Controls.Clear();

            UC_AddUpdateUsers uc = new UC_AddUpdateUsers(userDepartment);
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadUpdateUserPage(object sender, cls_ShowUserEventArgs eventArgs)
        {

            this.Controls.Clear();

            UC_AddUpdateUsers uc = new UC_AddUpdateUsers(eventArgs.UserID, eventArgs.UserDepartment);
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadShowUserPage(object sender, cls_ShowUserEventArgs eventArgs)
        {

            this.Controls.Clear();

            UC_ShowUserInfo uc = new UC_ShowUserInfo(eventArgs.UserID, eventArgs.UserDepartment);
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

    }
}
