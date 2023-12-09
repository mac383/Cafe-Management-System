using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_Services_D
    {

        public static bool IsExist(string ServiceName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM CafeServices WHERE ServiceName = @ServiceName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceName", ServiceName);

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

        public static bool IsExist(int ServiceID, string ServiceName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE'
                             FROM CafeServices WHERE ServiceName = @ServiceName AND ServiceID != @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);
            Command.Parameters.AddWithValue("@ServiceName", ServiceName);

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

        public static bool IsServiceReferences(int ServiceID)
        {

            bool IsReferences = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [REFERENCES] = 'TRUE'
                             FROM CafeServices INNER JOIN
                             ServicesOptions ON CafeServices.ServiceID = ServicesOptions.ServiceID
				             WHERE CafeServices.ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                    IsReferences = true;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return IsReferences;

        }

        public static bool Find(int ServiceID, ref string ServiceName, ref string ServiceDescription,
            ref string ServiceImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServiceID, ServiceName, ServiceDescription, ServiceImage
                             FROM CafeServices
                             WHERE ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ServiceName = Reader["ServiceName"].ToString();
                    ServiceDescription = Reader["ServiceDescription"].ToString();
                    ServiceImage = Reader["ServiceImage"].ToString();

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

        public static bool Find(ref int ServiceID, string ServiceName, ref string ServiceDescription,
            ref string ServiceImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServiceID, ServiceName, ServiceDescription, ServiceImage
                             FROM CafeServices
                             WHERE ServiceName = @ServiceName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceName", ServiceName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ServiceID = Convert.ToInt32(Reader["ServiceID"]);
                    ServiceDescription = Reader["ServiceDescription"].ToString();
                    ServiceImage = Reader["ServiceImage"].ToString();

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

        public static bool FindByOptionID(int OptionID, ref int ServiceID, ref string ServiceName, ref string ServiceDescription,
            ref string ServiceImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT CafeServices.ServiceID, CafeServices.ServiceName, CafeServices.ServiceDescription,
                             CafeServices.ServiceImage FROM CafeServices INNER JOIN
                             ServicesOptions ON CafeServices.ServiceID = ServicesOptions.ServiceID
						     WHERE ServicesOptions.OptionID = @OptionID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@OptionID", OptionID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ServiceID = Convert.ToInt32(Reader["ServiceID"]);
                    ServiceName = Reader["ServiceName"].ToString();
                    ServiceDescription = Reader["ServiceDescription"].ToString();
                    ServiceImage = Reader["ServiceImage"].ToString();

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

        public static bool Delete(int ServiceID)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE CafeServices
                             WHERE ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
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

        public static int AddService(string ServiceName, string ServiceDescription,
            int DepartmentID, string ServiceImage)
        {

            int _ID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO CafeServices
                             (ServiceName, ServiceDescription, DepartmentID, ServiceImage)
                             VALUES (@ServiceName, @ServiceDescription, @DepartmentID, @ServiceImage);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceName", ServiceName);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            if (string.IsNullOrEmpty(ServiceImage))
                Command.Parameters.AddWithValue("@ServiceImage", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ServiceImage", ServiceImage);

            if (string.IsNullOrEmpty(ServiceDescription))
                Command.Parameters.AddWithValue("@ServiceDescription", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);

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

        public static bool UpdateService(int ServiceID, string ServiceName, string ServiceDescription,
            int DepartmentID, string ServiceImage)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE   CafeServices
                             SET ServiceName = @ServiceName, ServiceDescription = @ServiceDescription,
                             DepartmentID = @DepartmentID, ServiceImage = @ServiceImage
                             WHERE ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);
            Command.Parameters.AddWithValue("@ServiceName", ServiceName);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            if (string.IsNullOrEmpty(ServiceImage))
                Command.Parameters.AddWithValue("@ServiceImage", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ServiceImage", ServiceImage);

            if (string.IsNullOrEmpty(ServiceDescription))
                Command.Parameters.AddWithValue("@ServiceDescription", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ServiceDescription", ServiceDescription);

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

        public static int GetCountOfOptionsForService(int ServiceID)
        {

            int Count = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [COUNT] = COUNT(OptionID)
                             FROM ServicesOptions INNER JOIN CafeServices ON 
                             ServicesOptions.ServiceID = CafeServices.ServiceID
                             GROUP BY CafeServices.ServiceID
                             HAVING CafeServices.ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int count))
                    Count = count;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return Count;

        }

        public static DataTable GetServices()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT CafeServices.ServiceID, CafeServices.ServiceName,
                             CafeServices.ServiceDescription,
                             CafeServices.ServiceImage, ServicesDepartments.DepartmentName, COUNTOFOPTIONS =
                             (
                                  SELECT [COUNT] = COUNT(ServicesOptions.OptionID) FROM ServicesOptions WHERE
                                  CafeServices.ServiceID = ServicesOptions.ServiceID
                             )
                             FROM CafeServices INNER JOIN ServicesDepartments ON
                             CafeServices.DepartmentID = ServicesDepartments.DepartmentID";

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
