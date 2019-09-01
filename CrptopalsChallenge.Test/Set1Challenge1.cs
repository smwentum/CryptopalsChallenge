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

        [Fact]
        public void twoToBinary()
        {
            //Arrange
            string hexNum = "2";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0010", ans);
        }

        [Fact]
        public void threeToBinary()
        {
            //Arrange
            string hexNum = "3";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0011", ans);
        }

        [Fact]
        public void fourToBinary()
        {
            //Arrange
            string hexNum = "4";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0100", ans);
        }

        [Fact]
        public void fiveToBinary()
        {
            //Arrange
            string hexNum = "5";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0101", ans);
        }

        [Fact]
        public void sixToBinary()
        {
            //Arrange
            string hexNum = "6";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0110", ans);
        }

    }
}
