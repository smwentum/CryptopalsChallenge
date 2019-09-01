using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CrptopalsChallenge;
using CryptopalsChallenge.Set1.challengeOne;

namespace CrptopalsChallenge.Test
{
    public class Set1Challenge1
    {

        [Fact]
        public void zeroToBinary()
        {
            //Arrange
            string hexNum = "0";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0000", ans);
        }


        [Fact]
        public void oneToBinary()
        {
            //Arrange
            string hexNum = "1";
            //ACT
           string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0001", ans);
        }



    }
}
