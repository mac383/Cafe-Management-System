using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_DATAACCESS.CLASSES
{
    public class cls_SystemInfo_D
    {

        public static bool GetSystemInfo(ref double ReservationPrice, ref int ReservationDuration, ref string Currency)
        {

            bool IsFind = false;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"SELECT TablesReservationPrice, DurationTableReservation, Currency
                             FROM SystemInfo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFind = true;
                    ReservationPrice = Convert.ToDouble(Reader["TablesReservationPrice"]);
                    ReservationDuration = Convert.ToInt16(Reader["DurationTableReservation"]);
                    Currency = Reader["Currency"].ToString().Trim();

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

        public static bool UpdateSystemInfo(double ReservationPrice, int ReservationDuration, string Currency)
        {

            int RowsAffected = -1;

            SqlConnection Connection = cls_Database.Connection();
            string Query = @"UPDATE SystemInfo
                             SET TablesReservationPrice = @ReservationPrice,
                             DurationTableReservation = @ReservationDuration,
                             Currency = @Currency";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ReservationPrice", ReservationPrice);
            Command.Parameters.AddWithValue("@ReservationDuration", ReservationDuration);
            Command.Parameters.AddWithValue("@Currency", Currency);

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

    }
}
