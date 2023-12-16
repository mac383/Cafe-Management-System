using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Users.UsersEventsArgsClasses;
using Cafe_Management_System.Properties;
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

        public event EventHandler<cls_ShowUserEventArgs> OnUpdateClicked;

        protected virtual void HandleUpdateClicked(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {

            if (OnUpdateClicked != null)
                OnUpdateClicked(this, new cls_ShowUserEventArgs(userID, userDepartment));

        }

        public delegate void OnBackClickHandler();
        public event OnBackClickHandler OnBackClick;

        cls_ManagementAppUser _ManagementUser;
        cls_ServicesAppUser _ServicesUser;

        int _UserID;
        cls_ShowUserEventArgs.EN_UserDepartment _UserDepartment;

        public UC_ShowUserInfo(int userID, cls_ShowUserEventArgs.EN_UserDepartment userDepartment)
        {
            
            InitializeComponent();
            this._UserID = userID;
            this._UserDepartment = userDepartment;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.OnBackClick();
        }

        void _SetPageAsNull()
        {
            
            pic_userimage.Image = Resources.empty_image;
            lbl_userfullname.Text = "???? ???? ????";
            lbl_username.Text = "????";
            lbl_department.Text = "????";
            lbl_dob.Text = "????";
            lbl_idnumber.Text = "????";
            lbl_address.Text = "????";
            lbl_gender.Text = "????";
            lbl_phone1.Text = "????";
            lbl_phone2.Text = "????";

            lbl_showpermissions.Visible = false;

            btn_updateuser.Enabled = false;
            btn_deleteuser.Enabled = false;

        }

        void _SetPageAsManagement()
        {

            _ManagementUser = cls_ManagementAppUser.Find(_UserID);

            if (_ManagementUser == null)
            {
                _SetPageAsNull();
                return;
            }

            if (!string.IsNullOrEmpty(_ManagementUser.PersonImage))
                pic_userimage.ImageLocation = _ManagementUser.PersonImage;

            lbl_userfullname.Text = _ManagementUser.FirstName + " " + _ManagementUser.SecondName + " " + _ManagementUser.LastName;
            lbl_username.Text = _ManagementUser.UserName;
            lbl_department.Text = "الإدارة";
            lbl_dob.Text = _ManagementUser.DOB.ToShortDateString();
            lbl_idnumber.Text = (string.IsNullOrEmpty(_ManagementUser.IDNumber)) ? "لا يوجد" : _ManagementUser.IDNumber;
            lbl_address.Text = _ManagementUser.Address;
            lbl_gender.Text = (_ManagementUser.Gender == cls_Person.EN_Gender.male) ? "ذكر" : "انثئ";
            lbl_phone1.Text = _ManagementUser.Phone1;
            lbl_phone2.Text = (string.IsNullOrEmpty(_ManagementUser.Phone2)) ? "لا يوجد" : _ManagementUser.Phone2;

            lbl_showpermissions.Visible = true;

            btn_updateuser.Enabled = true;
            btn_deleteuser.Enabled = true;

        }

        void _SetPageAsServices()
        {

            _ServicesUser = cls_ServicesAppUser.Find(_UserID);

            if (_ServicesUser == null)
            {
                _SetPageAsNull();
                return;
            }

            if (!string.IsNullOrEmpty(_ServicesUser.PersonImage))
                pic_userimage.ImageLocation = _ServicesUser.PersonImage;

            lbl_userfullname.Text = _ServicesUser.FirstName + " " + _ServicesUser.SecondName + " " + _ServicesUser.LastName;
            lbl_username.Text = _ServicesUser.UserName;
            lbl_department.Text = "الخدمات";
            lbl_dob.Text = _ServicesUser.DOB.ToShortDateString();
            lbl_idnumber.Text = (string.IsNullOrEmpty(_ServicesUser.IDNumber)) ? "لا يوجد" : _ServicesUser.IDNumber;
            lbl_address.Text = _ServicesUser.Address;
            lbl_gender.Text = (_ServicesUser.Gender == cls_Person.EN_Gender.male) ? "ذكر" : "انثئ";
            lbl_phone1.Text = _ServicesUser.Phone1;
            lbl_phone2.Text = (string.IsNullOrEmpty(_ServicesUser.Phone2)) ? "لا يوجد" : _ServicesUser.Phone2;

            lbl_showpermissions.Visible = false;

            btn_updateuser.Enabled = true;
            btn_deleteuser.Enabled = true;

        }

        void _SetPage()
        {

            _SetPageAsNull();

            switch (_UserDepartment)
            {

                case cls_ShowUserEventArgs.EN_UserDepartment.Management:
                    _SetPageAsManagement();

                    break;

                case cls_ShowUserEventArgs.EN_UserDepartment.Services:
                    _SetPageAsServices();

                    break;
            }

        }

        private void UC_ShowUserInfo_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل متأكد من حذف المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {

                switch (_UserDepartment)
                {

                    case cls_ShowUserEventArgs.EN_UserDepartment.Management:

                        if (cls_ManagementAppUser.IsUserExist(_ManagementUser.UserName))
                        {

                            if (cls_ManagementAppUser.DeleteUser(_UserID))
                            {
                                MessageBox.Show("تم الحذف بنجاح", "اكتمل الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                OnBackClick();
                            }
                            else
                                MessageBox.Show("حذث خطأ اثناء الحذف, قد يكون للمستخدم بيانات اخرئ مرتبطة بحسابه في النظام\nتأكد من حذفها تم حاول مجدداً.", "لم يتم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم ايجاد المستخدم", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }

                        break;

                    case cls_ShowUserEventArgs.EN_UserDepartment.Services:

                        if (cls_ServicesAppUser.IsUserExist(_ServicesUser.UserName))
                        {

                            if (cls_ServicesAppUser.DeleteUser(_UserID))
                            {
                                MessageBox.Show("تم الحذف بنجاح", "اكتمل الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                                OnBackClick();
                            }
                            else
                                MessageBox.Show("حذث خطأ اثناء الحذف, قد يكون للمستخدم بيانات اخرئ مرتبطة بحسابه في النظام\nتأكد من حذفها تم حاول مجدداً.", "لم يتم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            MessageBox.Show("لم يتم ايجاد المستخدم", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        }

                        break;
                }

            }

        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            HandleUpdateClicked(_UserID, _UserDepartment);
        }

    }
}
