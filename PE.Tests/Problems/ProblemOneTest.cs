using FluentAssertions;
using PE.Solutions.Problems;
using Xunit;

namespace PE.Tests.Problems
{
    public class ProblemOneTest
    {
        private ProblemOne problemOne;
        public ProblemOneTest()
        {
            problemOne = new ProblemOne();
        }

        [Theory]
        [InlineData(10, 23)]
        [InlineData(1000, 233168)]
        public void ShouldReturnCorrectSumOfMultipleThreeAndFive(int number, int answer)
        {
            var result = problemOne.SumMultipleThreeAndFive(number);

            result.Should().Be(answer);
        }
    }
}