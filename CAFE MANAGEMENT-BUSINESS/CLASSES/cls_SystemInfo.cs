using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_SystemInfo
    {

        public double ReservationPrice { set; get; }
        public int ReservationDuration { set; get; }
        public string Currency { set; get; }

        public cls_SystemInfo(double reservationPrice, int reservationDuration, string currency)
        {
            ReservationPrice = reservationPrice;
            ReservationDuration = reservationDuration;
            Currency = currency;
        }

        public static cls_SystemInfo GetSystemInfo()
        {

            double reservationprice = 0;
            int reservationduration = 0;
            string currency = "";

            if (cls_SystemInfo_D.GetSystemInfo(ref reservationprice, ref reservationduration, ref currency))
                return new cls_SystemInfo(reservationprice, reservationduration, currency);

            return null;

        }

        public bool UpdateSystemInfo()
        {
            return cls_SystemInfo_D.UpdateSystemInfo(this.ReservationPrice, this.ReservationDuration, this.Currency);
        }

    }
}
