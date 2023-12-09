using CAFE_MANAGEMENT_DATAACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAFE_MANAGEMENT_DATAACCESS;
using System.Data;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Tables
    {

        enum EN_Mode { AddNew =  0, Update = 1 }
        EN_Mode _Mode; 

        public int TableID { set; get; }
        public string TableName { set; get; }
        public string TablePassword { set; get; }
        private string _NewPassword;

        public enum EN_TableStatus
        {
            NotReservation = 0,
            Reservation = 1
        }

        public EN_TableStatus TableStatus;

        public cls_Tables()
        {
            
            TableID = -1;
            TableName = "";
            TablePassword = "";
            TableStatus = EN_TableStatus.NotReservation;
            _Mode = EN_Mode.AddNew;

        }

        public cls_Tables(int TableID, string TableName, string TablePassword, bool TableStatus)
        {

            this.TableID = TableID;
            this.TableName = TableName;
            this.TablePassword = TablePassword;
            this.TableStatus = (TableStatus) ? EN_TableStatus.Reservation : EN_TableStatus.NotReservation;

            _Mode = EN_Mode.Update;

        }

        public cls_Tables(int TableID, string TableName, string OldPassword, string NewPassword, bool TableStatus = false)
        {

            this.TableID = TableID;
            this.TableName = TableName;
            this.TablePassword = OldPassword;
            this._NewPassword = NewPassword;

            this.TableStatus = (TableStatus) ? EN_TableStatus.Reservation : EN_TableStatus.NotReservation;

            _Mode = EN_Mode.Update;

        }

        public static bool IsExist(int TableID)
        {
            return cls_Tables_D.IsTableExists(TableID);
        }

        public static bool IsExist(string TableName)
        {
            return cls_Tables_D.IsTableExists(TableName);
        }

        public static bool IsTableExistsWithoutThisTable(int TableID, string TableName)
        {
            return cls_Tables_D.IsTableExistsWithoutThisTable(TableID, TableName);
        }

        public bool IsTableReferences()
        {
            return cls_Tables_D.IsTableReferences(TableID);
        }

        public static cls_Tables Find(string TableName)
        {

            int tableId = -1;
            string tablepassword = string.Empty;
            bool tablestatus = false;

            if (cls_Tables_D.FindTable(ref tableId, TableName, ref tablepassword, ref tablestatus))
                return new cls_Tables(tableId, TableName, tablepassword, tablestatus);

            return null;

        }

        public static cls_Tables Find(int TableID)
        {

            string tablename = "";
            string tablepassword = string.Empty;
            bool tablestatus = false;

            if (cls_Tables_D.FindTable(TableID, ref tablename, ref tablepassword, ref tablestatus))
                return new cls_Tables(TableID, tablename, tablepassword, tablestatus);

            return null;

        }

        public static cls_Tables FindTableByReservation(int ReservationID)
        {

            int tableID = -1;
            string tableName = "";
            string tablePassword = string.Empty;
            bool tableStatus = false;

            if (cls_Tables_D.FindTableByReservation(ReservationID, ref tableID, ref tableName, ref tablePassword, ref tableStatus))
                return new cls_Tables(tableID, tableName, tablePassword, tableStatus);

            return null;

        }

        public static DataTable GetTable()
        {
            return cls_Tables_D.GetTables();
        }

        private bool _AddTable()
        {
            this.TableID = cls_Tables_D.AddTable(this.TableName, this.TablePassword);
            this.TableStatus = EN_TableStatus.NotReservation;

            return this.TableID > 0;
        }

        private bool _UpdateTable()
        {
            return cls_Tables_D.UpdateTable(TableID, TableName, _NewPassword, TablePassword);
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (_AddTable())
                    {
                        _Mode = EN_Mode.Update;
                        return true;
                    }
                    break;

                case EN_Mode.Update:
                    if (_UpdateTable())
                        return true;

                    break;

            }

            return false;

        }

        public bool DeleteTable( string TablePassword)
        {
            return cls_Tables_D.DeleteTable(TableID, TablePassword);
        }

        public bool ChangeTableStatus()
        {
            return cls_Tables_D.ChangeTableStatus(TableID, !Convert.ToBoolean(TableStatus));
        }

    }
}
