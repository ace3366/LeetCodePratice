using AlgorithmPractice.ClosestPointFinder;

namespace AlgorithmPractice.UnitTests.ClosestPointsFinder
{
    public class ClosestPointFinderTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void ClosestPointFinder_InputAnArrayOfPointsAndKPoint_ShouldReturnExpectedResult(int[][] points, int k, int[][] expectedResult)
        {
            // Arrange
            var counter = new AlgorithmExecutor();

            // Act
            var result = counter.KClosest(points, k);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // MemberData provides the data for the theory
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new[] { new[] { 1, 3 }, new[] { -2, 2 } },
                1,
                new[] { new[] { -2, 2 } }
                
            };

            yield return new object[]
            {
                new[]
                    {
                        new[] { 3, 3 },
                        new[] { 5, -1 },
                        new[] { -2, 4 }
                    }
                ,
                2,
                new[]
                    {
                        new[] { 3, 3 },
                        new[] { -2, 4 }
                    }

            };
        }
    }
}
