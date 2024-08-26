using AlgorithmPractice.RookCaptureTracker;

namespace AlgorithmPractice.UnitTests.RookCaptureTracker
{
    public class RookCaptureTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void ClosestPointFinder_InputAnArrayOfPointsAndKPoint_ShouldReturnExpectedResult(char[][] board, int expectedResult)
        {
            // Arrange
            var counter = new AlgorithmExecutor();

            // Act
            var result = counter.NumRookCaptures(board);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // MemberData provides the data for the theory
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'R', '.', '.', '.', 'p' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
                    }
                    ,
                    3
            };

            yield return new object[]
            {
                new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                        new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                        new char[] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' },
                        new char[] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' },
                        new char[] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
                    }
                    ,
                    0
            };

            yield return new object[]
            {
               new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                        new char[] { 'p', 'p', '.', 'R', '.', 'p', 'B', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'B', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', 'p', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
                    }
                    ,
                    3
            };

            yield return new object[]
            {
                new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', 'B', 'B', 'B', 'B', 'B', '.' },
                        new char[] { '.', 'p', 'B', 'p', 'p', 'p', 'B', 'p' },
                        new char[] { '.', 'p', 'B', 'p', 'R', 'p', 'B', 'p' },
                        new char[] { '.', 'p', 'B', 'p', 'p', 'p', 'B', 'p' },
                        new char[] { '.', '.', 'B', 'B', 'B', 'B', 'B', '.' },
                        new char[] { '.', '.', '.', 'p', 'p', 'p', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.', '.', '.', '.' }
                    }
                    ,
                    4
            };
        }
    }
}
