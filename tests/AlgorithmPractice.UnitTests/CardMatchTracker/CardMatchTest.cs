using AlgorithmPractice.CardMatchTracker;

namespace AlgorithmPractice.UnitTests.CardMatchTracker
{
    public class CardMatchTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void CardMatchTracker_InputAnArrayOfNumber_ShouldReturnExpectedResult(int[] deck, bool expectedResult)
        {
            // Arrange
            var algorithm = new AlgorithmExecutor();

            // Act
            var result = algorithm.HasGroupsSizeX(deck);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // MemberData provides the data for the theory
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new[] { 1, 2, 3, 4, 4, 3, 2, 1 },
                true
            };
            yield return new object[]
            {
                new[] { 1, 1, 1, 2, 2, 2, 3, 3 },
                false
            };
            yield return new object[]
            {
                new[] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,3,3,3,3,3,4,4,4,4,4,5,5,5,5,5 },
                true
            };
            yield return new object[]
            {
                new[] { 1 },
                false
            };
            yield return new object[]
            {
                new[] { 0,0,0,1,1,1,1,1,1,2,2,2,3,3,3 },
                true
            };
        }
    }
}
