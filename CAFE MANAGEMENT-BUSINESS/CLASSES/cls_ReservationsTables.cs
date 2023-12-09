using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_ReservationsTables
    {

        public enum EN_ReservationStatus { ExpiredReservation = 0, OngoingReservation = 1 }

        public int ReservationID { set; get; }
        public string ReservationName { set; get; }
        public double ReservationPrice { set; get; }
        public DateTime ReservationStartTime { set; get; }
        public DateTime ReservationEndTime { set; get; }
        public int ReservationDuration { set; get; }
        public EN_ReservationStatus ReservationStatus { set; get; }
        public cls_Tables Table { set; get; }

        private cls_SystemInfo _systeminfo;

        public cls_ReservationsTables(int TableID, string ReservationName)
        {

            _systeminfo = cls_SystemInfo.GetSystemInfo();

            ReservationID = -1;
            Table = cls_Tables.Find(TableID);

            this.ReservationName = ReservationName;
            ReservationStartTime = DateTime.Now;
            ReservationEndTime = ReservationStartTime.AddHours(_systeminfo.ReservationDuration);
            ReservationPrice = _systeminfo.ReservationPrice;
            ReservationDuration = _systeminfo.ReservationDuration;
            ReservationStatus = EN_ReservationStatus.OngoingReservation;

        }

        private cls_ReservationsTables(int ReservationID, string ReservationName, double ReservationPrice, DateTime ReservationStartTime,
            DateTime ReservationEndTime, int ReservationDuration, bool ReservationStatus)
        {

            this.ReservationID = ReservationID;
            this.ReservationName = ReservationName;
            this.ReservationPrice = ReservationPrice;
            this.ReservationStartTime = ReservationStartTime;
            this.ReservationEndTime = ReservationEndTime;
            this.ReservationDuration = ReservationDuration;
            this.ReservationStatus = (ReservationStatus) ? EN_ReservationStatus.OngoingReservation : EN_ReservationStatus.ExpiredReservation;

            this.Table = cls_Tables.FindTableByReservation(this.ReservationID);
            this._systeminfo = cls_SystemInfo.GetSystemInfo();

        }

        public bool IsReservationActive()
        {
            return cls_ReservationsTables_D.IsReservationActive(this.ReservationName);
        }

        public static cls_ReservationsTables Find(int ReservationID)
        {

            string reservationname = "";
            double reservationprice = 0;
            DateTime reservationstarttime = DateTime.MinValue;
            DateTime reservationendtime = DateTime.MinValue;
            int reservationduration = 0;
            bool reservationstatus = false;

            if (cls_ReservationsTables_D.Find(ReservationID, ref reservationname, ref reservationprice,
                ref reservationstarttime, ref reservationendtime, ref reservationduration, ref reservationstatus))
                return new cls_ReservationsTables(ReservationID, reservationname, reservationprice,
                    reservationstarttime, reservationendtime, reservationduration, reservationstatus);

            return null;

        }

        public static cls_ReservationsTables FindByRequest(int RequestID)
        {

            int reservationID = -1;
            string reservationname = "";
            double reservationprice = 0;
            DateTime reservationstarttime = DateTime.MinValue;
            DateTime reservationendtime = DateTime.MinValue;
            int reservationduration = 0;
            bool reservationstatus = false;

            if (cls_ReservationsTables_D.FindByRequest(RequestID, ref reservationID, ref reservationname,
                ref reservationprice, ref reservationstarttime, ref reservationendtime, ref reservationduration,
                ref reservationstatus))
                return new cls_ReservationsTables(reservationID, reservationname, reservationprice,
                    reservationstarttime, reservationendtime, reservationduration, reservationstatus);

            return null;

        }

        public static cls_ReservationsTables FindByInstalledService(int InstalledServiceID)
        {

            int reservationID = -1;
            string reservationname = "";
            double reservationprice = 0;
            DateTime reservationstarttime = DateTime.MinValue;
            DateTime reservationendtime = DateTime.MinValue;
            int reservationduration = 0;
            bool reservationstatus = false;

            if (cls_ReservationsTables_D.FindByInstalledService(InstalledServiceID, ref reservationID, ref reservationname,
                ref reservationprice, ref reservationstarttime, ref reservationendtime, ref reservationduration,
                ref reservationstatus))
                return new cls_ReservationsTables(reservationID, reservationname, reservationprice,
                    reservationstarttime, reservationendtime, reservationduration, reservationstatus);

            return null;

        }

        public static cls_ReservationsTables GetActiveReservation(int TableID)
        {

            int reservationid = 0;
            string reservationname = "";
            double reservationprice = 0;
            DateTime reservationstarttime = DateTime.MinValue;
            DateTime reservationendtime = DateTime.MinValue;
            int reservationduration = 0;
            bool reservationstatus = false;
            
            if (cls_ReservationsTables_D.GetActiveReservation(TableID, ref reservationid, ref reservationname, ref reservationprice, ref reservationstarttime, 
                ref reservationendtime, ref reservationduration, ref reservationstatus))

                return new cls_ReservationsTables(reservationid, reservationname, reservationprice, reservationstarttime, reservationendtime, 
                    reservationduration, reservationstatus);

            return null;

        }


        //public static bool GetReservationNameAndTime(int TableID, ref string ReservationName, ref DateTime ReservationStartTime)
        //{
        //    return cls_ReservationsTables_D.GetReservationNameAndTime(TableID, ref ReservationName, ref ReservationStartTime);
        //}

        public bool ReservationTable()
        {

            return cls_ReservationsTables_D.ReservationTable(Table.TableID, ReservationName, ReservationPrice,
                ReservationStartTime, ReservationEndTime, ReservationDuration);

        }

        public bool SetReservationAs(EN_ReservationStatus ReservationStatus)
        {
            return cls_ReservationsTables_D.SetReservationAs(this.ReservationID, Convert.ToBoolean(ReservationStatus));
        }

        private static DataTable _GetServicesInstalledByReservation(int ReservationID)
        {
            return cls_ReservationsTables_D.GetServicesInstalledByReservation(ReservationID);
        }

        private static Dictionary<long, int> _HandleInstalledRequest(DataRow InstalledRequest)
        {

            Dictionary<long, int> _Services = new Dictionary<long, int>();

            long _RequestValue = Convert.ToInt64(InstalledRequest["Services"]);
            string _RequestCount = InstalledRequest["ServicesCount"].ToString();

            for (long i = 1; i <= _RequestValue; i *= 2)
            {

                if ((_RequestValue & i) == i)
                {
                    _Services.Add(i, Convert.ToInt32(_RequestCount[0]));
                    _RequestCount.Substring(1, _RequestCount.Length - 1);
                }
            }

            return _Services;

        }

        public static Dictionary<long, int> GetServicesInstalledByReservation(int ReservationID)
        {

            DataTable dt = _GetServicesInstalledByReservation(ReservationID);
            Dictionary<long, int> _Services = new Dictionary<long, int>();

            foreach (DataRow row in dt.Rows)
            {

                Dictionary<long, int> _services = _HandleInstalledRequest(row);

                foreach (var item in  _services)
                    _Services.Add(item.Key, item.Value);

            }

            return _Services;

        }

    }
}
