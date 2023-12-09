using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Tables.frms
{
    public partial class frm_AddUpdateTable : Form
    {

        public delegate void DataBackEventHandler();

        public event DataBackEventHandler DataBack;

        cls_Tables _Table = null;

        enum EN_Mode { AddNew = 1, Update = 2};
        EN_Mode _Mode;
        int _TableID;

        public frm_AddUpdateTable()
        {
            InitializeComponent();
            _Mode = EN_Mode.AddNew;
        }

        public frm_AddUpdateTable(int TableID)
        {
            InitializeComponent();
            _TableID = TableID;
            _Table = cls_Tables.Find(_TableID);
            _Mode = EN_Mode.Update;
        }

        void _AddNewMode()
        {

            lbl_pagename.Text = "إضافة طاولة";
            btn_addtable.Text = "إضافة";
            txt_newtablepassword.Visible = false;
        }

        void _UpdateMode()
        {
            lbl_pagename.Text = "تعديل معلومات طاولة";
            btn_addtable.Text = "تعديل";
            txt_newtablepassword.PlaceholderText = "كلمة السر الجديدة للطاولة";
            txt_newtablepassword.Visible = true;

            txt_tablename.Text = _Table.TableName.ToString();

        }

        void _SetPage()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    _AddNewMode();
                    break;

                case EN_Mode.Update:
                    _UpdateMode();
                    break;
            }

        }

        private void frm_AddUpdateTable_Load(object sender, EventArgs e)
        {
            _SetPage();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool _CheckValues()
        {

            if (string.IsNullOrEmpty(txt_tablename.Text))
                return false;

            if (string.IsNullOrEmpty(txt_tablepassword.Text))
                return false;

            return true;

        }

        void btn_addtable_AddNewMode()
        {

            if (!_CheckValues())
            {

                MessageBox.Show("يرجئ إدخال المعلومات الكاملة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;

            }

            if (cls_Tables.IsExist(txt_tablename.Text.Trim()))
            {
                MessageBox.Show("اسم الطاولة موجود مسبقاً, تأكد من إدخال اسم مختلف.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;
            }

            string tablename = txt_tablename.Text.Trim();
            string tablepassword = txt_tablepassword.Text.Trim();

            cls_Tables table = new cls_Tables();
            table.TableName = tablename;
            table.TablePassword = tablepassword;

            if (table.Save())
            {

                MessageBox.Show("تم إضافة الطاولة بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                txt_tablename.Text = string.Empty;
                txt_tablepassword.Text = string.Empty;
                txt_tablename.Focus();
                DataBack?.Invoke();

            }
            else
                MessageBox.Show("لم يتم الإضافة بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;

        }

        void btn_addtable_UpdateMode()
        {

            if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
            {
                MessageBox.Show("الطاولة محجوزة الان, لا يمكنك التعديل عليها.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;
            }

            if (!_CheckValues() || string.IsNullOrEmpty(txt_newtablepassword.Text))
            {

                MessageBox.Show("يرجئ إدخال المعلومات الكاملة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;

            }

            if (cls_Tables.IsTableExistsWithoutThisTable(_TableID, txt_tablename.Text.Trim()))
            {
                MessageBox.Show("اسم الطاولة موجود مسبقاً, تأكد من إدخال اسم مختلف.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;
            }

            string tablename = txt_tablename.Text.Trim();
            string newtablepassword = txt_newtablepassword.Text.Trim();
            string oldtablepassword = cls_Tables.Find(_TableID).TablePassword.ToString();            

            if (oldtablepassword != txt_tablepassword.Text.Trim().ToString())
            {
                MessageBox.Show("كلمة سر الطاولة غير صحيحة, يرجئ إدخال كلمة سر صحيحة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            cls_Tables table = new cls_Tables(_TableID, tablename, oldtablepassword, newtablepassword);
            
            if (table.Save())
            {

                MessageBox.Show("تم التعديل بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                txt_tablename.Text = string.Empty;
                txt_tablepassword.Text = string.Empty;
                txt_tablename.Focus();
                DataBack?.Invoke();
                this.Close();

            }
            else
                MessageBox.Show("خطأ اثناء التعديل.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;


        }

        private void btn_addtable_Click(object sender, EventArgs e)
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    btn_addtable_AddNewMode();
                    break;

                case EN_Mode.Update:
                    btn_addtable_UpdateMode();
                    break;

            }

        }


        void _ResetPasswordIcons(Guna2TextBox txt)
        {

            if (txt.PasswordChar == '●')
            {
                txt.PasswordChar = '\0';
                txt.IconLeft = Resources.hide_password;
            }

            else
            {
                txt.PasswordChar = '●';
                txt.IconLeft = Resources.show_password;
            }

        }

        private void txt_tablepassword_IconLeftClick(object sender, EventArgs e)
        {
            _ResetPasswordIcons((Guna2TextBox)sender);
        }
    }
}
