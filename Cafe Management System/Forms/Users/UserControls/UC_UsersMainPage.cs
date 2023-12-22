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

            uc.OnShowUserClick += _LoadShowUserPage;
            uc.OnAddNewManagementUserClick += _LoadAddNewManagementUserPage;
            uc.OnUpdateManagementUserClick += _LoadUpdateManagementUserPage;
            uc.OnAddNewServicesUserClick += _LoadAddNewServicesUserPage;
            uc.OnUpdateServicesUserClick += _LoadUpdateServicesUserPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadAddNewManagementUserPage(object sernder, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            this.Controls.Clear();

            UC_AddUpdateManagementUsers uc = new UC_AddUpdateManagementUsers();
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadUpdateManagementUserPage(object sender, cls_ShowUserEventArgs eventArgs)
        {

            this.Controls.Clear();

            switch (eventArgs.UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:

                    UC_AddUpdateManagementUsers uc = new UC_AddUpdateManagementUsers(eventArgs.UserID);
                    uc.OnBackClick += _LoadUsersListPage;
                    uc.Dock = DockStyle.Fill;
                    this.Controls.Add(uc);

                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:

                    UC_AddUpdateServicesUsers page = new UC_AddUpdateServicesUsers(eventArgs.UserID);
                    page.OnBackClick += _LoadUsersListPage;
                    page.Dock = DockStyle.Fill;
                    this.Controls.Add(page);

                    break;

            }

        }

        void _LoadAddNewServicesUserPage(object sender, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            this.Controls.Clear();

            UC_AddUpdateServicesUsers uc = new UC_AddUpdateServicesUsers();
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadUpdateServicesUserPage(object sender, cls_ShowUserEventArgs eventArgs)
        {
            
            this.Controls.Clear();

            UC_AddUpdateServicesUsers uc = new UC_AddUpdateServicesUsers(eventArgs.UserID);
            uc.OnBackClick += _LoadUsersListPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

        void _LoadShowUserPage(object sender, cls_ShowUserEventArgs eventArgs)
        {

            this.Controls.Clear();

            UC_ShowUserInfo uc = new UC_ShowUserInfo(eventArgs.UserID, eventArgs.UserDepartment);
            uc.OnBackClick += _LoadUsersListPage;
            uc.OnUpdateClicked += _LoadUpdateManagementUserPage;
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

        }

    }
}
