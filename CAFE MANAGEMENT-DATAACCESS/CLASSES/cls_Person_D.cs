using SpaceLibraries.Classes.Database;
using SpaceLibraries.Classes.Encryption;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_Person_D
    {

        public static bool IsExist(string UserName)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static bool IsExist(int PersonID, string UserName)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE PersonID != @PersonID AND UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static bool IsPersonExistByIDNumber(string IDNumber)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE IDNumber = @IDNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@IDNumber", IDNumber);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static bool IsPersonExistByIDNumber(int PersonID, string IDNumber)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE PersonID != @PersonID AND IDNumber = @IDNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@IDNumber", IDNumber);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static bool IsPersonExistByPhone(string Phone)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE Phone1 = @Phone OR Phone2 = @Phone";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Phone", Phone);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static bool IsPersonExistByPhone(int PersonID, string Phone)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT EXIST = 'TRUE' FROM People WHERE PersonID != @PersonID AND Phone1 = @Phone OR Phone2 = @Phone";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@Phone", Phone);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                isExist = (Result != null) ? true : false;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return isExist;

        }

        public static int GetCountOfPersonReferences(int PersonID)
        {

            int countOfReferences = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"
                             SELECT [COUNT] = 
                             (
                             	 SELECT COUNT(*) FROM ManagementAppUsers WHERE PersonID = @PersonID
                             )
                             	 +
                             (
                             	 SELECT COUNT(*) FROM ServicesAppUsers WHERE PersonID = @PersonID
                             )";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int result))
                    countOfReferences = result;

            }

            catch { }

            finally
            {
                Connection.Close();
            }


            return countOfReferences;

        }

        public static bool Find(int PersonID, ref string FirstName, ref string SecondName, ref string LastName,
            ref bool Gender, ref string Address, ref string UserName, ref string Password, ref DateTime DOB,
            ref string IDNumber, ref string Phone1, ref string Phone2, ref string PersonImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT PersonID, FirstName, SecondName, LastName, Gender, Address, UserName, Password,
                             DOB, IDNumber, Phone1, Phone2, PersonImage
                             FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    FirstName = Reader["FirstName"].ToString().Trim();
                    SecondName = Reader["SecondName"].ToString().Trim();
                    LastName = Reader["LastName"].ToString().Trim();
                    Gender = Convert.ToBoolean(Reader["Gender"]);
                    Address = Reader["Address"].ToString().Trim();
                    UserName = Reader["UserName"].ToString().Trim();
                    Password = cls_Encryption.Decrypt(Reader["Password"].ToString().Trim());
                    DOB = Convert.ToDateTime(Reader["DOB"]);
                    IDNumber = Reader["IDNumber"].ToString().Trim();
                    Phone1 = Reader["Phone1"].ToString().Trim();
                    Phone2 = Reader["Phone2"].ToString().Trim();
                    PersonImage = Reader["PersonImage"].ToString().Trim();

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

        public static bool Find(string UserName, ref int PersonID, ref string FirstName, ref string SecondName,
            ref string LastName, ref bool Gender, ref string Address, ref string Password, ref DateTime DOB,
            ref string IDNumber, ref string Phone1, ref string Phone2, ref string PersonImage)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT PersonID, FirstName, SecondName, LastName, Gender, Address, UserName, Password,
                             DOB, IDNumber, Phone1, Phone2, PersonImage
                             FROM People WHERE UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;

                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    FirstName = Reader["FirstName"].ToString().Trim();
                    SecondName = Reader["SecondName"].ToString().Trim();
                    LastName = Reader["LastName"].ToString().Trim();
                    Gender = Convert.ToBoolean(Reader["Gender"]);
                    Address = Reader["Address"].ToString().Trim();
                    Password = cls_Encryption.Decrypt(Reader["Password"].ToString().Trim());
                    DOB = Convert.ToDateTime(Reader["DOB"]);
                    IDNumber = Reader["IDNumber"].ToString().Trim();
                    Phone1 = Reader["Phone1"].ToString().Trim();
                    Phone2 = Reader["Phone2"].ToString().Trim();
                    PersonImage = Reader["PersonImage"].ToString().Trim();

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

        public static int AddPerson(string firstName, string secondName,
            string lastName, bool gender, string address, string userName, string password,
            Nullable<DateTime> dob, string idNumber, string phone1, string phone2, string personImage)
        {

            password = cls_Encryption.Encrypt(password);

            int insertedID = -1;
            SqlConnection Connection = cls_Database.Connection();

            string Query = @"INSERT INTO People
                         (FirstName, SecondName, LastName, Gender, Address, UserName,
                         Password, DOB, IDNumber, Phone1, Phone2, PersonImage)
                         VALUES       (@FirstName, @SecondName, @LastName, @Gender, @Address, @UserName, @Password,
                         @DOB, @IDNumber, @Phone1, @Phone2, @PersonImage);
                         SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", firstName);
            Command.Parameters.AddWithValue("@SecondName", secondName);

            if (string.IsNullOrEmpty(lastName))
                Command.Parameters.AddWithValue("@LastName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@LastName", lastName);

            Command.Parameters.AddWithValue("@Gender", gender);
            Command.Parameters.AddWithValue("@Address", address);
            Command.Parameters.AddWithValue("@UserName", userName);
            Command.Parameters.AddWithValue("@Password", password);
            Command.Parameters.AddWithValue("@DOB", dob);

            if (string.IsNullOrEmpty(idNumber))
                Command.Parameters.AddWithValue("@IDNumber", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@IDNumber", idNumber);

            Command.Parameters.AddWithValue("@Phone1", phone1);

            if (string.IsNullOrEmpty(phone2))
                Command.Parameters.AddWithValue("@Phone2", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Phone2", phone2);

            if (string.IsNullOrEmpty(personImage))
                Command.Parameters.AddWithValue("@PersonImage", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@PersonImage", personImage);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int id))
                    insertedID = id;

            }

            catch { }
            finally
            {
                Connection.Close();
            }


            return insertedID;

        }

        public static bool UpdatePerson(int personID, string firstName, string secondName,
            string lastName, bool gender, string address, string userName,
            Nullable<DateTime> dob, string idNumber, string phone1, string phone2, string personImage)
        {

            int rowsAffected = -1;
            SqlConnection Connection = cls_Database.Connection();

            string Query = @"UPDATE People
                             SET FirstName = @FirstName, SecondName = @SecondName, LastName = @LastName, Gender = @Gender,
                             Address = @Address, UserName = @UserName, DOB = @DOB, IDNumber = @IDNumber,
                             Phone1 = @Phone1, Phone2 = @Phone2, PersonImage = @PersonImage
                             WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", personID);
            Command.Parameters.AddWithValue("@FirstName", firstName);
            Command.Parameters.AddWithValue("@SecondName", secondName);

            if (string.IsNullOrEmpty(lastName))
                Command.Parameters.AddWithValue("@LastName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@LastName", lastName);

            Command.Parameters.AddWithValue("@Gender", gender);
            Command.Parameters.AddWithValue("@Address", address);
            Command.Parameters.AddWithValue("@UserName", userName);
            Command.Parameters.AddWithValue("@DOB", dob);

            if (string.IsNullOrEmpty(idNumber))
                Command.Parameters.AddWithValue("@IDNumber", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@IDNumber", idNumber);

            Command.Parameters.AddWithValue("@Phone1", phone1);

            if (string.IsNullOrEmpty(phone2))
                Command.Parameters.AddWithValue("@Phone2", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Phone2", phone2);

            if (string.IsNullOrEmpty(personImage))
                Command.Parameters.AddWithValue("@PersonImage", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@PersonImage", personImage);

            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int result))
                    rowsAffected = result;

            }

            catch { }
            finally
            {
                Connection.Close();
            }


            return rowsAffected > 0;

        }

        public static bool Delete(int PersonID)
        {
            
            int rowsAffected = -1;
            SqlConnection Connection = cls_Database.Connection();

            string Query = @"DELETE FROM People WHERE PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            
            try
            {

                Connection.Open();
                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    rowsAffected = rowsaffected;

            }
            catch { }

            finally
            {
                Connection.Close();
            }

            return rowsAffected > 0;

        }

    }
}
