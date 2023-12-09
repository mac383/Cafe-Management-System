using CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES;
using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        }

        private cls_Requests(int requestID, int reservationID, short status, string requestCode, int userID)
        {

            this.RequestID = requestID;
            this.Reservation = cls_ReservationsTables.Find(reservationID);
            
            this.RequestStatus = (status == 2) ? EN_RequestStatus.RequestsHaveBeenAccouted : (status == 1) ?
                EN_RequestStatus.RequestsWillBeAccountingLater : EN_RequestStatus.RequestsToAccounting;

            this.RequestCode = requestCode;
            this.User = cls_ManagementAppUser.Find(userID);

        }

        public static bool IsExist(string RequestCode)
        {
            return cls_Requests_D.IsExist(RequestCode);
        }

        public static cls_Requests Find(string RequestCode)
        {

            int requestID = -1;
            int reservationID = -1;
            short status = -1;
            int userID = -1;

            if (cls_Requests_D.Find(RequestCode, ref requestID, ref reservationID, ref status, ref userID))
                return new cls_Requests(requestID, reservationID, status, RequestCode, userID);

            return null;

        }

        public static cls_Requests FindByReservationName(string ReservationName)
        {

            int requestID = -1;
            int reservationID = -1;
            short status = -1;
            string requestCode = "";
            int userID = -1;

            if (cls_Requests_D.FindByReservationName(ReservationName, ref requestID, ref reservationID, ref status, ref requestCode, ref userID))
                return new cls_Requests(requestID, reservationID, status, requestCode, userID);

            return null;

        }

        public bool AddRequest()
        {

            this.RequestID = cls_Requests_D.AddRequest(this.Reservation.ReservationID, this.RequestCode);
            return this.RequestID > 0;

        }

        public static bool SetRequestAs(int RequestID, short RequestStatus, int UserID)
        {

            return cls_Requests_D.SetRequestAs(RequestID, RequestStatus, UserID);

        }

        public static bool Delete(int RequestID)
        {
            return cls_Requests_D.Delete(RequestID);
        }

        public static DataTable GetRequests()
        {
            return cls_Requests_D.GetRequests();
        }

    }
}
