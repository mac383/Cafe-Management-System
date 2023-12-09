using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_Requests_D
    {

        public static bool IsExist(string RequestCode)
        {

            bool _IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ISEXIST = 'TRUE'
                             FROM  AccountingRequests
                             WHERE RequestCode = @RequestCode";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RequestCode", RequestCode);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    _IsExist = true;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _IsExist;

        }

        public static bool Find(string RequestCode, ref int RequestID, ref int ReservationID, ref short Status, ref int UserID)
        {

            bool _IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT RequestID, ReservationID, Status, RequestCode, ByUser
                             FROM AccountingRequests
                             WHERE RequestCode = @RequestCode";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RequestCode", RequestCode);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    _IsFind = true;

                    RequestID = Convert.ToInt32(Reader["RequestID"]);
                    ReservationID = Convert.ToInt32(Reader["ReservationID"]);
                    Status = Convert.ToInt16(Reader["Status"]);
                    UserID = Convert.ToInt32(Reader["ByUser"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _IsFind;

        }

        public static bool FindByReservationName(string ReservationName, ref int RequestID, ref int ReservationID, ref short Status, ref string Requestcode, ref int UserID)
        {

            bool _IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT AccountingRequests.RequestID, AccountingRequests.ReservationID, AccountingRequests.Status,
                             AccountingRequests.RequestCode, AccountingRequests.ByUser
                             FROM AccountingRequests INNER JOIN
                             TablesReservations ON AccountingRequests.ReservationID = TablesReservations.ReservationID
						     WHERE ReservationName = @ReservationName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationName", ReservationName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    _IsFind = true;

                    RequestID = Convert.ToInt32(Reader["RequestID"]);
                    ReservationID = Convert.ToInt32(Reader["ReservationID"]);
                    Status = Convert.ToInt16(Reader["Status"]);
                    Requestcode = Reader["RequestCode"].ToString().Trim();
                    UserID = Convert.ToInt32(Reader["ByUser"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _IsFind;

        }

        public static int AddRequest(int ReservationID, string RequestCode)
        {

            int _NewID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO AccountingRequests
                             (ReservationID, Status, RequestCode)
                             VALUES (@ReservationID, @Status, @RequestCode)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationID", ReservationID);
            Command.Parameters.AddWithValue("@Status", 0);
            Command.Parameters.AddWithValue("@RequestCode", RequestCode);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int _newid))
                    _NewID = _newid;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _NewID;

        }

        public static bool SetRequestAs(int RequestID, short Status, int UserID)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE AccountingRequests
                             SET Status = @Status, ByUser = @UserID
                             WHERE RequestID = @RequestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RequestID", RequestID);
            Command.Parameters.AddWithValue("@Status", Status);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    RowsAffected = rowsaffected;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;

        }

        public static bool Delete(int RequestID)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE AccountingRequests WHERE RequestID = @RequestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RequestID", RequestID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsAffected))
                    RowsAffected = rowsAffected;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;

        }

        public static DataTable GetRequests()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT AccountingRequests.RequestID, TablesReservations.ReservationName, AccountingRequests.Status,
                             AccountingRequests.RequestCode, [UserName] = 
                             (
                             	 SELECT People.UserName
                             	 FROM People INNER JOIN
                             	 ManagementAppUsers ON People.PersonID = ManagementAppUsers.PersonID
                             	 WHERE ManagementAppUsers.UserID = AccountingRequests.ByUser
                             )
                             FROM AccountingRequests INNER JOIN 
                             TablesReservations ON AccountingRequests.ReservationID = TablesReservations.ReservationID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                    dt.Load(Reader);

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return dt;

        }

    }
}
