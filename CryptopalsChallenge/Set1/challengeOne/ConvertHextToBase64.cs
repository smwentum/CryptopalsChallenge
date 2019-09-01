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
                case "3":
                    binaryString = "0011";
                    break;
                case "4":
                    binaryString = "0100";
                    break;
                case "5":
                    binaryString = "0101";
                    break;
                case "6":
                    binaryString = "0110";
                    break;
                case "7":
                    binaryString = "0111";
                    break;
                case "8":
                    binaryString = "1000";
                    break;
                case "9":
                    binaryString = "1001";
                    break;
                case "A":
                    binaryString = "1010";
                    break;
                case "B":
                    binaryString = "1011";
                    break;
                case "C":
                    binaryString = "1100";
                    break;
                case "D":
                    binaryString = "1101";
                    break;
                default:
                    binaryString = "-1";
                    break;
            }

            return binaryString;
        }
    }
}
