using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_ManagementAppUser_D
    {

        public static int GetCountOfUserReferences(int userID)
        {
            
            int count = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [COUNT] = 
	                         (SELECT COUNT(*) FROM AccountingRequests WHERE AccountingRequests.ByUser = @UserID)
	                         	+
	                         (SELECT COUNT(*) FROM OperationsKeys WHERE OperationsKeys.ByUser = @UserID)";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", userID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int result))
                    count = result;

            }

            catch { }

            finally { Connection.Close(); }

            return count;

        }

        public static bool Find(int userID, ref int personID, ref long permissions)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT UserID, PersonID, Permissions FROM ManagementAppUsers 
                             WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", userID);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    personID = Convert.ToInt32(Reader["PersonID"]);
                    permissions = Convert.ToInt64(Reader["Permissions"]);

                }

                Reader.Close();

            }

            catch { }
            finally { Connection.Close(); }

            return IsFind;

        }

        public static bool Find(string userName, ref int userID, ref int personID, ref long permissions)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ManagementAppUsers.UserID, ManagementAppUsers.PersonID, ManagementAppUsers.Permissions
                             FROM ManagementAppUsers INNER JOIN
                             People ON ManagementAppUsers.PersonID = People.PersonID
						     WHERE People.UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", userName);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    userID = Convert.ToInt32(Reader["UserID"]);
                    personID = Convert.ToInt32(Reader["PersonID"]);
                    permissions = Convert.ToInt64(Reader["Permissions"]);

                }

                Reader.Close();

            }

            catch { }
            finally { Connection.Close(); }

            return IsFind;

        }

        public static int AddUser(int personID, long Permissions)
        {

            int _InsertedID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO ManagementAppUsers
                             (PersonID, Permissions)
                             VALUES (@PersonID, @Permissions);
                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", personID);
            Command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int result))
                    _InsertedID = result;

            }

            catch { }
            finally { Connection.Close(); }

            return _InsertedID;

        }

        public static bool UpdateUser(int userID, long Permissions)
        {

            int _RowsAffected = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE ManagementAppUsers
                             SET Permissions = @Permissions
                             WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", userID);
            Command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    _RowsAffected = rowsaffected;

            }

            catch { }
            finally { Connection.Close(); }

            return _RowsAffected > 0;

        }

        public static bool DeleteUser(int userID)
        {

            int _RowsAffected = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE FROM ManagementAppUsers WHERE UserID = @UserID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", userID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    _RowsAffected = rowsaffected;

            }
            catch { }
            finally { Connection.Close(); }

            return _RowsAffected > 0;

        }

        public static DataTable GetUsers()
        {

            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT UserID, Permissions, PersonID, FirstName, SecondName, LastName, Gender, Address, UserName, Password, DOB, 
                             IDNumber, Phone1, Phone2, PersonImage
                             FROM ManagementAppUsers INNER JOIN
                             People ON ManagementAppUsers.PersonID = People.PersonID";

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
            finally { Connection.Close(); }

            return dt;

        }

    }
}
