using LastDigitOfALargeNumber.App;
using System;
using System.Numerics;
using Xunit;

namespace LastDigitOfALargeNumber.Test
{
    public class DetermineTheLastDigitOfALargeNumberTest
    {
        
        [Fact]
        public void GetTheLastDigitTest2_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = 10;
            BigInteger b = BigInteger.Pow(10, 10);
            int expected = 0;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetTheLastDigitTest3_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = BigInteger.Pow(2, 200);
            BigInteger b = BigInteger.Pow(2, 300);
            int expected = 6;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetTheLastDigitTest4_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = BigInteger.Parse("3715290469715693021198967285016729344580685479654510946723");
            BigInteger b = BigInteger.Parse("68819615221552997273737174557165657483427362207517952651");
            int expected = 7;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetTheLastDigitTest5_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = 4;
            BigInteger b = 1;
            int expected = 4;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetTheLastDigitTest6_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = 4;
            BigInteger b = 2;
            int expected = 6;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetTheLastDigitTest7_Successful()
        {
            //Arrange
            IDetermineTheLastDigitOfALargeNumber determineTheLastDigitOfALargeNumber = new DetermineTheLastDigitOfALargeNumber();
            BigInteger a = 9;
            BigInteger b = 7;
            int expected = 9;


            //Act
            var actual = determineTheLastDigitOfALargeNumber.GetTheLastDigit(a, b);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
    
}
