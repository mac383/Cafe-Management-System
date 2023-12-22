using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cafe_Management_System.GLOBAL_CLASSES
{
    public class cls_Validation
    {

        public static bool ValidationText(string Text, int minLength = 0, int maxLength = 100)
        {

            Regex regex = new Regex("^[a-zA-Zا-ي]*$");

            return (regex.IsMatch(Text) && Text.Length >= minLength && Text.Length <= maxLength);

        }

        public static bool ValidationUserName(string UserName, int minLength = 0, int maxLength = 100)
        {

            Regex regex = new Regex("^(_?[a-zA-Z]*[0-9]*)*$");

            return (regex.IsMatch(UserName) && UserName.Length >= minLength && UserName.Length <= maxLength);

        }

        public static bool ValidationEmail(string Email, int minLength = 0, int maxLength = 100)
        {

            Regex regex = new Regex("^(_*[a-zA-Z]*[0-9]*)*[@][a-zA-Z]+[.][a-zA-Z]+$");

            return (regex.IsMatch(Email) && Email.Length >= minLength && Email.Length <= maxLength);

        }

        public static bool ValidationInt(string Number, int SmallestNumber = 0, int BiggestNumber = 1000000)
        {

            Regex regex = new Regex("^-?[0-9]+$");

            return regex.IsMatch(Number) && Convert.ToInt32(Number) >= SmallestNumber && Convert.ToInt32(Number) <= BiggestNumber;

        }

        public static bool ValidationFloat(string Number, double SmallestNumber = 0, double BiggestNumber = 1000000)
        {

            Regex regex = new Regex("^-?[0-9]+([.][0-9]+)?$");

            return regex.IsMatch(Number) && Convert.ToDouble(Number) >= SmallestNumber && Convert.ToDouble(Number) <= BiggestNumber;

        }

    }
}
