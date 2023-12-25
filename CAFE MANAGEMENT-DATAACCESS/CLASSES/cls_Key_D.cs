using SpaceLibraries.Classes.Database;
using SpaceLibraries.Classes.Encryption;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_Key_D
    {

        public static bool IsExist(string Key)
        {

            bool isExist = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT [EXIST] = 'TRUE' FROM OperationsKeys WHERE [key] = @Key";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Key", Key);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                    isExist = true;


            }
            catch { }

            finally
            {
                Connection.Close();
            }

            return isExist;

        }

        public static bool Find(int KeyID, ref string Key, ref string KeyPassword, ref long KeyPower, ref DateTime CreatedKeyDate, ref int ByUserID)
        {

            bool isFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT KeyID, [Key], KeyPassword, KeyPowers, ByUser, CreatedKeyDate
                             FROM OperationsKeys
                             WHERE KeyID = @KeyID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@KeyID", KeyID);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    isFind = true;

                    Key = Reader["Key"].ToString();
                    KeyPassword = cls_Encryption.Decrypt(Reader["KeyPassword"].ToString().Trim());
                    KeyPower = Convert.ToInt64(Reader["KeyPowers"]);
                    ByUserID = Convert.ToInt32(Reader["ByUser"]);
                    CreatedKeyDate = Convert.ToDateTime(Reader["CreatedKeyDate"]);

                }

                Reader.Close();

            }
            catch { }

            finally
            {
                Connection.Close();
            }

            return isFind;

        }

        public static int AddNew(string Key, string KeyPassword, long KeyPower, DateTime CreatedKeyDate, int ByUserID)
        {

            KeyPassword = cls_Encryption.Encrypt(KeyPassword);

            int _InsertedKeyID = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"INSERT INTO OperationsKeys
                             ([Key], KeyPassword, KeyPowers, ByUser, CreatedKeyDate)
                             VALUES (@Key, @KeyPassword, @KeyPower, @ByUser, @CreatedKeyDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Key", Key);
            Command.Parameters.AddWithValue("@KeyPassword", KeyPassword);
            Command.Parameters.AddWithValue("@KeyPower", KeyPower);
            Command.Parameters.AddWithValue("@CreatedKeyDate", CreatedKeyDate);
            Command.Parameters.AddWithValue("@ByUser", ByUserID);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedkeyid))
                    _InsertedKeyID = insertedkeyid;
                
            }
            catch { }

            finally
            {
                Connection.Close();
            }

            return _InsertedKeyID;

        }

        public static bool ChangePermissions(int KeyID, long Permissions)
        {

            int _RowsAffected = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE OperationsKeys
                             SET KeyPowers = @KeyPermissions
                             WHERE KeyID = @KeyID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@KeyID", KeyID);
            Command.Parameters.AddWithValue("@KeyPermissions", Permissions);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    _RowsAffected = rowsaffected;


            }
            catch { }

            finally
            {
                Connection.Close();
            }

            return _RowsAffected > 0;

        }

        public static bool Delete(int KeyID)
        {

            int _RowsAffected = 0;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"DELETE FROM OperationsKeys WHERE KeyID = @KeyID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@KeyID", KeyID);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteNonQuery();

                if (Result != null && int.TryParse(Result.ToString(), out int rowsaffected))
                    _RowsAffected = rowsaffected;

            }

            catch { }

            finally
            {
                Connection.Close();
            }

            return _RowsAffected > 0;

        }

        public static DataTable GetKeys()
        {
            
            DataTable dt = new DataTable();

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT * FROM OperationsKeys";

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
