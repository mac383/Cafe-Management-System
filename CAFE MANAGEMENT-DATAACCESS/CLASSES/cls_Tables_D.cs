using SpaceLibraries.Classes.Database;
using SpaceLibraries.Classes.Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS
{
    public class cls_Tables_D
    {

        public static bool IsTableExists(int TableID)
        {
            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM Tables
                             WHERE Tables.TableID = @TableID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsExist = true;

                Connection.Close();

            }

            catch
            {
                
            }

            finally
            {
                Connection.Close();
            }

            return IsExist;
        }
        
        public static bool IsTableExists(string TableName)
        {
            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM Tables
                             WHERE Tables.TableName = @TableName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableName", TableName);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsExist = true;

                Connection.Close();

            }

            catch
            {

            }

            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static bool IsTableExistsWithoutThisTable(int TableID, string TableName)
        {
            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' 
                             FROM Tables
                             WHERE TableID != @TableID AND TableName = @TableName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);
            Command.Parameters.AddWithValue("@TableName", TableName);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsExist = true;

                Connection.Close();

            }

            catch
            {

            }

            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static bool IsTableReferences(int TableID)
        {

            int Count = 0;

            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT COUNT(TablesReservations.TableID)
                             FROM Tables INNER JOIN
                             TablesReservations ON Tables.TableID = TablesReservations.TableID
							 WHERE Tables.TableID = @TableID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int count))
                    Count = count;

                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return Count > 0;

        }

        public static bool FindTable(ref int TableID, string TableName, ref string TablePassword,
            ref bool TableStatus)
        {
            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT Tables.TableID, Tables.TableName, Tables.TableStatus, Tables.TablePassword
                             FROM Tables 
                             WHERE tables.TableName = @TableName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableName", TableName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    TableID = Convert.ToInt32(Reader["TablePassword"]);
                    TablePassword = cls_Encryption.Decrypt(Reader["TablePassword"].ToString());
                    TableStatus = Convert.ToBoolean(Reader["TableStatus"]);

                }

                Reader.Close();
                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;
        }

        public static bool FindTable(int TableID, ref string TableName, ref string TablePassword,
            ref bool TableStatus)
        {
            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT Tables.TableID, Tables.TableName, Tables.TableStatus, Tables.TablePassword
                             FROM Tables 
                             WHERE tables.TableID = @TableID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    TableName = Reader["TableName"].ToString();
                    TablePassword = cls_Encryption.Decrypt(Reader["TablePassword"].ToString());
                    TableStatus = Convert.ToBoolean(Reader["TableStatus"]);

                }

                Reader.Close();
                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;
        }

        public static bool FindTableByReservation(int ReservationID, ref int TableID, ref string TableName,
            ref string TablePassword, ref bool TableStatus)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT Tables.TableID, Tables.TableName, Tables.TablePassword,
                             Tables.TableStatus FROM Tables INNER JOIN
                             TablesReservations ON Tables.TableID = TablesReservations.TableID
				             WHERE TablesReservations.ReservationID = @ReservationID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationID", ReservationID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    TableID = Convert.ToInt32(Reader["TableID"]);
                    TableName = Reader["TableName"].ToString();
                    TablePassword = cls_Encryption.Decrypt(Reader["TablePassword"].ToString());
                    TableStatus = Convert.ToBoolean(Reader["TableStatus"]);

                }

                Reader.Close();
                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsFind;
        }

        public static DataTable GetTables()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();

            string Query = @"SELECT Tables.TableID, Tables.TableName, Tables.TablePassword, Tables.TableStatus
                             FROM Tables";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                dt.Load(Reader);

                Reader.Close();
                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static int AddTable(string TableName, string TablePassword)
        {

            if (IsTableExists(TableName))
                return -1;

            int _NewID = -1;
            TablePassword = cls_Encryption.Encrypt(TablePassword);

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO Tables
                            (TableName, TablePassword, TableStatus)
                             VALUES (@TableName, @TablePassword, 0);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableName", TableName);
            Command.Parameters.AddWithValue("@TablePassword", TablePassword);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int newid))
                    _NewID = newid;

                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _NewID;

        }

        public static bool UpdateTable(int TableID, string TableName, string NewPassword, string OldPassword)
        {

            if (IsTableExistsWithoutThisTable(TableID, TableName))
                return false;

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE Tables
                             SET TableName = @TableName, TablePassword = @NewPassword
                             WHERE Tables.TablePassword = @OldPassword AND Tables.TableID = @TableID AND Tables.TableStatus = 0";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@TableID", TableID);
            Command.Parameters.AddWithValue("@TableName", TableName);
            Command.Parameters.AddWithValue("@NewPassword", cls_Encryption.Encrypt(NewPassword));
            Command.Parameters.AddWithValue("@OldPassword", cls_Encryption.Encrypt(OldPassword));
            
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

        public static bool DeleteTable(int TableID, string TablePassword)
        {

            if (!IsTableExists(TableID))
                return false;

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE FROM Tables WHERE Tables.TableID = @TableID AND Tables.TableStatus = 0";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);

            try
            {
               
                Connection.Open();

                object Result = Command.ExecuteNonQuery();

                if (Result != DBNull.Value && int.TryParse(Result.ToString(), out int rowsaffected))
                    RowsAffected = rowsaffected;

                Connection.Close();

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return RowsAffected > 0;

        }

        public static bool ChangeTableStatus(int TableID, bool ToReservation)
        {
            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE Tables
                             SET TableStatus = @ToCase
                             WHERE Tables.TableID = @TableID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@TableID", TableID);
            Command.Parameters.AddWithValue("@ToCase", Convert.ToInt16(ToReservation));

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

    }
}
