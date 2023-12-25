using CAFE_MANAGEMENT_BUSINESS.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.Forms.Settings.UserControls
{
    public partial class UC_SystemInfo : UserControl
    {
        public UC_SystemInfo()
        {
            InitializeComponent();
        }

        private void cb_curreny_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_save.Visible = true;
        }

        private void nud_reservationtableprice_ValueChanged(object sender, EventArgs e)
        {
            btn_save.Visible = true;
        }

        private void nud_reservationtableduration_ValueChanged(object sender, EventArgs e)
        {
            btn_save.Visible = true;
        }

        private void UC_SystemInfo_Load(object sender, EventArgs e)
        {

            cls_SystemInfo systeminfo = cls_SystemInfo.GetSystemInfo();

            if (systeminfo == null)
                return;

            cb_curreny.SelectedIndex = cb_curreny.FindString(systeminfo.Currency);
            nud_reservationtableprice.Value = (int)systeminfo.ReservationPrice;
            nud_reservationtableduration.Value = (int)systeminfo.ReservationDuration;

            lbl_reservationtablepricelbl.Text += string.Format(" ({0})", systeminfo.Currency.ToString());

            btn_save.Visible = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            double reservationprice = Convert.ToDouble(nud_reservationtableprice.Value);
            int reservationduration = Convert.ToInt32(nud_reservationtableduration.Value);

            cls_SystemInfo systeminfo = new cls_SystemInfo(reservationprice, reservationduration, cb_curreny.SelectedItem.ToString().Trim());

            if (systeminfo.UpdateSystemInfo())
                MessageBox.Show("تم حفظ المعلومات بنجاح");

            else
                MessageBox.Show("حصل خطأ أثناء حفظ المعلومات");

        }
    }
}
