using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using Cafe_Management_System.Forms.Tables.frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Tables.UserControls
{
    public partial class UC_Table : UserControl
    {

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler DataBack;

        public enum EN_TableStatus
        {
            NotReservation = 0,
            Reservation = 1
        }

        enum EN_ReservationStates
        {
            State1 = 0,
            State2 = 1
        }
        EN_ReservationStates _ReservationStates;

        cls_Tables _Table;
        cls_ReservationsTables _Reservation;

        public UC_Table(int TableID, string TableName,string TablePassword, EN_TableStatus TableStatus)
        {
            
            InitializeComponent();

            _Table = new cls_Tables(TableID, TableName, TablePassword, Convert.ToBoolean(TableStatus));

            if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
                _Reservation = cls_ReservationsTables.GetActiveReservation(_Table.TableID);

            else
                _Reservation = null;

        }

        void _SetReservationAsContinue()
        {

            lbl_reservationstatus.Visible = false;

            this.BackColor = Color.FromArgb(50, 108, 90);
            this.ForeColor = Color.White;
            lbl_reservationtime.Visible = true;
            lbl_reservationname.Visible = true;
            lbl_reesrvationnamelbl.Visible = true;

            lbl_reservationname.Text = _Reservation.ReservationName;
            lbl_reservationtime.Text = Convert.ToDateTime(_Reservation.ReservationStartTime).ToShortTimeString();
            timer_reservationtimeremender.Start();

        }

        void _SetReservationAsNotContinue()
        {

            lbl_reservationstatus.Visible = true;
            this.BackColor = Color.FromArgb(150, 108, 90);

        }

        void _SetTableAsNotReservation()
        {

            this.BackColor = Color.FromArgb(0, 108, 190);
            this.ForeColor = Color.White;
            lbl_reservationtime.Visible = false;
            lbl_reservationname.Visible = false;
            lbl_reesrvationnamelbl.Visible = false;
            btn_reservationtable.Enabled = true;
            lbl_reservationname.Text = string.Empty;

            _ReservationStates = EN_ReservationStates.State1;

        }

        void _CheckReservationStatus()
        {

            btn_reservationtable.Enabled = false;

            if (DateTime.Now < _Reservation.ReservationEndTime)
                _Reservation.ReservationStatus = cls_ReservationsTables.EN_ReservationStatus.OngoingReservation;

            else
                _Reservation.ReservationStatus = cls_ReservationsTables.EN_ReservationStatus.ExpiredReservation;

            switch (_Reservation.ReservationStatus)
            {

                case cls_ReservationsTables.EN_ReservationStatus.OngoingReservation:

                    _SetReservationAsContinue();

                    break;

                case cls_ReservationsTables.EN_ReservationStatus.ExpiredReservation:

                    _SetReservationAsNotContinue();

                    break;

            }

        }

        void _SetTable()
        {

            lbl_tablename.Text = _Table.TableName;
            lbl_tablestatus.Text = (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation) ? "غير متاح" : "متاح";
            txt_reservationname.Visible = false;

            switch (_Table.TableStatus)
            {

                case cls_Tables.EN_TableStatus.Reservation:
                    
                    _CheckReservationStatus();
                    break;

                case cls_Tables.EN_TableStatus.NotReservation:

                    _SetTableAsNotReservation();
                    break;

            }

        }

        void _RefreshTable()
        {

            _Table = cls_Tables.Find(_Table.TableID);

            if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
                _Reservation = cls_ReservationsTables.GetActiveReservation(_Table.TableID);

            else
                _Reservation = null;

            _SetTable();

        }

        private void UC_Table_Load(object sender, EventArgs e)
        {
            _SetTable();
        }

        private void btn_reservationtable_Click(object sender, EventArgs e)
        {

            switch (_ReservationStates)
            {

                case EN_ReservationStates.State1:

                    txt_reservationname.Text = "";
                    txt_reservationname.Visible = true;
                    _ReservationStates = EN_ReservationStates.State2;

                    break;

                case EN_ReservationStates.State2:

                    if (!string.IsNullOrEmpty(txt_reservationname.Text))
                    {

                        _Reservation = new cls_ReservationsTables(_Table.TableID, txt_reservationname.Text.Trim());

                        if (_Reservation.IsReservationActive())
                        {

                            MessageBox.Show("الاسم المستخدم محجوز بالفعل, يرحئ اختيار اسم اخر.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            _Reservation = null;
                            return;

                        }

                        if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
                        {
                            MessageBox.Show("الطاولة محجوزة بالفعل." + _Reservation.ReservationName, "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            return;
                        }

                        if (_Reservation.ReservationTable())
                        {

                            MessageBox.Show("تم حجز الطاولة بأسم " + _Reservation.ReservationName, "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                            if (_Table.TableStatus == cls_Tables.EN_TableStatus.NotReservation)
                                _Table.ChangeTableStatus();

                            _RefreshTable();
                            return;
                        
                        }

                        else
                        {
                            MessageBox.Show("خطأ اثناء حجز الطاولة" + _Reservation.ReservationName, "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            _Reservation = null;
                            return;
                        }

                    }

                    else
                        MessageBox.Show("إدخل اسم صاحب الحجز", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    break;

            }

        }

        private void txt_reservationname_IconLeftClick(object sender, EventArgs e)
        {

            _ReservationStates = EN_ReservationStates.State1;
            txt_reservationname.Visible = false;
            txt_reservationname.Text = string.Empty;

        }

        private void btn_deletetable_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("متأكد من جذف هذه الطاولة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {

                if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
                {
                    MessageBox.Show("لا يمكن الحذف, الطاولة محجوزة الان.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }

                if (_Table.IsTableReferences())
                {
                    
                    MessageBox.Show("لا يمكن الحذف, الطاولة مرتبطة ببيانات اخرى في النظام.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }

                if (_Table.DeleteTable(_Table.TablePassword))
                {
                    _Table = null;
                    MessageBox.Show("تم الحذف بنجاح", "information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    DataBackToContainer();
                }

                else
                    MessageBox.Show("حدث خطأ اثناء حذف الطاولة.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        private void DataBackToContainer()
        {
            DataBack?.Invoke();
        }

        private void btn_updatetable_Click(object sender, EventArgs e)
        {

            if (_Table.TableStatus == cls_Tables.EN_TableStatus.Reservation)
            {
                MessageBox.Show("الطاولة محجوزة الان, لا يمكنك التعديل عليها.", "information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly); ;
                return;
            }

            frm_AddUpdateTable frm = new frm_AddUpdateTable(_Table.TableID);
            frm.DataBack += DataBackToContainer;
            frm.ShowDialog();

        }

        private void txt_reservationname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btn_reservationtable.PerformClick();
        }

        private void timer_reservationtimeremender_Tick(object sender, EventArgs e)
        {

            if (DateTime.Now < _Reservation.ReservationEndTime)
                _Reservation.ReservationStatus = cls_ReservationsTables.EN_ReservationStatus.OngoingReservation;

            else
            {

                timer_reservationtimeremender.Stop();
                _Reservation.ReservationStatus = cls_ReservationsTables.EN_ReservationStatus.ExpiredReservation;
                _Reservation.SetReservationAs(_Reservation.ReservationStatus);
                _SetTable();
                
            }

        }
    }
}
