using System;
using Xunit;
using PlusMinusProblem;

namespace PlusMinusProblemTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            string[] inputNumbers = "-4 3 -9 0 4 1".Trim().Split(' ');
            string[] expectedResult = new string[3] {
                "0.500000",
                "0.333333",
                "0.166667"
            };

            // Act
            var result = Program.CalculateRatioOfNegativePositiveAndZero(inputNumbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
