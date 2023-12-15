using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Requests.UserControls;
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

    public partial class UC_UsersList : UserControl
    {

        public event EventHandler<cls_ShowUserEventArgs> OnShowUserClicked;

        public event EventHandler<cls_ShowUserEventArgs.EN_UserDepartment> OnAddNewClicked;

        public event EventHandler<cls_ShowUserEventArgs> OnUpdateClicked;

        protected virtual void HandleShowUserClicked(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnShowUserClicked != null)
                OnShowUserClicked(this, new cls_ShowUserEventArgs(userID, userDepartment));

        }

        protected virtual void HandleAddNewClicked(cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnAddNewClicked != null)
                OnAddNewClicked(this, userDepartment);

        }

        protected virtual void HandleUpdateClicked(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnUpdateClicked != null)
                OnUpdateClicked(this, new cls_ShowUserEventArgs(userID, userDepartment));

        }

        DataTable _Users;

        public UC_UsersList()
        {

            InitializeComponent();

            DataTable _ManagementAppUsers = cls_ManagementAppUser.GetUsers().DefaultView.ToTable
                (false, "UserID", "FirstName", "SecondName", "LastName", "UserName", "Phone1", "Gender");

            _ManagementAppUsers.Columns.Add("Department");

            DataTable _ServicesAppUsers = cls_ServicesAppUser.GetUsers().DefaultView.ToTable
                (false, "UserID", "FirstName", "SecondName", "LastName", "UserName", "Phone1", "Gender");

            _ServicesAppUsers.Columns.Add("Department");

            foreach (DataRow row in _ManagementAppUsers.Rows)
                row["Department"] = "الإدارة";

            foreach (DataRow row in _ServicesAppUsers.Rows)
                row["Department"] = "الخدمات";

            _Users = _ManagementAppUsers;
            _Users.Merge(_ServicesAppUsers);

        }

        void _LoadUsers(DataView dv)
        {

            dgv_users.Rows.Clear();

            for (int i = 0; i < dv.Count; i++)
            {

                int userid = Convert.ToInt32(dv[i]["UserID"]);
                string fullname = dv[i]["FirstName"] + " " + dv[i]["SecondName"] + " " + dv[i]["LastName"];
                string username = dv[i]["UserName"].ToString();
                string phone = dv[i]["Phone1"].ToString();
                string gender = Convert.ToBoolean(dv[i]["Gender"]) ? "ذكر" : "انثئ";
                string userdepartment = dv[i]["Department"].ToString().Trim();

                dgv_users.Rows.Add((i + 1).ToString(), fullname, username, phone, gender, userid, userdepartment);

            }

        }

        void _Refresh()
        {

            txt_search.Text = string.Empty;

            if (cb_filter.Items.Count > 0)
                cb_filter.SelectedIndex = 0;

            DataTable _ManagementAppUsers = cls_ManagementAppUser.GetUsers().DefaultView.ToTable
                (false, "UserID", "FirstName", "SecondName", "LastName", "UserName", "Phone1", "Gender");

            _ManagementAppUsers.Columns.Add("Department");

            DataTable _ServicesAppUsers = cls_ServicesAppUser.GetUsers().DefaultView.ToTable
                (false, "UserID", "FirstName", "SecondName", "LastName", "UserName", "Phone1", "Gender");

            _ServicesAppUsers.Columns.Add("Department");

            foreach (DataRow row in _ManagementAppUsers.Rows)
                row["Department"] = "الإدارة";

            foreach (DataRow row in _ServicesAppUsers.Rows)
                row["Department"] = "الخدمات";

            _Users = _ManagementAppUsers;
            _Users.Merge(_ServicesAppUsers);

            _LoadUsers(_Users.DefaultView);
            
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {

            _LoadUsers(_Users.DefaultView);

        }

        private void cmb_refresh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void txt_searchan_TextChanged(object sender, EventArgs e)
        {

            DataView _dv = _Users.DefaultView;

            switch (cb_filter.SelectedItem.ToString())
            {

                case "الكل":
                    _dv.RowFilter = string.Format("FirstName + ' ' + SecondName + ' ' + LastName LIKE '{0}%' OR UserName = '{0}'", txt_search.Text.Trim());
                    break;

                case "مستخدمين برنامج الخدمات":
                    _dv.RowFilter = string.Format("(FirstName + ' ' + SecondName + ' ' + LastName LIKE '{0}%' OR UserName = '{0}') AND Department = 'الخدمات'", txt_search.Text.Trim());
                    break;

                case "مستخدمين برنامج الأدارة":
                    _dv.RowFilter = string.Format("(FirstName + ' ' + SecondName + ' ' + LastName LIKE '{0}%' OR UserName = '{0}') AND Department = 'الإدارة'", txt_search.Text.Trim());
                    break;

            }

            _LoadUsers(_dv);

        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dgv_users.Rows.Count < 0)
                return;

            txt_search.Text = string.Empty;

            DataView _dv = _Users.DefaultView;

            switch (cb_filter.SelectedItem.ToString())
            {

                case "الكل":
                    _dv.RowFilter = string.Format("");
                    break;

                case "مستخدمين برنامج الخدمات":
                    _dv.RowFilter = string.Format("Department = 'الخدمات'");
                    break;

                case "مستخدمين برنامج الأدارة":
                    _dv.RowFilter = string.Format("Department = 'الإدارة'");
                    break;

            }

            _LoadUsers(_dv);

        }

        private void cmb_userfullname_Click(object sender, EventArgs e)
        {

            if (dgv_users.Rows.Count <= 1)
                return;

            DataView _dv = _Users.DefaultView;

            char _FirstDigitInFirstRow = dgv_users.Rows[0].Cells["col_fullname"].Value.ToString()[0];
            char _FirstDigitInLastRow = dgv_users.Rows[dgv_users.Rows.Count - 1].Cells["col_fullname"].Value.ToString()[0];

            _dv.Sort = (_FirstDigitInFirstRow < _FirstDigitInLastRow) ?
                "FirstName ASC" : "FirstName DESC";

            _LoadUsers(_dv);

        }

        private void cmb_username_Click(object sender, EventArgs e)
        {

            if (dgv_users.Rows.Count <= 1)
                return;

            DataView _dv = _Users.DefaultView;

            char _FirstDigitInFirstRow = dgv_users.Rows[0].Cells["col_username"].Value.ToString()[0];
            char _FirstDigitInLastRow = dgv_users.Rows[dgv_users.Rows.Count - 1].Cells["col_username"].Value.ToString()[0];

            _dv.Sort = (_FirstDigitInFirstRow < _FirstDigitInLastRow) ?
                "UserName DESC" : "UserName ASC";

            _LoadUsers(_dv);

        }

        private void cmb_gender_Click(object sender, EventArgs e)
        {


            if (dgv_users.Rows.Count <= 1)
                return;

            DataView _dv = _Users.DefaultView;

            _dv.Sort = "Gender DESC";

            _LoadUsers(_dv);


        }

        private void cmb_show_Click(object sender, EventArgs e)
        {

            if (dgv_users.SelectedRows.Count <= 0) return;

            int userID = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["col_userid"].Value);

            cls_ShowUserEventArgs.EN_UserDepartment userDepartment =
                (dgv_users.SelectedRows[0].Cells["col_department"].Value.ToString().Trim() == "الإدارة") ?
                cls_ShowUserEventArgs.EN_UserDepartment.Management :
                cls_ShowUserEventArgs.EN_UserDepartment.Services;

            HandleShowUserClicked(userID, userDepartment);

        }

        private void cmb_addtomanagement_Click(object sender, EventArgs e)
        {
            HandleAddNewClicked(cls_ShowUserEventArgs.EN_UserDepartment.Management);
        }

        private void cmb_addtoservices_Click(object sender, EventArgs e)
        {
            HandleAddNewClicked(cls_ShowUserEventArgs.EN_UserDepartment.Services);
        }

        private void cmb_update_Click(object sender, EventArgs e)
        {

            if (dgv_users.SelectedRows.Count <= 0) return;

            int userID = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["col_userid"].Value);

            cls_ShowUserEventArgs.EN_UserDepartment userDepartment =
                (dgv_users.SelectedRows[0].Cells["col_department"].Value.ToString().Trim() == "الإدارة") ?
                cls_ShowUserEventArgs.EN_UserDepartment.Management :
                cls_ShowUserEventArgs.EN_UserDepartment.Services;

            HandleUpdateClicked(userID, userDepartment);

        }

    }
}
