using CryptopalsChallenge.Set1.challengeOne;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CrptopalsChallenge.Test
{
    public class binaryToBase64Tests
    {
        [Fact]
        public void zeroToBase64()
        {
            //Arrange
            string hexNum = "000000";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("A", ans);
        }

        [Fact]
        public void oneToBase64()
        {
            //Arrange
            string hexNum = "000001";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("B", ans);
        }

        [Fact]
        public void twoToBase64()
        {
            //Arrange
            string hexNum = "000010";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("C", ans);
        }

        [Fact]
        public void threeToBase64()
        {
            //Arrange
            string hexNum = "000011";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("D", ans);
        }

        [Fact]
        public void fourToBase64()
        {
            //Arrange
            string hexNum = "000100";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("E", ans);
        }

        [Fact]
        public void fiveToBase64()
        {
            //Arrange
            string hexNum = "000101";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("F", ans);
        }

        [Fact]
        public void sixToBase64()
        {
            //Arrange
            string hexNum = "000110";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("G", ans);
        }

        [Fact]
        public void sevenToBase64()
        {
            //Arrange
            string hexNum = "000111";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("H", ans);
        }

        [Fact]
        public void eightToBase64()
        {
            //Arrange
            string hexNum = "001000";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("I", ans);
        }

        [Fact]
        public void nineToBase64()
        {
            //Arrange
            string hexNum = "001001";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("J", ans);
        }

        [Fact]
        public void tenToBase64()
        {
            //Arrange
            string hexNum = "001010";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("K", ans);
        }

        [Fact]
        public void elevenToBase64()
        {
            //Arrange
            string hexNum = "001011";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("L", ans);
        }

        [Fact]
        public void twelveToBase64()
        {
            //Arrange
            string hexNum = "001100";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("M", ans);
        }

        [Fact]
        public void thirteenToBase64()
        {
            //Arrange
            string hexNum = "001101";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("N", ans);
        }

        [Fact]
        public void fourteenToBase64()
        {
            //Arrange
            string hexNum = "001110";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("O", ans);
        }

        [Fact]
        public void fifiteenToBase64()
        {
            //Arrange
            string hexNum = "001111";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("P", ans);
        }

        [Fact]
        public void sixteenToBase64()
        {
            //Arrange
            string hexNum = "010000";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Q", ans);
        }


        [Fact]
        public void seventeenToBase64()
        {
            //Arrange
            string hexNum = "010001";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("R", ans);
        }

        [Fact]
        public void eightteenToBase64()
        {
            //Arrange
            string hexNum = "010010";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("S", ans);
        }

        [Fact]
        public void nineteenToBase64()
        {
            //Arrange
            string hexNum = "010011";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("T", ans);
        }

        [Fact]
        public void twentyToBase64()
        {
            //Arrange
            string hexNum = "010100";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("U", ans);
        }

        [Fact]
        public void twentyOneToBase64()
        {
            //Arrange
            string hexNum = "010101";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("V", ans);
        }


        [Fact]
        public void twentyTwoToBase64()
        {
            //Arrange
            string hexNum = "010110";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("W", ans);
        }


        [Fact]
        public void twentyThreeToBase64()
        {
            //Arrange
            string hexNum = "010111";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("X", ans);
        }

        [Fact]
        public void twentyFourToBase64()
        {
            //Arrange
            string hexNum = "011000";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Y", ans);
        }

        [Fact]
        public void twentyFiveToBase64()
        {
            //Arrange
            string hexNum = "011001";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Z", ans);
        }

        [Fact]
        public void twentySixToBase64()
        {
            //Arrange
            string hexNum = "011010";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("a", ans);
        }

        [Fact]
        public void twentySevenToBase64()
        {
            //Arrange
            string hexNum = "011011";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("b", ans);
        }

        [Fact]
        public void twentyEightToBase64()
        {
            //Arrange
            string hexNum = "011100";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("c", ans);
        }

        [Fact]
        public void twentyNineToBase64()
        {
            //Arrange
            string hexNum = "011101";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("d", ans);
        }

        [Fact]
        public void thirtyToBase64()
        {
            //Arrange
            string hexNum = "011110";
            //ACT
            string ans = ConvertHextToBase64.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("e", ans);
        }
    }
}
