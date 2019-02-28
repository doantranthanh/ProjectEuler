using FluentAssertions;
using PE.Solutions.Problems;
using Xunit;

namespace PE.Tests.Problems
{
    public class Problem001Test
    {
        private Problem001 problemOne;
        public Problem001Test()
        {
            problemOne = new Problem001();
        }

        [Theory]
        [InlineData(10L, 23L)]
        [InlineData(1000L, 233168L)]
        [InlineData(1000000000L, 233168L)]
        public void ShouldReturnCorrectSumOfMultipleThreeAndFive(long number, long answer)
        {
            var result = problemOne.SumMultipleThreeAndFive(number);

            result.Should().Be(answer);
        }
    }
}