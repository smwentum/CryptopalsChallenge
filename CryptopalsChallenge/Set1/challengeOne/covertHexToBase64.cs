using System;
using System.Collections.Generic;
using System.Text;

namespace CryptopalsChallenge.Set1.challengeOne
{
    public class convertHToB64
    {
        public static string convertHexToB64(string hexString)
        {
            string ans = "";
            string binaryAns = "";
            foreach (char h in hexString)
            {
                binaryAns += Utility.convertHexCharToBinary(h.ToString());
            }
            while (  0 < binaryAns.Length)
            {
                ans += Utility.convertBinaryToBase64(binaryAns.Substring(0,6));
                binaryAns = binaryAns.Substring(6);
            }

            return ans; 
        }
    }
}
