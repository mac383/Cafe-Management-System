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
    public partial class frm_AddUpdateService : Form
    {

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler DataBack;

        enum EN_Mode { AddNew = 1, Update = 2}
        EN_Mode _Mode;

        cls_Services _Service;
        string _SelectedImagePath;

        public frm_AddUpdateService()
        {
            InitializeComponent();
            _Service = new cls_Services();
            _Mode = EN_Mode.AddNew;
        }

        public frm_AddUpdateService(int ServiceID, string ServiceName, string ServiceDescription,
            string ServiceImage, string DepartmentName)
        {
            
            InitializeComponent();

            _Service = new cls_Services(ServiceID, ServiceName, ServiceDescription,
                ServiceImage);
            _Service.Department = cls_ServicesDepartments.FindByService(_Service.ServiceID);

            _Mode = EN_Mode.Update;

        }

        bool _HandleServiceImage()
        {

            if (_Service.ServiceImage != _SelectedImagePath)
            {

                if (!string.IsNullOrEmpty(_Service.ServiceImage))
                {

                    try
                    {
                        File.Delete(_Service.ServiceImage);
                    }

                    catch { return false; }

                }

                if (!string.IsNullOrEmpty(_SelectedImagePath))
                {

                    try
                    {

                        if (cls_util.CopyImageToProjectImagesFolder(ref _SelectedImagePath, cls_util.EN_Directory.ServicesImages))
                        {
                            _Service.ServiceImage = _SelectedImagePath;
                            return true;
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _Service.ServiceImage = null;
                        return false;
                    }
                }
                _Service.ServiceImage = null;

            }

            return true;

        }

        void _SetAddNewMode()
        {

            lbl_pagetitle.Text = "إضافة خدمة جديدة";
            txt_servicename.Text = string.Empty;
            txt_servicedescription.Text = string.Empty;

            if (cb_departments.Items.Count > 0)
                cb_departments.SelectedIndex = 0;

            lbl_selectimage.Visible = true;
            lbl_deleteimage.Visible = false;
            pic_serviceimage.Image = Resources.empty_image;
            pic_serviceimage.Visible = false;

            btn_addupdate.Text = "إضافة";

        }

        void _SetUpdateMode()
        {

            lbl_pagetitle.Text = "تعديل بيانات خدمة";
            txt_servicename.Text = _Service.ServiceName;
            txt_servicedescription.Text = _Service.ServiceDescription;

            if (cb_departments.Items.Count > 0)
                cb_departments.SelectedIndex = cb_departments.FindString(_Service.Department.DepartmentName);

            lbl_selectimage.Visible = false;
            lbl_deleteimage.Visible = true;

            if (string.IsNullOrEmpty(_Service.ServiceImage))
                pic_serviceimage.Image = Resources.empty_image;

            else
                pic_serviceimage.ImageLocation = _Service.ServiceImage;

            pic_serviceimage.Visible = true;

            btn_addupdate.Text = "تعديل";

        }

        void _LoadDepartments()
        {
            
            cb_departments.Items.Clear();
            DataTable _Departments = cls_ServicesDepartments.GetDepartments();

            foreach (DataRow row in _Departments.Rows)
                cb_departments.Items.Add(row["DepartmentName"]);

        }

        void _SetPage()
        {

            _LoadDepartments();

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

        private void frm_AddUpdateService_Load(object sender, EventArgs e)
        {

            _SetPage();

        }
        
        private void btn_addupdate_Click(object sender, EventArgs e)
        {

            if (!_HandleServiceImage())
                return;

            if (string.IsNullOrEmpty(txt_servicename.Text))
            {

                MessageBox.Show("الرجاء إدخال أسم الخدمة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_servicename.Focus();
                return;

            }

            switch (_Mode)
            {

                case EN_Mode.AddNew:

                    if (cls_Services.IsExist(txt_servicename.Text.Trim()))
                    {
                        MessageBox.Show("أسم الخدمة موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_servicename.Focus();
                        return;
                    }
                    break;

                case EN_Mode.Update:
                    if (cls_Services.IsExist(_Service.ServiceID, txt_servicename.Text.Trim()))
                    {
                        MessageBox.Show("أسم الخدمة موجود بالفعل, يرجئ إدخال أسم مختلف", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        txt_servicename.Focus();
                        return;
                    }
                    break;

            }

            if (cb_departments.SelectedIndex < 0)
            {

                MessageBox.Show("يرجئ اختيار قسم للخدمة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;

            }

            _Service.ServiceName = txt_servicename.Text.Trim();
            _Service.ServiceDescription = txt_servicedescription.Text.Trim();
            _Service.Department = cls_ServicesDepartments.Find(cb_departments.SelectedItem.ToString());

            if (_Service.Save())
            {

                MessageBox.Show("تم حفظ المعلومات بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                DataBack?.Invoke();
                this.Close();

            }
            else
            {

                MessageBox.Show("حدث خطأ اثناء حفظ المعلومات, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                txt_servicename.Focus();

            }

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
                pic_serviceimage.Visible = true;
                lbl_deleteimage.Visible = true;

                pic_serviceimage.ImageLocation = _SelectedImagePath;

            }

        }

        private void lbl_deleteimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pic_serviceimage.Image = Resources.empty_image;
            pic_serviceimage.Visible = false;
            lbl_deleteimage.Visible = false;
            _SelectedImagePath = string.Empty;
            lbl_selectimage.Visible = true;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
