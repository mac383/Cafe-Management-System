using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Services.frms;
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
using Cafe_Management_System.Forms.Tables.UserControls;

namespace Cafe_Management_System.Forms.Services.UserControls
{
    public partial class UC_ServicesDepartment : UserControl
    {

        DataTable _Departments;

        public UC_ServicesDepartment()
        {
            InitializeComponent();
            _Departments = cls_ServicesDepartments.GetDepartments();
        }

        private void UC_ServicesDepartment_Load(object sender, EventArgs e)
        {

            _LoadDepartments(_Departments.DefaultView);

        }

        void _LoadDepartments(DataView dv)
        {

            dgv_servicesdepartments.Rows.Clear();

            for (int i = 0; i < dv.Count; i++)
            {

                dgv_servicesdepartments.Rows.Add((i + 1).ToString(), dv[i]["DepartmentName"],
                    dv[i]["COUNTOFSERVICES"], dv[i]["DepartmentID"], dv[i]["DepartmentImage"]);

            }

        }

        void _Refresh()
        {
            _Departments = cls_ServicesDepartments.GetDepartments();
            _LoadDepartments(_Departments.DefaultView);
        }

        private void cmb_addnew_Click(object sender, EventArgs e)
        {

            frm_AddUpdateServiceDepartment frm = new frm_AddUpdateServiceDepartment();
            frm.DataBack += _Refresh;
            frm.ShowDialog();


        }

        private void cmb_update_Click(object sender, EventArgs e)
        {

            if (dgv_servicesdepartments.SelectedRows.Count <= 0)
                return;

            frm_AddUpdateServiceDepartment frm = new frm_AddUpdateServiceDepartment(Convert.ToInt32(dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentID"].Value),
                dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentName"].Value.ToString(), 
                Convert.ToString(dgv_servicesdepartments.SelectedRows[0].Cells["col_departmentimage"].Value));

            frm.DataBack += _Refresh;
            frm.ShowDialog();

        }

        private void cmb_delete_Click(object sender, EventArgs e)
        {

            if (dgv_servicesdepartments.SelectedRows.Count <= 0)
                return;


            if (MessageBox.Show("أمتاكد من حذف هذا القسم؟", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {

                if (cls_ServicesDepartments.IsDepartmentReferences(Convert.ToInt32(dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentID"].Value)))
                {

                    MessageBox.Show("لا يمكن حذف هذا القسم لانه مرتبط ببيانات اخرئ في النظام.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;

                }

                if (cls_ServicesDepartments.Delete(dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentName"].Value.ToString()))
                {

                    MessageBox.Show("تم حذف القسم بنجاح.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                    if (File.Exists(dgv_servicesdepartments.SelectedRows[0].Cells["col_departmentimage"].Value.ToString()))
                        try
                        {
                            File.Delete(dgv_servicesdepartments.SelectedRows[0].Cells["col_departmentimage"].Value.ToString());
                        }
                        catch { }

                    _Refresh();

                }
                else
                    MessageBox.Show("حدث خطأ أثناء عملية الحذف, يرجئ المحاولة مجدداً.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


            }

        }

        private void dgv_servicesdepartments_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_servicesdepartments.SelectedRows.Count <= 0)
                return;

            frm_AddUpdateServiceDepartment frm = new frm_AddUpdateServiceDepartment(Convert.ToInt32(dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentID"].Value),
                dgv_servicesdepartments.SelectedRows[0].Cells["col_DepartmentName"].Value.ToString(), 
                Convert.ToString(dgv_servicesdepartments.SelectedRows[0].Cells["col_departmentimage"].Value));
            frm.DataBack += _Refresh;
            frm.ShowDialog();
        }

        private void cmb_refresh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void cmb_sortbydepartmentname_Click(object sender, EventArgs e)
        {

            if (dgv_servicesdepartments.Rows.Count <= 1)
                return;

            DataView _dv = _Departments.DefaultView;

            char _FirstDigitInFirstRow = dgv_servicesdepartments.Rows[0].Cells["col_DepartmentName"].Value.ToString().Trim()[0];
            char _FirstDigitInLastRow = dgv_servicesdepartments.Rows[dgv_servicesdepartments.Rows.Count - 1].Cells["col_DepartmentName"].Value.ToString().Trim()[0];

            _dv.Sort = (_FirstDigitInFirstRow < _FirstDigitInLastRow) ?
                    string.Format("DepartmentName DESC")
                :
                    string.Format("DepartmentName ASC");

            _LoadDepartments(_dv);

        }
    }
}
