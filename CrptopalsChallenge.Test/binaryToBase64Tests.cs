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
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("A", ans);
        }

        [Fact]
        public void oneToBase64()
        {
            //Arrange
            string hexNum = "000001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("B", ans);
        }

        [Fact]
        public void twoToBase64()
        {
            //Arrange
            string hexNum = "000010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("C", ans);
        }

        [Fact]
        public void threeToBase64()
        {
            //Arrange
            string hexNum = "000011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("D", ans);
        }

        [Fact]
        public void fourToBase64()
        {
            //Arrange
            string hexNum = "000100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("E", ans);
        }

        [Fact]
        public void fiveToBase64()
        {
            //Arrange
            string hexNum = "000101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("F", ans);
        }

        [Fact]
        public void sixToBase64()
        {
            //Arrange
            string hexNum = "000110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("G", ans);
        }

        [Fact]
        public void sevenToBase64()
        {
            //Arrange
            string hexNum = "000111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("H", ans);
        }

        [Fact]
        public void eightToBase64()
        {
            //Arrange
            string hexNum = "001000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("I", ans);
        }

        [Fact]
        public void nineToBase64()
        {
            //Arrange
            string hexNum = "001001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("J", ans);
        }

        [Fact]
        public void tenToBase64()
        {
            //Arrange
            string hexNum = "001010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("K", ans);
        }

        [Fact]
        public void elevenToBase64()
        {
            //Arrange
            string hexNum = "001011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("L", ans);
        }

        [Fact]
        public void twelveToBase64()
        {
            //Arrange
            string hexNum = "001100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("M", ans);
        }

        [Fact]
        public void thirteenToBase64()
        {
            //Arrange
            string hexNum = "001101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("N", ans);
        }

        [Fact]
        public void fourteenToBase64()
        {
            //Arrange
            string hexNum = "001110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("O", ans);
        }

        [Fact]
        public void fifiteenToBase64()
        {
            //Arrange
            string hexNum = "001111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("P", ans);
        }

        [Fact]
        public void sixteenToBase64()
        {
            //Arrange
            string hexNum = "010000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Q", ans);
        }


        [Fact]
        public void seventeenToBase64()
        {
            //Arrange
            string hexNum = "010001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("R", ans);
        }

        [Fact]
        public void eightteenToBase64()
        {
            //Arrange
            string hexNum = "010010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("S", ans);
        }

        [Fact]
        public void nineteenToBase64()
        {
            //Arrange
            string hexNum = "010011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("T", ans);
        }

        [Fact]
        public void twentyToBase64()
        {
            //Arrange
            string hexNum = "010100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("U", ans);
        }

        [Fact]
        public void twentyOneToBase64()
        {
            //Arrange
            string hexNum = "010101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("V", ans);
        }


        [Fact]
        public void twentyTwoToBase64()
        {
            //Arrange
            string hexNum = "010110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("W", ans);
        }


        [Fact]
        public void twentyThreeToBase64()
        {
            //Arrange
            string hexNum = "010111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("X", ans);
        }

        [Fact]
        public void twentyFourToBase64()
        {
            //Arrange
            string hexNum = "011000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Y", ans);
        }

        [Fact]
        public void twentyFiveToBase64()
        {
            //Arrange
            string hexNum = "011001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("Z", ans);
        }

        [Fact]
        public void twentySixToBase64()
        {
            //Arrange
            string hexNum = "011010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("a", ans);
        }

        [Fact]
        public void twentySevenToBase64()
        {
            //Arrange
            string hexNum = "011011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("b", ans);
        }

        [Fact]
        public void twentyEightToBase64()
        {
            //Arrange
            string hexNum = "011100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("c", ans);
        }

        [Fact]
        public void twentyNineToBase64()
        {
            //Arrange
            string hexNum = "011101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("d", ans);
        }

        [Fact]
        public void thirtyToBase64()
        {
            //Arrange
            string hexNum = "011110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("e", ans);
        }

        [Fact]
        public void thirtyOneToBase64()
        {
            //Arrange
            string hexNum = "011111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("f", ans);
        }


        [Fact]
        public void thrityTwoToBase64()
        {
            //Arrange
            string hexNum = "100000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("g", ans);
        }

        [Fact]
        public void thrityThreeToBase64()
        {
            //Arrange
            string hexNum = "100001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("h", ans);
        }

        [Fact]
        public void thrityFourToBase64()
        {
            //Arrange
            string hexNum = "100010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("i", ans);
        }

        [Fact]
        public void thrityFiveToBase64()
        {
            //Arrange
            string hexNum = "100011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("j", ans);
        }

        [Fact]
        public void thirtySixToBase64()
        {
            //Arrange
            string hexNum = "100100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("k", ans);
        }

        [Fact]
        public void thirtySevenToBase64()
        {
            //Arrange
            string hexNum = "100101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("l", ans);
        }

        [Fact]
        public void thrityEightToBase64()
        {
            //Arrange
            string hexNum = "100110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("m", ans);
        }

        [Fact]
        public void thrityNineToBase64()
        {
            //Arrange
            string hexNum = "100111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("n", ans);
        }

        [Fact]
        public void fourtyToBase64()
        {
            //Arrange
            string hexNum = "101000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("o", ans);
        }

        [Fact]
        public void fourtyOneToBase64()
        {
            //Arrange
            string hexNum = "101001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("p", ans);
        }

        [Fact]
        public void fourtyTwoToBase64()
        {
            //Arrange
            string hexNum = "101010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("q", ans);
        }

        [Fact]
        public void fourtyThreeToBase64()
        {
            //Arrange
            string hexNum = "101011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("r", ans);
        }

        [Fact]
        public void FourtyFourToBase64()
        {
            //Arrange
            string hexNum = "101100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("s", ans);
        }

        [Fact]
        public void fourtyFiveToBase64()
        {
            //Arrange
            string hexNum = "101101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("t", ans);
        }

        [Fact]
        public void fourtySixToBase64()
        {
            //Arrange
            string hexNum = "101110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("u", ans);
        }

        [Fact]
        public void fourtySevenToBase64()
        {
            //Arrange
            string hexNum = "101111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("v", ans);
        }

        [Fact]
        public void fourtyEightToBase64()
        {
            //Arrange
            string hexNum = "110000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("w", ans);
        }


        [Fact]
        public void fourtyNineToBase64()
        {
            //Arrange
            string hexNum = "110001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("x", ans);
        }

        [Fact]
        public void fiftyToBase64()
        {
            //Arrange
            string hexNum = "110010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("y", ans);
        }

        [Fact]
        public void fiftyOneToBase64()
        {
            //Arrange
            string hexNum = "110011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("z", ans);
        }

        [Fact]
        public void fiftyTwoToBase64()
        {
            //Arrange
            string hexNum = "110100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("0", ans);
        }

        [Fact]
        public void fiftyThreeOneToBase64()
        {
            //Arrange
            string hexNum = "110101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("1", ans);
        }


        [Fact]
        public void fiftyFourToBase64()
        {
            //Arrange
            string hexNum = "110110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("2", ans);
        }


        [Fact]
        public void fiftyFiveToBase64()
        {
            //Arrange
            string hexNum = "110111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("3", ans);
        }

        [Fact]
        public void fiftySixToBase64()
        {
            //Arrange
            string hexNum = "111000";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("4", ans);
        }

        [Fact]
        public void fiftySevenToBase64()
        {
            //Arrange
            string hexNum = "111001";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("5", ans);
        }

        [Fact]
        public void fiftyEightToBase64()
        {
            //Arrange
            string hexNum = "111010";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("6", ans);
        }

        [Fact]
        public void fiftyNineToBase64()
        {
            //Arrange
            string hexNum = "111011";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("7", ans);
        }

        [Fact]
        public void sixtyToBase64()
        {
            //Arrange
            string hexNum = "111100";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("8", ans);
        }

        [Fact]
        public void sixtyOneToBase64()
        {
            //Arrange
            string hexNum = "111101";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("9", ans);
        }

        [Fact]
        public void sixtyTwoToBase64()
        {
            //Arrange
            string hexNum = "111110";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("+", ans);
        }

        [Fact]
        public void SixtyThreeToBase64()
        {
            //Arrange
            string hexNum = "111111";
            //ACT
            string ans = Utility.convertBinaryToBase64(hexNum);
            //Assert
            Assert.Equal("/", ans);
        }
    }
}
