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
        DataView _ReservationsTables;
        DataView _NotReservationsTables;

        public UC_Tables()
        {
            InitializeComponent();
        }

        void _LoadTables()
        {

            flp_body.Controls.Clear();

            _Tables = cls_Tables.GetTable();

            _ReservationsTables = _Tables.DefaultView;
            _ReservationsTables.RowFilter = "TableStatus = 1";

            _NotReservationsTables = _Tables.DefaultView;
            _NotReservationsTables.RowFilter = "TableStatus = 0";

            switch (cb_filter.SelectedItem.ToString())
            {

                case "الكل":
                    _LoadAllTables();
                    return;

                case "الطاولات المتاحة":
                    _LoadReservationsTables();
                    return;

                case "الطاولات غير المتاحة":
                    _LoadNotReservationsTables();
                    return;
                
            }


        }

        void _LoadAllTables()
        {

            foreach (DataRow row in _Tables.Rows)
            {

                int _tableid = Convert.ToInt32(row["TableID"]);
                string _tablename = row["TableName"].ToString();
                string _tablepassword = row["TablePassword"].ToString();
                UC_Table.EN_TableStatus _tablestatus = (Convert.ToBoolean(row["TableStatus"])) ?
                    UC_Table.EN_TableStatus.Reservation : UC_Table.EN_TableStatus.NotReservation;

                UC_Table uc = new UC_Table(_tableid, _tablename, _tablepassword, _tablestatus);
                uc.DataBack += _Refresh;
                uc.Width = (this.Width / 3) - 30;
                flp_body.Controls.Add(uc);

            }

        }

        void _LoadReservationsTables()
        {

            // filter on _tables

            foreach (DataRow row in _ReservationsTables.ToTable().Rows)
            {

                int _tableid = Convert.ToInt32(row["TableID"]);
                string _tablename = row["TableName"].ToString();
                string _tablepassword = row["TablePassword"].ToString();
                UC_Table.EN_TableStatus _tablestatus = (Convert.ToBoolean(row["TableStatus"])) ?
                    UC_Table.EN_TableStatus.Reservation : UC_Table.EN_TableStatus.NotReservation;

                UC_Table uc = new UC_Table(_tableid, _tablename, _tablepassword, _tablestatus);
                uc.DataBack += _Refresh;
                uc.Width = (this.Width / 3) - 30;
                flp_body.Controls.Add(uc);

            }

        }

        void _LoadNotReservationsTables()
        {

            // filter on _tables

            foreach (DataRow row in _NotReservationsTables.ToTable().Rows)
            {

                int _tableid = Convert.ToInt32(row["TableID"]);
                string _tablename = row["TableName"].ToString();
                string _tablepassword = row["TablePassword"].ToString();
                UC_Table.EN_TableStatus _tablestatus = (Convert.ToBoolean(row["TableStatus"])) ?
                    UC_Table.EN_TableStatus.Reservation : UC_Table.EN_TableStatus.NotReservation;

                UC_Table uc = new UC_Table(_tableid, _tablename, _tablepassword, _tablestatus);
                uc.DataBack += _Refresh;
                uc.Width = (this.Width / 3) - 30;
                flp_body.Controls.Add(uc);

            }

        }

        void _Refresh()
        {
            
            txt_searchtable.Text = string.Empty;
            cb_filter.SelectedIndex = 0;
            _LoadTables();

        }

        private void UC_Tables_Load(object sender, EventArgs e)
        {

            _LoadTables();

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
            _LoadTables();
        }

        private void txt_searchtable_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
