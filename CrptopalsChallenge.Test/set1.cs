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
        public static void challengeOne()
        {
            //Arrange
            string hexNum = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            //ACT
            string ans = convertHToB64.convertHexToB64(hexNum);
            //Assert
            Assert.Equal("SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t", ans);
        }

        [Fact]
        public static void challengeTwo()
        {
            //Arrange
            string hexStringOne = "1c0111001f010100061a024b53535009181c";
            string hexStringTwo = "686974207468652062756c6c277320657965";

            //ACT
            string ans = FixedXOR.fixedXor(hexStringOne,hexStringTwo).ToLower();
            //Assert
            Assert.Equal("746865206b696420646f6e277420706c6179", ans);
        }
    }
}
