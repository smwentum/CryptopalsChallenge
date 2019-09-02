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

        [Fact]
        public void sevenToBinary()
        {
            //Arrange
            string hexNum = "7";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("0111", ans);
        }

        [Fact]
        public void eightToBinary()
        {
            //Arrange
            string hexNum = "8";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1000", ans);
        }

        [Fact]
        public void nineToBinary()
        {
            //Arrange
            string hexNum = "9";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1001", ans);
        }

        [Fact]
        public void aToBinary()
        {
            //Arrange
            string hexNum = "A";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1010", ans);
        }

        [Fact]
        public void bToBinary()
        {
            //Arrange
            string hexNum = "B";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1011", ans);
        }


        [Fact]
        public void cToBinary()
        {
            //Arrange
            string hexNum = "C";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1100", ans);
        }

        [Fact]
        public void dToBinary()
        {
            //Arrange
            string hexNum = "D";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1101", ans);
        }

        [Fact]
        public void eToBinary()
        {
            //Arrange
            string hexNum = "E";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1110", ans);
        }

        [Fact]
        public void fToBinary()
        {
            //Arrange
            string hexNum = "F";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("1111", ans);
        }

        [Fact]
        public void gToBinary()
        {
            //Arrange
            string hexNum = "G";
            //ACT
            string ans = ConvertHextToBase64.convertHexToBinary(hexNum);
            //Assert
            Assert.Equal("-1", ans);
        }


    }
}
