using AlgorithmPractice.StringScoreCalculator;

namespace AlgorithmPractice.UnitTests.StringScoreCalculator
{
    /// <summary>
    /// Test function name: SUT_Scenario_Expected
    /// SUT (System Under Test): Logical component testing
    /// </summary>
    public class StringScoreTests
    {
        [Theory]
        [InlineData("abc", 2)]
        [InlineData("xyz", 2)]
        [InlineData("hello", 7)]
        [InlineData("A", 0)]
        [InlineData("", 0)]
        public void StringScoreCaculator_InputAnyString_ShouldReturnExpectedResult(string input, int expectedResult)
        {
            // Arrange
            var calculator = new AlgorithmExecutor();

            // Act
            var result = calculator.ScoreOfString(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}