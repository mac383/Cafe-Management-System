using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Tables.frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Tables.UserControls
{
    public partial class UC_Tables : UserControl
    {

        DataTable _Tables;

        public UC_Tables()
        {
            InitializeComponent();
            _Tables = cls_Tables.GetTables();
        }

        void _LoadTables(DataView dv)
        {

            flp_body.Controls.Clear();

            for (int i = 0; i < dv.Count; i++)
            {

                int _tableid = Convert.ToInt32(dv[i]["TableID"]);
                string _tablename = dv[i]["TableName"].ToString();
                string _tablepassword = dv[i]["TablePassword"].ToString();
                UC_Table.EN_TableStatus _tablestatus = (Convert.ToBoolean(dv[i]["TableStatus"])) ?
                    UC_Table.EN_TableStatus.Reservation : UC_Table.EN_TableStatus.NotReservation;

                UC_Table uc = new UC_Table(_tableid, _tablename, _tablepassword, _tablestatus);
                uc.DataBack += _Refresh;
                uc.Width = (this.Width / 3) - 30;
                flp_body.Controls.Add(uc);

            }

        }

        void _Refresh()
        {

            _Tables = cls_Tables.GetTables();
            _LoadTables(_Tables.DefaultView);

            txt_searchtable.Text = string.Empty;

            if (cb_filter.Items.Count > 0)
                cb_filter.SelectedIndex = 0;

        }

        private void UC_Tables_Load(object sender, EventArgs e)
        {
            _LoadTables(_Tables.DefaultView);
        }

        private void flp_body_SizeChanged(object sender, EventArgs e)
        {

            foreach (UC_Table uc in flp_body.Controls)
            {
                if (uc is UC_Table)
                    uc.Width = (this.Width / 3) - 30;

            }

        }

        private void btn_addtable_Click(object sender, EventArgs e)
        {
            frm_AddUpdateTable frm = new frm_AddUpdateTable();
            frm.DataBack += _Refresh;
            frm.ShowDialog();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataView _dv = _Tables.DefaultView;

            switch (cb_filter.Text.Trim())
            {

                case "الكل":
                    _dv.RowFilter = "";
                    break;

                case "الطاولات المتاحة":
                    _dv.RowFilter = string.Format("TableStatus = {0}", (byte)cls_Tables.EN_TableStatus.NotReservation);
                    break;

                case "الطاولات غير المتاحة":
                    _dv.RowFilter = string.Format("TableStatus = {0}", (byte)cls_Tables.EN_TableStatus.Reservation);
                    break;

            }

            _LoadTables(_dv);
            txt_searchtable.Text = string.Empty;

        }

        private void txt_searchtable_TextChanged(object sender, EventArgs e)
        {

            DataView _dv = _Tables.DefaultView;

            switch (cb_filter.Text.Trim())
            {

                case "الكل":
                    _dv.RowFilter = string.Format("TableName LIKE '%{0}%'", txt_searchtable.Text.Trim());
                    break;

                case "الطاولات المتاحة":
                    _dv.RowFilter = string.Format("TableStatus = {0} AND TableName LIKE '%{1}%'", (byte)cls_Tables.EN_TableStatus.NotReservation, txt_searchtable.Text.Trim());
                    break;

                case "الطاولات غير المتاحة":
                    _dv.RowFilter = string.Format("TableStatus = {0} AND TableName LIKE '%{1}%'", (byte)cls_Tables.EN_TableStatus.Reservation, txt_searchtable.Text.Trim());
                    break;

            }

            _LoadTables(_dv);

        }
    }
}
