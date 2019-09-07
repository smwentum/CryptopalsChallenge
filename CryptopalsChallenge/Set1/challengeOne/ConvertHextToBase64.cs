using System;
using System.Collections.Generic;
using System.Text;

namespace CryptopalsChallenge.Set1.challengeOne
{
    public class ConvertHextToBase64
    {
        /// <summary>
        /// this should be only one letter at time
        /// </summary>
        /// <param name="hexString">the hexadecimal digit you want to convert to binary</param>
        /// <returns>the four digit binary code or -1 if it isn't a hexadecimal digit</returns>
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
                case "E":
                    binaryString = "1110";
                    break;
                case "F":
                    binaryString = "1111";
                    break;
                default:
                    binaryString = "-1";
                    break;
            }

            return binaryString;
        }
        /// <summary>
        /// converts six binary digits to a base 64 digit
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns>string "-1" if can't be converted otherwise the base 64 digit</returns>
        public static string convertBinaryToBase64(string binaryString)
        {
            string hexString = "";
            switch (hexString)
            {


                case "000000":
                    hexString = "A";
                    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                //case "000000":
                //    hexString = "A";
                //    break;
                default:
                    hexString = "-1";
                    break;
            }
            return hexString;
        }
    }
}
