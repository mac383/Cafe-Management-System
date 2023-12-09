using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES
{
    public class cls_util
    {

        static Random RandomNumber = new Random();
        public static string GetRandomKey(byte KeyLength)
        {

            string _Key = "";

            for (int i = 0; i < KeyLength; i++)
                _Key += (char)RandomNumber.Next(0, 9);

            return _Key;

        }

    }
}
