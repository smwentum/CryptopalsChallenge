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
                case "011010":
                    hexString = "a";
                    break;
                case "011011":
                    hexString = "b";
                    break;
                case "011100":
                    hexString = "c";
                    break;
                case "011101":
                    hexString = "d";
                    break;
                case "011110":
                    hexString = "e";
                    break;
                case "011111":
                    hexString = "f";
                    break;
                case "100000":
                    hexString = "g";
                    break;
                case "100001":
                    hexString = "h";
                    break;
                case "100010":
                    hexString = "i";
                    break;
                case "100011":
                    hexString = "j";
                    break;
                case "100100":
                    hexString = "k";
                    break;
                case "100101":
                    hexString = "l";
                    break;
                case "100110":
                    hexString = "m";
                    break;
                case "100111":
                    hexString = "n";
                    break;
                case "101000":
                    hexString = "o";
                    break;
                case "101001":
                    hexString = "p";
                    break;
                case "101010":
                    hexString = "q";
                    break;
                case "101011":
                    hexString = "r";
                    break;
                case "101100":
                    hexString = "s";
                    break;
                case "101101":
                    hexString = "t";
                    break;
                case "101110":
                    hexString = "u";
                    break;
                case "101111":
                    hexString = "v";
                    break;
                case "110000":
                    hexString = "w";
                    break;
                case "110001":
                    hexString = "x";
                    break;
                case "110010":
                    hexString = "y";
                    break;
                case "110011":
                    hexString = "z";
                    break;
                case "110100":
                    hexString = "0";
                    break;
                case "110101":
                    hexString = "1";
                    break;
                case "110110":
                    hexString = "2";
                    break;
                case "110111":
                    hexString = "3";
                    break;
                case "111000":
                    hexString = "4";
                    break;
                case "111001":
                    hexString = "5";
                    break;
                case "111010":
                    hexString = "6";
                    break;
                case "111011":
                    hexString = "7";
                    break;
                case "111100":
                    hexString = "8";
                    break;
                case "111101":
                    hexString = "9";
                    break;
                case "111110":
                    hexString = "+";
                    break;
                case "111111":
                    hexString = "/";
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
