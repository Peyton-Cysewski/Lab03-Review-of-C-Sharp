using System;
using Xunit;
using static Lab03_Review_of_C_Sharp.Program;

namespace Lab03_Tests
{
    public class UnitTestChallenge1
    {
        [Fact]
        public void ReturnsZeroWithLessThanThreeInputs()
        {
            // Assign
            string input = "1";
            int expected = 0;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsProductWithThreeInputs()
        {
            // Assign
            string input = "2 3 5";
            int expected = 30;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithNonNumbers()
        {
            // Assign
            string input = "one two three";
            int expected = 1;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithNumbersAndWords()
        {
            // Assign
            string input = "Hello dog 3";
            int expected = 3;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithMoreThanThreeInputs()
        {
            // Assign
            string input = "3 5 7 11 13";
            int expected = 105;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithNegativeNumbers()
        {
            // Assign
            string input = "-3 5 -11";
            int expected = 165;
            // Act
            int actual = SplitThenMultiplyArray(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1 1 1", 1)]
        [InlineData("cat dog mouse", 1)]
        [InlineData("3 4 6", 72)]
        [InlineData("4 three 5", 20)]
        [InlineData("23 56", 0)]
        [InlineData("-1 -2 -3", -6)]
        [InlineData("three 4 five 6 seven", 4)]
        public void Challenge1Works(string input, int output)
        {
            int actual = SplitThenMultiplyArray(input);
            int expected = output;

            Assert.Equal(expected, actual);
        }
    }

    public class UnitTestChallenge2
    {
        [Fact]
        public void GetsCorrectAverage()
        {
            // Assign
            int inputDivisor = 4;
            int inputDividend = 10;
            double expected = 2.5;
            // Act
            double actual = GetAverage(inputDividend, inputDivisor);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1000, 5, 200f)]
        [InlineData(1010, 8, 126.25f)]
        [InlineData(7, 2, 3.5f)]
        [InlineData(96, 5, 19.2f)]
        [InlineData(0, 7, 0f)]
        [InlineData(107, 4, 26.75f)]
        public void Challenge2Works(int dividend, int divisor, double outcome)
        {
            double expected = outcome;
            double actual = GetAverage(dividend, divisor);

            Assert.Equal(expected, actual);
        }
    }
}
