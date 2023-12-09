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
    public class cls_ServicesDepartments_D
    {

        public static bool IsDepartmentReferences(int DepartmentID)
        {

            bool IsReferences = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ISREFERENCES = 'TRUE'
                             FROM CafeServices INNER JOIN
                             ServicesDepartments ON CafeServices.DepartmentID = ServicesDepartments.DepartmentID
                             WHERE ServicesDepartments.DepartmentID  = @DepartmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

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

        public static bool IsExist(string DepartmentName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ISEXIST = 'TRUE'  
                             FROM ServicesDepartments
                             WHERE DepartmentName = @DepartmentName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

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

        public static bool IsExist(int DepartmentId, string DepartmentName)
        {

            bool IsExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ISEXIST = 'TRUE'  
                             FROM ServicesDepartments
                             WHERE DepartmentName = @DepartmentName and DepartmentID != @DepartmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentId);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

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

        public static bool Find(int DepartmentID, ref string DepartmentName, ref string DepartmentImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT DepartmentName, DepartmentImage
                             FROM ServicesDepartments
                             WHERE DepartmentID = @DepartmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    DepartmentName = Reader["DepartmentName"].ToString();
                    DepartmentImage = Reader["DepartmentImage"].ToString();

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

        public static bool Find(string DepartmentName, ref int DepartmentID, ref string DepartmentImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT DepartmentID, DepartmentImage
                             FROM ServicesDepartments
                             WHERE DepartmentName = @DepartmentName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    DepartmentID = Convert.ToInt32(Reader["DepartmentID"]);
                    DepartmentImage = Reader["DepartmentImage"].ToString();

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

        public static bool Find(int ServiceID, ref int DepartmentID, ref string DepartmentName, ref string DepartmentImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServicesDepartments.DepartmentID,
                             ServicesDepartments.DepartmentName, ServicesDepartments.DepartmentImage
                             FROM CafeServices INNER JOIN
                             ServicesDepartments ON CafeServices.DepartmentID = ServicesDepartments.DepartmentID
				             WHERE CafeServices.ServiceID = @ServiceID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ServiceID", ServiceID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    DepartmentID = Convert.ToInt32(Reader["DepartmentID"]);
                    DepartmentName = Reader["DepartmentName"].ToString();
                    DepartmentImage = Reader["DepartmentImage"].ToString();

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

        public static bool Delete(string DepartmentName)
        {
            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE ServicesDepartments
                             WHERE DepartmentName = @DepartmentName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

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

        public static int AddDepartment(string DepartmentName, string DepartmentImage)
        {

            int _ID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO ServicesDepartments
                            (DepartmentName, DepartmentImage)
                             VALUES   (@DepartmentName, @DepartmentImage);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

            if (string.IsNullOrEmpty(DepartmentImage))
                Command.Parameters.AddWithValue("@DepartmentImage", DBNull.Value);

            else
                Command.Parameters.AddWithValue("@DepartmentImage", DepartmentImage);

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

        public static bool UpdateDepartment(int DepartmentID, string NewDepartmentName, string DepartmentImage)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE ServicesDepartments
                             SET DepartmentName = @DepartmentName, DepartmentImage = @DepartmentImage
                             WHERE DepartmentID = @DepartmentID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            Command.Parameters.AddWithValue("@DepartmentName", NewDepartmentName);

            if (string.IsNullOrEmpty(DepartmentImage))
                Command.Parameters.AddWithValue("@DepartmentImage", DBNull.Value);

            else
                Command.Parameters.AddWithValue("@DepartmentImage", DepartmentImage);

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

        public static int GetCountOfServicesForDepartments(string DepartmentName)
        {

            int Count = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [COUNT] = COUNT(CafeServices.DepartmentID)
                             FROM CafeServices INNER JOIN ServicesDepartments ON 
                             CafeServices.DepartmentID = ServicesDepartments.DepartmentID
                             GROUP BY ServicesDepartments.DepartmentName
                             HAVING DepartmentName = @DepartmentName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DepartmentName", DepartmentName);

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

        public static DataTable GetDepartments()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServicesDepartments.DepartmentID, ServicesDepartments.DepartmentName, ServicesDepartments.DepartmentImage,
                             COUNTOFSERVICES = (SELECT COUNT(CafeServices.ServiceID)
                             FROM CafeServices WHERE CafeServices.DepartmentID = 
                             ServicesDepartments.DepartmentID)
                             FROM ServicesDepartments";

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
