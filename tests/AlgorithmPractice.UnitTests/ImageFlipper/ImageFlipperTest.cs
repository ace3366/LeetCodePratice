using AlgorithmPractice.ImageFlipper;
namespace AlgorithmPractice.UnitTests.ImageFlipper
{
    public class ImageFlipperTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void ImageFlipper_InputAnImage_ShouldReturnExpectedResult(int[][] image, int[][] expectedResult)
        {
            // Arrange
            var algorithm = new AlgorithmExecutor();

            // Act
            var result = algorithm.FlipAndInvertImage(image);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // MemberData provides the data for the theory
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new[]
                    {
                        new[] { 1, 1, 0 },
                        new[] { 1, 0, 1 },
                        new[] { 0, 0, 0 }
                    },
                new[]
                    {
                        new[] { 1, 0, 0 },
                        new[] { 0, 1, 0 },
                        new[] { 1, 1, 1 }
                    }
            };

            yield return new object[]
            {
                new[]
                    {
                        new[] { 1, 1, 0, 0 },
                        new[] { 1, 0, 0, 1 },
                        new[] { 0, 1, 1, 1 },
                        new[] { 1, 0, 1, 0 }
                    }
                    ,
                new[]
                    {
                        new[] { 1, 1, 0, 0 },
                        new[] { 0, 1, 1, 0 },
                        new[] { 0, 0, 0, 1 },
                        new[] { 1, 0, 1, 0 }
                    }
            };
        }
    }
}
