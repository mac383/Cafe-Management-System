using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_ServicesAppUser_D
    {

        public static int GetCountOfUserReferences(int userID)
        {

            int count = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [COUNT] = 
	                         (SELECT COUNT(*) FROM InstalledServices WHERE ServiceAppUserID = @UserID)";

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

        public static bool Find(int userID, ref int personID)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT UserID, PersonID
                             FROM ServicesAppUsers WHERE UserID = @UserID";

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

                }

                Reader.Close();

            }

            catch { }
            finally { Connection.Close(); }

            return IsFind;

        }

        public static bool Find(string userName, ref int userID, ref int personID)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT ServicesAppUsers.UserID, ServicesAppUsers.PersonID
                             FROM ServicesAppUsers INNER JOIN
                             People ON ServicesAppUsers.PersonID = People.PersonID
				             WHERE UserName = @UserName";

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

                }

                Reader.Close();

            }

            catch { }
            finally { Connection.Close(); }

            return IsFind;

        }

        public static int AddUser(int personID)
        {

            int _InsertedID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO ServicesAppUsers
                             (PersonID)
                             VALUES (@PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", personID);

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

        public static bool DeleteUser(int userID)
        {

            int _RowsAffected = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE FROM ServicesAppUsers WHERE UserID = @UserID";

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
            string Query = @"SELECT UserID, People.PersonID, FirstName, SecondName, LastName, Gender, Address,
                             UserName, Password, DOB, IDNumber, Phone1, Phone2, PersonImage
                             FROM ServicesAppUsers INNER JOIN
                             People ON ServicesAppUsers.PersonID = People.PersonID";

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
