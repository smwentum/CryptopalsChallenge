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
    }
}
