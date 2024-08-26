using AlgorithmPractice.VideoStitching;

namespace AlgorithmPractice.UnitTests.VideoStitching
{
    public class VideoStichingTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void VideoStitching_InputAnArrayOfClipsAndTime_ShouldReturnExpectedResult( int time, int[][] clips, int expectedResult)
        {
            // Arrange
            var counter = new AlgorithmExecutor();

            // Act
            var result = counter.VideoStitching(clips, time);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                10,
                new[] { 
                    new[] { 0, 2 },
                    new[] { 4, 6 },
                    new[] { 8, 10 },
                    new[] { 1, 9 },
                    new[] { 1, 5 },
                    new[] { 5, 9 } }
                ,3
            };

            yield return new object[]
            {
                5,
                new[]
                {
                    new[] { 0, 1 },
                    new[] { 1, 2 }
                }
                ,
                -1
            };

            yield return new object[]
            {
                9,
                new[]
                {
                    new[] { 0, 1 },
                    new[] { 6, 8 },
                    new[] { 0, 2 },
                    new[] { 5, 6 },
                    new[] { 0, 4 },
                    new[] { 0, 3 },
                    new[] { 6, 7 },
                    new[] { 1, 3 },
                    new[] { 4, 7 },
                    new[] { 1, 4 },
                    new[] { 2, 5 },
                    new[] { 2, 6 },
                    new[] { 3, 4 },
                    new[] { 4, 5 },
                    new[] { 5, 7 },
                    new[] { 6, 9 }
                }
                ,
                3
            };

            yield return new object[]
            {
                50,
                new[]
                {
                    new[] { 0, 5 },
                    new[] { 1, 6 },
                    new[] { 2, 7 },
                    new[] { 3, 8 },
                    new[] { 4, 9 },
                    new[] { 5, 10 },
                    new[] { 6, 11 },
                    new[] { 7, 12 },
                    new[] { 8, 13 },
                    new[] { 9, 14 },
                    new[] { 10, 15 },
                    new[] { 11, 16 },
                    new[] { 12, 17 },
                    new[] { 13, 18 },
                    new[] { 14, 19 },
                    new[] { 15, 20 },
                    new[] { 16, 21 },
                    new[] { 17, 22 },
                    new[] { 18, 23 },
                    new[] { 19, 24 },
                    new[] { 20, 25 },
                    new[] { 21, 26 },
                    new[] { 22, 27 },
                    new[] { 23, 28 },
                    new[] { 24, 29 },
                    new[] { 25, 30 },
                    new[] { 26, 31 },
                    new[] { 27, 32 },
                    new[] { 28, 33 },
                    new[] { 29, 34 },
                    new[] { 30, 35 },
                    new[] { 31, 36 },
                    new[] { 32, 37 },
                    new[] { 33, 38 },
                    new[] { 34, 39 },
                    new[] { 35, 40 },
                    new[] { 36, 41 },
                    new[] { 37, 42 },
                    new[] { 38, 43 },
                    new[] { 39, 44 },
                    new[] { 40, 45 },
                    new[] { 41, 46 },
                    new[] { 42, 47 },
                    new[] { 43, 48 },
                    new[] { 44, 49 },
                    new[] { 45, 50 },
                    new[] { 46, 51 },
                    new[] { 47, 52 },
                    new[] { 48, 53 },
                    new[] { 49, 54 }
                }
                ,
                10
            };

            yield return new object[]
            {
                5,
                new[]
                {
                    new[] { 0, 4 },
                    new[] { 2, 8 }
                }
                ,
                2
            };
        }
    }


}
