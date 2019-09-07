﻿using System;
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
            switch (binaryString)
            {


                case "000000":
                    hexString = "A";
                    break;
                case "000001":
                    hexString = "B";
                    break;
                case "000010":
                    hexString = "C";
                    break;
                case "000011":
                    hexString = "D";
                    break;
                case "000100":
                    hexString = "E";
                    break;
                case "000101":
                    hexString = "F";
                    break;
                case "000110":
                    hexString = "G";
                    break;
                case "000111":
                    hexString = "H";
                    break;
                case "001000":
                    hexString = "I";
                    break;
                case "001001":
                    hexString = "J";
                    break;
                case "001010":
                    hexString = "K";
                    break;
                case "001011":
                    hexString = "L";
                    break;
                case "001100":
                    hexString = "M";
                    break;
                case "001101":
                    hexString = "N";
                    break;
                case "001110":
                    hexString = "O";
                    break;
                case "001111":
                    hexString = "P";
                    break;
                case "010000":
                    hexString = "Q";
                    break;
                case "010001":
                    hexString = "R";
                    break;
                case "010010":
                    hexString = "S";
                    break;
                case "010011":
                    hexString = "T";
                    break;
                case "010100":
                    hexString = "U";
                    break;
                case "010101":
                    hexString = "V";
                    break;
                case "010110":
                    hexString = "W";
                    break;
                case "010111":
                    hexString = "X";
                    break;
                case "011000":
                    hexString = "Y";
                    break;
                case "011001":
                    hexString = "Z";
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
                default:
                    hexString = "-1";
                    break;
            }
            return hexString;
        }
    }
}
