using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_ManagementAppUser
    {

        public int UserID { set; get; }
        public string UserName { set; get; }

        public cls_ManagementAppUser()
        {

        }

        public static cls_ManagementAppUser Find(int UserID)
        {
            return null;
        }

    }
}
