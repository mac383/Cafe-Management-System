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
using System.IO;

namespace Cafe_Management_System.Forms.Users.UserControls
{

    public partial class UC_UsersList : UserControl
    {

        public event EventHandler<cls_ShowUserEventArgs> OnShowUserClick;

        public event EventHandler<cls_ShowUserEventArgs.EN_UserDepartment> OnAddNewManagementUserClick;

        public event EventHandler<cls_ShowUserEventArgs.EN_UserDepartment> OnAddNewServicesUserClick;

        public event EventHandler<cls_ShowUserEventArgs> OnUpdateManagementUserClick;

        public event EventHandler<cls_ShowUserEventArgs> OnUpdateServicesUserClick;

        protected virtual void HandleShowUserClicked(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnShowUserClick != null)
                OnShowUserClick(this, new cls_ShowUserEventArgs(userID, userDepartment));

        }

        protected virtual void HandleAddNewManagementUserEvent(cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnAddNewManagementUserClick != null)
                OnAddNewManagementUserClick(this, userDepartment);

        }

        protected virtual void HandleAddNewServicesUserEvent(cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            if (OnAddNewServicesUserClick != null)
                OnAddNewServicesUserClick(this, userDepartment);
        }

        protected virtual void HandleUpdateManagementUserEvent(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnUpdateManagementUserClick != null)
                OnUpdateManagementUserClick(this, new cls_ShowUserEventArgs(userID, userDepartment));

        }

        protected virtual void HandleUpdateServicesUserEvent(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            if (OnUpdateServicesUserClick != null)
                OnUpdateServicesUserClick(this, new cls_ShowUserEventArgs(userID, userDepartment));
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
                    _dv.RowFilter = string.Format("FirstName + ' ' + SecondName LIKE '{0}%' OR UserName = '{0}'", txt_search.Text.Trim());
                    break;

                case "مستخدمين برنامج الخدمات":
                    _dv.RowFilter = string.Format("(FirstName + ' ' + SecondName LIKE '{0}%' OR UserName = '{0}') AND Department = 'الخدمات'", txt_search.Text.Trim());
                    break;

                case "مستخدمين برنامج الأدارة":
                    _dv.RowFilter = string.Format("(FirstName + ' ' + SecondName LIKE '{0}%' OR UserName = '{0}') AND Department = 'الإدارة'", txt_search.Text.Trim());
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
            HandleAddNewManagementUserEvent(cls_ShowUserEventArgs.EN_UserDepartment.Management);
        }

        private void cmb_addtoservices_Click(object sender, EventArgs e)
        {
            HandleAddNewServicesUserEvent(cls_ShowUserEventArgs.EN_UserDepartment.Services);
        }

        private void cmb_update_Click(object sender, EventArgs e)
        {

            if (dgv_users.SelectedRows.Count <= 0) return;

            int userID = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["col_userid"].Value);

            cls_ShowUserEventArgs.EN_UserDepartment userDepartment =
                (dgv_users.SelectedRows[0].Cells["col_department"].Value.ToString().Trim() == "الإدارة") ?
                cls_ShowUserEventArgs.EN_UserDepartment.Management :
                cls_ShowUserEventArgs.EN_UserDepartment.Services;

            switch (userDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:
                    HandleUpdateManagementUserEvent(userID, userDepartment);
                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:
                    HandleUpdateServicesUserEvent(userID, userDepartment);
                    break;

            }

        }

        private void cmb_delete_Click(object sender, EventArgs e)
        {

            if (dgv_users.SelectedRows.Count <= 0)
                return;

            int userid = Convert.ToInt32(dgv_users.SelectedRows[0].Cells["col_userid"].Value);
            string username = dgv_users.SelectedRows[0].Cells["col_username"].Value.ToString().Trim();
            string userimage;

            switch (dgv_users.SelectedRows[0].Cells["col_department"].Value)
            {

                case "الإدارة":

                    if (MessageBox.Show("هل متأكد من حذف المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        if (cls_ManagementAppUser.IsUserExist(username))
                        {

                            userimage = cls_ManagementAppUser.Find(userid).PersonImage;

                            if (cls_ManagementAppUser.DeleteUser(userid))
                            {

                                if (File.Exists(userimage))
                                {
                                    try
                                    {
                                        File.Delete(userimage);
                                    }
                                    catch
                                    {
                                        MessageBox.Show($"تبقئ للمستخدم صورة يمكنك حذفها\nالصورة في المسار\n{userimage}.");
                                    }
                                }

                                MessageBox.Show("تم الحذف بنجاح", "اكتمل الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                _Refresh();
                            }
                            else
                                MessageBox.Show("حذث خطأ اثناء الحذف, قد يكون للمستخدم بيانات اخرئ مرتبطة بحسابه في النظام\nتأكد من حذفها تم حاول مجدداً.", "لم يتم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم ايجاد المستخدم", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    break;
            
                case "الخدمات":

                    if (MessageBox.Show("هل متأكد من حذف المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        if (cls_ServicesAppUser.IsUserExist(username))
                        {

                            userimage = cls_ServicesAppUser.Find(userid).PersonImage;

                            if (cls_ServicesAppUser.DeleteUser(userid))
                            {

                                if (File.Exists(userimage))
                                {
                                    try
                                    {
                                        File.Delete(userimage);
                                    }
                                    catch
                                    {
                                        MessageBox.Show($"تبقئ للمستخدم صورة يمكنك حذفها\nالصورة في المسار\n{userimage}.");
                                    }
                                }

                                MessageBox.Show("تم الحذف بنجاح", "اكتمل الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                _Refresh();

                            }
                            else
                                MessageBox.Show("حذث خطأ اثناء الحذف, قد يكون للمستخدم بيانات اخرئ مرتبطة بحسابه في النظام\nتأكد من حذفها تم حاول مجدداً.", "لم يتم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                        }

                        else
                        {
                            MessageBox.Show("لم يتم ايجاد المستخدم", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                        break;

            }

        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgv_users.SelectedCells.Count <= 0)
                return;

            if (dgv_users.SelectedRows[0].Cells["col_username"].ColumnIndex != e.ColumnIndex)
                return;

            Clipboard.SetText(dgv_users.SelectedRows[0].Cells["col_username"].Value.ToString());

        }

    }
}
