using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_ReservationsTables_D
    {

        public static bool IsReservationActive(string ReservationName)
        {
            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ISEXIST = 'TRUE'
                             FROM TablesReservations
                             WHERE TablesReservations.ReservationName = @ReservationName AND ReservationStatus = 1";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationName", ReservationName);

            try
            {
                
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsExist = true;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsExist;

        }

        public static bool GetReservationNameAndTime(int TableID, ref string ReservationName, ref DateTime ReservationStartTime)
        {
            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT TablesReservations.ReservationName, TablesReservations.ReservationStartTime
                             FROM Tables INNER JOIN
                             TablesReservations ON Tables.TableID = TablesReservations.TableID
				             WHERE Tables.TableID = @TableID AND ReservationStatus = 1";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ReservationName = Reader["ReservationName"].ToString();
                    ReservationStartTime = Convert.ToDateTime(Reader["ReservationStartTime"]);
                }

                Connection.Close();
            }

            catch
            {

            }

            finally
            {
                Connection.Close();
            }

            return IsFind;
        }

        public static bool GetActiveReservation(int TableID, ref int ReservationID, ref string ReservationName, ref double ReservationPrice,
            ref DateTime ReservationStartTime, ref DateTime ReservationEndTime, ref int ReservationDuration, ref bool ReservationStatus)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ReservationID, ReservationName, ReservationPrice, ReservationStartTime, ReservationEndTime,
                             ReservationDuration, ReservationStatus
                             FROM TablesReservations
                             WHERE TableID = @TableID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    ReservationID = Convert.ToInt32(Reader["ReservationID"]);
                    ReservationName = Reader["ReservationName"].ToString();
                    ReservationPrice = Convert.ToDouble(Reader["ReservationPrice"]);
                    ReservationStartTime = Convert.ToDateTime(Reader["ReservationStartTime"]);
                    ReservationEndTime = Convert.ToDateTime(Reader["ReservationEndTime"]);
                    ReservationDuration = Convert.ToInt16(Reader["ReservationDuration"]);
                    ReservationStatus = Convert.ToBoolean(Reader["ReservationStatus"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;

        }

        public static bool ReservationTable(int TableID, string ReservationName, double ReservationPrice,
            DateTime ReservationStartTime, DateTime ReservationEndTime, int ReservationDuration)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO TablesReservations
                             (TableID, ReservationName, ReservationPrice, ReservationStartTime,
                             ReservationDuration,ReservationStatus, ReservationEndTime)
                             VALUES   
                             (@TableID, @ReservationName, @ReservationPrice, @ReservationStartTime,
                             @ReservationDuration, 1, @ReservationEndTime)";

            /*        1 in ReservationStatus is mean that the reservation is not closed
                      and 0 mean that the reservation is closed.     */

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TableID", TableID);
            Command.Parameters.AddWithValue("@ReservationName", ReservationName);
            Command.Parameters.AddWithValue("@ReservationPrice", ReservationPrice);
            Command.Parameters.AddWithValue("@ReservationStartTime", ReservationStartTime);
            Command.Parameters.AddWithValue("@ReservationDuration", ReservationDuration);
            Command.Parameters.AddWithValue("@ReservationEndTime", ReservationEndTime);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteNonQuery();

                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int rowsaffected))
                    RowsAffected = rowsaffected;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;

        }

        public static bool SetReservationAs(int ReservationID, bool ReservationStatus)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE TablesReservations
                             SET ReservationStatus = @ReservationStatus
                             WHERE ReservationID = @ReservationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationID", ReservationID);
            Command.Parameters.AddWithValue("@ReservationStatus", ReservationStatus);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

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

        public static bool Find(int ReservationID, ref string ReservationName, ref double ReservationPrice,
            ref DateTime ReservationStartTime, ref DateTime ReservationEndTime, ref int ReservationDuration,
            ref bool ReservationStatus)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ReservationID, ReservationName, ReservationPrice, ReservationStartTime,
                             ReservationEndTime, ReservationDuration, ReservationStatus
                             FROM TablesReservations
                             WHERE ReservationID = @ReservationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationID", ReservationID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    ReservationName = Reader["ReservationName"].ToString();
                    ReservationPrice = Convert.ToDouble(Reader["ReservationPrice"]);
                    ReservationStartTime = Convert.ToDateTime(Reader["ReservationStartTime"]);
                    ReservationEndTime = Convert.ToDateTime(Reader["ReservationEndTime"]);
                    ReservationDuration = Convert.ToInt16(Reader["ReservationDuration"]);
                    ReservationStatus = Convert.ToBoolean(Reader["ReservationStatus"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;

        }

        public static bool FindByRequest(int RequestID, ref int ReservationID, ref string ReservationName,
            ref double ReservationPrice, ref DateTime ReservationStartTime, ref DateTime ReservationEndTime,
            ref int ReservationDuration, ref bool ReservationStatus)
        {

            /*
             هذا الفنكشن يمكن ان يكون زايد ولا حاجة له
             */

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT TablesReservations.ReservationID, TablesReservations.ReservationName,
                             TablesReservations.ReservationPrice, TablesReservations.ReservationStartTime,
                             TablesReservations.ReservationEndTime, TablesReservations.ReservationDuration, 
                             TablesReservations.ReservationStatus
                             FROM TablesReservations INNER JOIN
                             AccountingRequests ON TablesReservations.ReservationID = AccountingRequests.ReservationID
				             WHERE AccountingRequests.RequestID = @RequestID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@RequestID", RequestID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ReservationID = Convert.ToInt32(Reader["ReservationID"]);
                    ReservationName = Reader["ReservationName"].ToString();
                    ReservationPrice = Convert.ToDouble(Reader["ReservationPrice"]);
                    ReservationStartTime = Convert.ToDateTime(Reader["ReservationStartTime"]);
                    ReservationEndTime = Convert.ToDateTime(Reader["ReservationEndTime"]);
                    ReservationDuration = Convert.ToInt16(Reader["ReservationDuration"]);
                    ReservationStatus = Convert.ToBoolean(Reader["ReservationStatus"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;

        }

        public static bool FindByInstalledService(int InstalledServiceID, ref int ReservationID, ref string ReservationName, ref double ReservationPrice,
            ref DateTime ReservationStartTime, ref DateTime ReservationEndTime, ref int ReservationDuration,
            ref bool ReservationStatus)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT TablesReservations.ReservationID, TablesReservations.ReservationName, TablesReservations.ReservationPrice,
                             TablesReservations.ReservationStartTime, TablesReservations.ReservationEndTime, 
                             TablesReservations.ReservationDuration, TablesReservations.ReservationStatus
                             FROM TablesReservations INNER JOIN
                             InstalledServices ON TablesReservations.ReservationID = InstalledServices.ReservationID
						     WHERE InstalledServices.ServiceID = @InstalledServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@InstalledServiceID", InstalledServiceID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    ReservationID = Convert.ToInt32(Reader["ReservationID"]);
                    ReservationName = Reader["ReservationName"].ToString();
                    ReservationPrice = Convert.ToDouble(Reader["ReservationPrice"]);
                    ReservationStartTime = Convert.ToDateTime(Reader["ReservationStartTime"]);
                    ReservationEndTime = Convert.ToDateTime(Reader["ReservationEndTime"]);
                    ReservationDuration = Convert.ToInt16(Reader["ReservationDuration"]);
                    ReservationStatus = Convert.ToBoolean(Reader["ReservationStatus"]);

                }

                Reader.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;

        }

        public static DataTable GetServicesInstalledByReservation(int ReservationID)
        {

            DataTable dt = new DataTable();
            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT InstalledServices.Services, InstalledServices.ServicesCount
                             FROM InstalledServices INNER JOIN
                             TablesReservations ON InstalledServices.ReservationID = TablesReservations.ReservationID
						     WHERE TablesReservations.ReservationID = @ReservationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationID", ReservationID);

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
