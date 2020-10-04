using Xunit;
using compare_the_triplets;

namespace test
{
    public class CompareTripletsTest
    {
        [Theory]
        [InlineData("17 28 30", "99 16 8", "2 1")]
        [InlineData("5 6 7", "3 6 10", "1 1")]
        [InlineData("1 1 1", "2 1 2", "0 2")]
        [InlineData("", "", "0 0")]
        [InlineData(" ", " ", "0 0")]
        public void Compare_Triplets_Should_Return_Reviewer_Score_Points(string tripletAlice, string tripletBob, string expectedResult)
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
