using System;
using System.Collections.Generic;
using System.Text;

namespace CryptopalsChallenge.Set1.challengeOne
{
    public class FixedXOR
    {
        public static string fixedXor(string one, string two)
        {
            string ans = "";
            string binaryOne = "";
            string binaryTwo = "";
          
            //get the two binary strings
            binaryOne =  Utility.convertHexStringToBinaryString(one);
            binaryTwo = Utility.convertHexStringToBinaryString(two);
            
            //xor them together
            if (binaryOne.Length == binaryTwo.Length)
            {
                for (int i = 0; i < binaryOne.Length; i++)
                {
                    ans += binaryOne[i] == binaryTwo[i] ? "0" : "1";
                }
            }

            ans = Utility.convertBinaryStringToHexString(ans);

        
            return ans;
        }
    }
}
