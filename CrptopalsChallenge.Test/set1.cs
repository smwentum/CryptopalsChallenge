using CryptopalsChallenge.Set1.challengeOne;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CrptopalsChallenge.Test
{
    public class set1
    {
        [Fact]
        public static void thirtyToBase64()
        {
            //Arrange
            string hexNum = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            //ACT
            string ans = convertHToB64.convertHexToB64(hexNum);
            //Assert
            Assert.Equal("SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t", ans);
        }
    }
}
