using Xunit;
using compare_the_triplets;

namespace test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("17 28 30", "99 16 8", "2 1")]
        [InlineData("5 6 7", "3 6 10", "1 1")]
        [InlineData("1 1 1", "2 1 2", "0 2")]

        public void Test1(string tripletAlice, string tripletBob, string expectedResult)
        {
            // Arrange
            string[] tripletAliceTokens = tripletAlice.Trim().Split(' ');
            string[] tripletBobTokens = tripletBob.Trim().Split(' ');

            // Act
            string result = Program.CompareTriplets(tripletAliceTokens, tripletBobTokens);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
