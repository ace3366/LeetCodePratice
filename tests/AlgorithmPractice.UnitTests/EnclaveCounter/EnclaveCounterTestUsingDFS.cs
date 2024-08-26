using AlgorithmPractice.DFS.EnclaveCounter;

namespace AlgorithmPractice.UnitTests.EnclaveCounter
{
    public class EnclaveCounterTestUsingDFS
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void EnclaveCounter_InputAn2DArrayMap_ShouldReturnExpectedResult(int[][] grid, int expectedResult)
        {
            // Arrange
            var counter = new AlgorithmExecutor();
            // Act
            var result = counter.NumEnclaves(grid);
            // Assert
            Assert.Equal(expectedResult, result);
        }
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new []
                {
                    new[] { 0, 0, 0, 0 },
                    new[] { 1, 0, 1, 0 },
                    new[] { 0, 1, 1, 0 },
                    new[] { 0, 0, 0, 0 }
                },
                3
            };

            yield return new object[]
            {
                new[]
                {
                    new[] { 0, 1, 1, 0 },
                    new[] { 0, 0, 1, 0 },
                    new[] { 0, 0, 1, 0 },
                    new[] { 0, 0, 0, 0 }
                }
                ,
                0
            };

            yield return new object[]
            {
                new[]
                {
                    new[] { 0, 0, 0, 1, 1, 1, 0, 1, 0, 0 },
                    new[] { 1, 1, 0, 0, 0, 1, 0, 1, 1, 1 },
                    new[] { 0, 0, 0, 1, 1, 1, 0, 1, 0, 0 },
                    new[] { 0, 1, 1, 0, 0, 0, 1, 0, 1, 0 },
                    new[] { 0, 1, 1, 1, 1, 1, 0, 0, 1, 0 },
                    new[] { 0, 0, 1, 0, 1, 1, 1, 1, 0, 1 },
                    new[] { 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 },
                    new[] { 0, 0, 1, 0, 0, 1, 0, 1, 0, 1 },
                    new[] { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0 },
                    new[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 1 }
                }
                ,
                3
            };
        }
    }
}
