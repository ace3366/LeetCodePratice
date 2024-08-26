using AlgorithmPractice.MaxTimeGenerator;

namespace AlgorithmPractice.UnitTests.MaxTimeGenerator
{
    public class MaxTimeTest
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void MaxTimeGenerator_InputAnArrayOfNumber_ShouldReturnExpectedResult(int[] arr, string expectedResult)
        {
            // Arrange
            var algorithm = new AlgorithmExecutor();

            // Act
            var result = algorithm.LargestTimeFromDigits(arr);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // MemberData provides the data for the theory
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[]
            {
                new[] { 1, 2, 3, 4 },
                "23:41"
            };

            yield return new object[]
            {
                new[] { 5,5,5,5 },
                ""
            };

            yield return new object[]
            {
                new[] { 2,0,6,6 },
                "06:26"
            };

            yield return new object[]
            {
                new[] { 0,4,0,0 },
                "04:00"
            };

            yield return new object[]
            {
                new[] { 0,0,1,0 },
                "10:00"
            };
        }
    }
}
