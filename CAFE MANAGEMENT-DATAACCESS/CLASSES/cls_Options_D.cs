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
    public class cls_Options_D
    {

        public static bool IsExist(string OptionName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM ServicesOptions WHERE ServicesOptions.OptionName = @OptionName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionName", OptionName);

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

        public static bool IsExist(int OptionID, string OptionName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM ServicesOptions WHERE OptionName = @OptionName AND OptionID != @OptionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionID", OptionID);
            Command.Parameters.AddWithValue("@OptionName", OptionName);

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

        public static bool Find(int OptionID, ref string OptionName, ref double OptionPrice, ref long OptionValue)

        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT OptionID, OptionName, OptionPrice, OptionValue
                             FROM ServicesOptions
                             WHERE OptionID = 1";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionID", OptionID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    OptionName = Reader["OptionName"].ToString();
                    OptionPrice = Convert.ToDouble(Reader["OptionPrice"]);
                    OptionValue = Convert.ToInt64(Reader["OptionValue"]);

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

        public static bool Find(ref int OptionID, string OptionName, ref double OptionPrice, ref long OptionValue)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT OptionID, OptionName, OptionPrice, OptionValue
                             FROM ServicesOptions
                             WHERE OptionName = @OptionName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionName", OptionName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    OptionID = Convert.ToInt32(Reader["OptionID"]);
                    OptionPrice = Convert.ToDouble(Reader["OptionPrice"]);
                    OptionValue = Convert.ToInt64(Reader["OptionValue"]);

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

        public static bool Delete(int OptionID)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE ServicesOptions
                             WHERE OptionID = @OptionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionID", OptionID);

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

        public static int AddOption(string OptionName, double OptionPrice, long OptionValue, int ServiceID)
        {

            int _ID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO ServicesOptions
                             (OptionName, OptionPrice, OptionValue, ServiceID)
                             VALUES (@OptionName, @OptionPrice, @OptionValue, @ServiceID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionName", OptionName);
            Command.Parameters.AddWithValue("@OptionPrice", OptionPrice);
            Command.Parameters.AddWithValue("@OptionValue", OptionValue);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int newid))
                    _ID = newid;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _ID;

        }

        public static bool UpdateOption(int OptionID, string OptionName, double OptionPrice, long OptionValue, int ServiceID)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE ServicesOptions
                             SET OptionName = @OptionName, OptionPrice = @OptionPrice, OptionValue = @OptionValue, ServiceID = @ServiceID
                             WHERE OptionID = @OptionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionID", OptionID);
            Command.Parameters.AddWithValue("@OptionName", OptionName);
            Command.Parameters.AddWithValue("@OptionPrice", OptionPrice);
            Command.Parameters.AddWithValue("@OptionValue", OptionValue);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

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

        public static DataTable GetOptions(int ServiceID)
        {
            
            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServicesOptions.OptionID, ServicesOptions.OptionName, ServicesOptions.OptionPrice,
                             ServicesOptions.OptionValue, CafeServices.ServiceName
                             FROM CafeServices INNER JOIN
                             ServicesOptions ON CafeServices.ServiceID = ServicesOptions.ServiceID
						     WHERE ServicesOptions.ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

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

        public static long GetMaximumOptionValue()
        {

            long _MaxValue = 1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT TOP 1 OptionValue FROM ServicesOptions
                             ORDER BY OptionValue DESC";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int maxvalue))
                    _MaxValue = maxvalue;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _MaxValue;
        }

    }
}
