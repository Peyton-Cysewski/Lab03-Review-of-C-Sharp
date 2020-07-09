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
        [InlineData(95, 5, 19f)]
        [InlineData(0, 7, 0f)]
        [InlineData(107, 4, 26.75f)]
        public void Challenge2Works(int dividend, int divisor, double outcome)
        {
            double expected = outcome;
            double actual = GetAverage(dividend, divisor);

            Assert.Equal(expected, actual);
        }
    }

    public class UnitTestChallenge4
    {
        [Fact]
        public void ReturnsTheMostCommonNumber()
        {
            // Assign
            int[] array = new int[] { 1, 2, 2, 3, 3, 3 };
            int expected = 3;
            // Act
            int actual = MostCommonNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsTheMostCommonNumberLongArray()
        {
            // Assign
            int[] array = new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
            int expected = 5;
            // Act
            int actual = MostCommonNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllNumbersAreTheSame()
        {
            // Assign
            int[] array = new int[] { 2, 2, 2, 2, 2, 2, 2 };
            int expected = 2;
            // Act
            int actual = MostCommonNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NoDuplicatesAreInTheArray()
        {
            // Assign
            int[] array = new int[] { 3, 4, 2, 6, 1, 9, 7, 8, 5 };
            int expected = 3;
            // Act
            int actual = MostCommonNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SameAmountOfDuplicates()
        {
            // Assign
            int[] array = new int[] { 7, 7, 6, 6, 5, 5, 4, 4, 3, 2, 1 };
            int expected = 7;
            // Act
            int actual = MostCommonNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23 }, 2)]
        [InlineData(new int[] { 6, 6, 6, 6, 6 }, 6)]
        [InlineData(new int[] { 12, 12, 13, 13, 13, 13, 5, 54, 17 }, 13)]
        [InlineData(new int[] { 8, 8, 8, 8, 8, 8, 8, 8 }, 8)]
        [InlineData(new int[] { 42, 42, 42, 65, 65, 65, 99, 99, 99 }, 42)]
        public void Challenge4Works(int[] array, int output)
        {
            int expected = output;
            int actual = MostCommonNumber(array);

            Assert.Equal(expected, actual);
        }
    }

    public class UnitTestChallenge5
    {
        [Fact]
        public void FindsHighestNumber()
        {
            // Assign
            int expected = 10;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            int actual = LargestNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WorksWithNegativeNumbers()
        {
            // Assign
            int expected = -1;
            int[] array = new int[] { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };

            // Act
            int actual = LargestNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllNumbersAreTheSame()
        {
            // Assign
            int expected = 15;
            int[] array = new int[] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 };

            // Act
            int actual = LargestNumber(array);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 13, 15, 45, 13 }, 45)]
        [InlineData(new int[] { -3, 78, -45, 1 }, 78)]
        [InlineData(new int[] { -100, -12, -56, -13 }, -12)]
        [InlineData(new int[] { -3, -3, -3, -3 }, -3)]
        public void Challenge5Works(int[] array, int output)
        {
            int expected = output;
            int actual = LargestNumber(array);

            Assert.Equal(expected, actual);
        }
    }
}

