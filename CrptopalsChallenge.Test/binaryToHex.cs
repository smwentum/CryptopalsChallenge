using CryptopalsChallenge.Set1.challengeOne;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CrptopalsChallenge.Test
{
    
    public class binaryToHex
    {
        [Fact]
        public void zeroToHex()
        {
            //Arrange
            string hexNum = "0000";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("0", ans);
        }


        [Fact]
        public void oneToHex()
        {
            //Arrange
            string hexNum = "0001";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("1", ans);
        }

        [Fact]
        public void twoToHex()
        {
            //Arrange
            string hexNum = "0010";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("2", ans);
        }

        [Fact]
        public void threeToHex()
        {
            //Arrange
            string hexNum = "0011";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("3", ans);
        }

        [Fact]
        public void fourToHex()
        {
            //Arrange
            string hexNum = "0100";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("4", ans);
        }

        [Fact]
        public void fiveToHex()
        {
            //Arrange
            string hexNum = "0101";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("5", ans);
        }

        [Fact]
        public void sixToHex()
        {
            //Arrange
            string hexNum = "0110";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("6", ans);
        }

        [Fact]
        public void sevenToHex()
        {
            //Arrange
            string hexNum = "0111";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("7", ans);
        }

        [Fact]
        public void eightToHex()
        {
            //Arrange
            string hexNum = "1000";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("8", ans);
        }

        [Fact]
        public void nineToHex()
        {
            //Arrange
            string hexNum = "1001";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("9", ans);
        }

        [Fact]
        public void aToHex()
        {
            //Arrange
            string hexNum = "1010";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("A", ans);
        }

        [Fact]
        public void bToHex()
        {
            //Arrange
            string hexNum = "1011";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("B", ans);
        }


        [Fact]
        public void cToHex()
        {
            //Arrange
            string hexNum = "1100";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("C", ans);
        }

        [Fact]
        public void dToHex()
        {
            //Arrange
            string hexNum = "1101";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("D", ans);
        }

        [Fact]
        public void eToHex()
        {
            //Arrange
            string hexNum = "1110";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("E", ans);
        }

        [Fact]
        public void fToHex()
        {
            //Arrange
            string hexNum = "1111";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("F", ans);
        }

        [Fact]
        public void gToHex()
        {
            //Arrange
            string hexNum = "G";
            //ACT
            string ans = Utility.covertBinaryCharToHex(hexNum);
            //Assert
            Assert.Equal("-1", ans);
        }

    }
}
