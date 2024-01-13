using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Key
    {

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        public int KeyID { set; get; }
        public string Key { set; get; }
        public string KeyPassword { set; get; }
        public long KeyPower { set; get; }
        public DateTime CreatedKeyDate { set; get; }
        public cls_ManagementAppUser ByUser { set; get; }

        public cls_Key()
        {

            this.KeyID = -1;
            this.Key = string.Empty;
            this.KeyPassword = string.Empty;
            this.KeyPower = 0;
            this.CreatedKeyDate = DateTime.MinValue;
            this.ByUser = null;

            _Mode = EN_Mode.addnew;

        }

        public cls_Key(string key, long NewPower)
        {

            cls_Key _Key = cls_Key.Find(key);

            if (_Key == null)
                return;

            this.KeyID = _Key.KeyID;
            this.Key = _Key.Key;
            this.KeyPassword = _Key.KeyPassword;
            this.KeyPower = NewPower;
            this.CreatedKeyDate = _Key.CreatedKeyDate;
            this.ByUser = cls_ManagementAppUser.Find(_Key.ByUser.UserID);

            this._Mode = EN_Mode.update;

        }

        private cls_Key(int keyID, string key, string keyPassword, long keyPower, DateTime createdKeyDate, int byUserID)
        {

            this.KeyID = keyID;
            this.Key = key;
            this.KeyPassword = keyPassword;
            this.KeyPower = keyPower;
            this.CreatedKeyDate = createdKeyDate;
            this.ByUser = cls_ManagementAppUser.Find(byUserID);

            this._Mode = EN_Mode.update;

        }

        public static bool IsExist(string key)
        {
            return cls_Key_D.IsExist(key);
        }

        public static cls_Key Find(int KeyID)
        {

            string key = "";
            string keypassword = "";
            long keypower = 0;
            DateTime createdkeydate = DateTime.MinValue;
            int byuserid = -1;

            if (cls_Key_D.Find(KeyID, ref key, ref keypassword, ref keypower, ref createdkeydate, ref byuserid))
                return new cls_Key(KeyID, key, keypassword, keypower, createdkeydate, byuserid);

            return null;

        }

        public static cls_Key Find(string Key)
        {

            int keyid = -1;
            string keypassword = "";
            long keypower = 0;
            DateTime createdkeydate = DateTime.MinValue;
            int byuserid = -1;

            if (cls_Key_D.Find(ref keyid, Key, ref keypassword, ref keypower, ref createdkeydate, ref byuserid))
                return new cls_Key(keyid, Key, keypassword, keypower, createdkeydate, byuserid);

            return null;

        }

        private bool _AddNew()
        {

            this.KeyID = cls_Key_D.AddNew(this.Key, this.KeyPassword, this.KeyPower, this.CreatedKeyDate, this.ByUser.UserID);

            return this.KeyID > 0;

        }

        private bool _ChangePermissions()
        {
            return cls_Key_D.ChangePermissions(this.KeyID, this.KeyPower);
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.addnew:
                    if (_AddNew())
                    {
                        _Mode = EN_Mode.update;
                        return true;
                    }
                    break;

                case EN_Mode.update:
                    return _ChangePermissions();

            }

            return false;

        }

        public static bool Delete(int KeyID)
        {
            return cls_Key_D.Delete(KeyID);
        }

        public static DataTable GetKeys()
        {
            return cls_Key_D.GetKeys();
        }

    }
}
