using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceLibraries.Classes.Encryption
{
    public class cls_Encryption
    {

        private static int Key = 10;

        public static string Encrypt(string PlainText)
        {

            string _CypherText = "";

            for (int i = 0; i < PlainText.Length; i++)
                _CypherText += Convert.ToChar((int)PlainText[i] + Key);

            return _CypherText;

        }

        public static string Decrypt(string CypherText)
        {

            string _PlainText = "";

            for (int i = 0; i < CypherText.Length; i++)
                _PlainText += Convert.ToChar((int)CypherText[i] - Key);

            return _PlainText;

        }

    }
}
