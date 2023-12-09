using CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Requests
    {

        public enum EN_RequestStatus
        {
            RequestsToAccounting = 0,
            RequestsWillBeAccountingLater = 1,
            RequestsHaveBeenAccouted = 2
        }

        enum EN_Mode { AddNew = 1, ChangeRequestMode = 2 }
        EN_Mode _Mode;

        public int RequestID { set; get; }
        public string RequestCode { set; get; }
        public cls_ReservationsTables Reservation { set; get; }
        public EN_RequestStatus RequestStatus { set; get; }
        public cls_ManagementAppUser User { set; get; }

        public cls_Requests(int ReservationID)
        {

            this.RequestID = -1;
            this.Reservation = cls_ReservationsTables.Find(ReservationID);
            this.RequestStatus = EN_RequestStatus.RequestsToAccounting;
            this.RequestCode = cls_util.GetRandomKey(8);
            this.User = new cls_ManagementAppUser();

            this._Mode = EN_Mode.AddNew;

        }

        public cls_Requests(int requestID, int reservationID, EN_RequestStatus NewRequestStatus, string requestCode, string UserName)
        {

            this.RequestID = requestID;
            this.Reservation = cls_ReservationsTables.Find(reservationID);
            this.RequestStatus = NewRequestStatus;
            this.RequestCode = requestCode;
            this.User = cls_ManagementAppUser.Find(UserName);

            this._Mode = EN_Mode.ChangeRequestMode;

        }

        public static bool IsExist(string RequestCode)
        {
            return true;
        }

        public static cls_Requests Find(string RequestCode)
        {
            return null;
        }

        public static cls_Requests FindByReservationName(string ReservationName)
        {
            return null;
        }

        private bool _SetRequestAs()
        {
            return true;
        }

        private bool _AddRequest()
        {
            return true;
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (_AddRequest())
                    {
                        _Mode = EN_Mode.ChangeRequestMode;
                        return true;
                    }
                    break;

                case EN_Mode.ChangeRequestMode:
                    if (_SetRequestAs())
                        return true;
                    break;

            }

            return false;

        }

        public static bool Delete()
        {
            return true;
        }

        public static DataTable GetRequests()
        {
            return null;
        }

    }
}
