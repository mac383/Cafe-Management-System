using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System.Forms.Users.UsersEventsArgsClasses
{
    public class cls_ShowUserEventArgs : EventArgs
    {

        public enum EN_UserDepartment { Management = 1, Services = 2 }

        public int UserID { get; }
        public EN_UserDepartment UserDepartment { get; }

        public cls_ShowUserEventArgs(int userID, EN_UserDepartment userDepartment)
        {

            UserID = userID;
            UserDepartment = userDepartment;

        }

    }

}
