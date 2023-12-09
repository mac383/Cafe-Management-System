using CAFE_MANAGEMENT_BUSINESS.CLASSES;
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
using System.IO;
using Cafe_Management_System.GLOBAL_CLASSES;

namespace Cafe_Management_System.Forms.Services.frms
{
    public partial class frm_AddUpdateServiceDepartment : Form
    {

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler DataBack;

        string _SelectedImagePath;

        enum EN_Mode { AddNew = 0, Update = 1 }
        EN_Mode _Mode;

        cls_ServicesDepartments Department;

        public frm_AddUpdateServiceDepartment()
        {
            InitializeComponent();
            Department = new cls_ServicesDepartments();
            _Mode = EN_Mode.AddNew;
        }

        public frm_AddUpdateServiceDepartment(int DepartmentID, string DepartmentName, string DepartmentImage)
        {
            InitializeComponent();
            Department = new cls_ServicesDepartments(DepartmentID, DepartmentName, DepartmentImage);
            _Mode = EN_Mode.Update;
        }

        bool _HandleDepartmentImage()
        {

            if (Department.DepartmentImage != _SelectedImagePath)
            {

                if (!string.IsNullOrEmpty(Department.DepartmentImage))
                {

                    try
                    {
                        File.Delete(Department.DepartmentImage);
                    }

                    catch { return false; }

                }

                if (!string.IsNullOrEmpty(_SelectedImagePath))
                {

                    if (cls_util.CopyImageToProjectImagesFolder(ref _SelectedImagePath, cls_util.EN_Directory.DepartmentsImages))
                    {
                        Department.DepartmentImage = _SelectedImagePath;
                        return true;
                    }

                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Department.DepartmentImage = null;
                        return false;
                    }
                }
                else
                    Department.DepartmentImage = null;

            }

            return true;
        }

        void _SetAddNewMode()
        {

            lbl_pagetitle.Text = "إضافة قسم جديد";
            btn_addupdate.Text = "إضافة";
            txt_departmentname.Text = string.Empty;
            lbl_selectimage.Visible = true;
            lbl_deleteimage.Visible = false;
            pic_departmentimage.Visible = false;
            pic_departmentimage.Image = Resources.empty_image;

        }

        void _SetUpdateMode()
        {

            lbl_pagetitle.Text = "تعديل البيانات";
            btn_addupdate.Text = "حفظ";
            txt_departmentname.Text = Department.DepartmentName;

            if (!string.IsNullOrEmpty(Department.DepartmentImage))
            {

                try
                {
                    pic_departmentimage.ImageLocation = Department.DepartmentImage;
                }

                catch { }
            }

            else
                pic_departmentimage.Image = Resources.empty_image;

            lbl_selectimage.Visible = false;
            lbl_deleteimage.Visible = true;
            pic_departmentimage.Visible = true;


        }

        void _SetPage()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    _SetAddNewMode();
                    break;

                case EN_Mode.Update:
                    _SetUpdateMode();
                    break;

            }

        }

        private void frm_AddUpdateServiceDepartment_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void btn_addupdate_Click(object sender, EventArgs e)
        {

            if (!_HandleDepartmentImage())
                return;

            if (string.IsNullOrEmpty(txt_departmentname.Text))
            {
                MessageBox.Show("الرجاء إدخال أسم القسم", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_departmentname.Focus();
                return;
            }

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (cls_ServicesDepartments.IsExist(txt_departmentname.Text.Trim()))
                    {
                        MessageBox.Show("أسم القسم موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_departmentname.Focus();
                        return;
                    }
                    break;

                case EN_Mode.Update:
                    if (cls_ServicesDepartments.IsExist(Department.DepartmentID, txt_departmentname.Text.Trim()))
                    {
                        MessageBox.Show("أسم القسم موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_departmentname.Focus();
                        return;
                    }
                    break;

            }

            Department.DepartmentName = txt_departmentname.Text.Trim();

            if (Department.Save())
            {

                MessageBox.Show("تم حفظ المعلومات بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                DataBack?.Invoke();
                this.Close();

            }
            else
            {

                MessageBox.Show("حدث خطأ اثناء حفظ المعلومات, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_departmentname.Focus();

            }

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_selectimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Title = "أختر صورة";
            openFileDialog1.InitialDirectory = @"C:\Users\2021\OneDrive\سطح المكتب";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Image Files |*.jpg;*.pnl;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                _SelectedImagePath = openFileDialog1.FileName;
                lbl_selectimage.Visible = false;
                pic_departmentimage.Visible = true;
                lbl_deleteimage.Visible = true;

                pic_departmentimage.ImageLocation = _SelectedImagePath;

            }

        }

        private void lbl_deleteimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            pic_departmentimage.Image = Resources.empty_image;
            pic_departmentimage.Visible = false;
            lbl_deleteimage.Visible = false;
            _SelectedImagePath = string.Empty;
            lbl_selectimage.Visible = true;

        }

    }
}
