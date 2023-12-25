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

        }

        private cls_Key(int keyID, string key, string keyPassword, long keyPower, DateTime createdKeyDate, int byUserID)
        {
            this.KeyID = keyID;
            this.Key = key;
            this.KeyPassword = keyPassword;
            this.KeyPower = keyPower;
            this.CreatedKeyDate = createdKeyDate;
            this.ByUser = cls_ManagementAppUser.Find(byUserID);
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

        public bool AddNew()
        {

            this.KeyID = cls_Key_D.AddNew(this.Key, this.KeyPassword, this.KeyPower, this.CreatedKeyDate, this.ByUser.UserID);

            return this.KeyID > 0;

        }

        public bool ChangePermissions(long Permissions)
        {
            return cls_Key_D.ChangePermissions(this.KeyID, Permissions);
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
