using System;
using System.Collections.Generic;
using System.Text;

namespace CryptopalsChallenge.Set1.challengeOne
{
    public class ConvertHextToBase64
    {
        public static string convertHexToBinary(string hexString)
        {
            string binaryString = "";

            switch (hexString)
            {
                case "0":
                    binaryString = "0000";
                    break;
                case "1":
                    binaryString = "0001";
                    break;
                case "2":
                    binaryString = "0010";
                    break;
                default:
                    binaryString = "-1";
                    break;
            }

            return binaryString;
        }
    }
}
