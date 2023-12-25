using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.GLOBAL_CLASSES
{
    public class cls_util
    {

        public enum EN_KeyType { Numbers = 0, SmallLetters = 1, CapitalLetters = 2 }
        
        static Random RandomNumber = new Random();

        private static char _GetDigit(EN_KeyType KeyType)
        {

            switch (KeyType)
            {

                case EN_KeyType.Numbers:
                    return (char)RandomNumber.Next(0, 9);

                case EN_KeyType.SmallLetters:
                    return (char)RandomNumber.Next('a', 'z');

                case EN_KeyType.CapitalLetters:
                    return (char)RandomNumber.Next('A', 'Z');

            }

            return '?';

        }

        private static string _GetRandomWord(byte NumberOfDigits,  EN_KeyType KeyType)
        {

            string _Word = "";

            for (byte i = 0; i < NumberOfDigits; i++)
                _Word += _GetDigit(KeyType);

            return _Word;

        }

        public static string GetRandomKey(byte NumberOfKeyWords, byte NumberOfWordDigits,  EN_KeyType KeyType)
        {

            string _Key = "";

            for (byte i = 1; i <= NumberOfKeyWords; i++)
                _Key += _GetRandomWord(NumberOfWordDigits, KeyType) + '-';

            return _Key.Substring(0, _Key.Length - 1);

        }

        public static string GetRandomKey_Numbers(byte KeyLength)
        {

            string _Key = "";

            for (int i = 0; i < KeyLength; i++)
                _Key += (char)RandomNumber.Next(0, 9);

            return _Key;

        }



    }
}
