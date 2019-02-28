using FluentAssertions;
using PE.Solutions.Problems;
using Xunit;

namespace PE.Tests.Problems
{
    public class Problem002Test
    {
        private Problem002 problem002;

        public Problem002Test()
        {
            problem002 = new Problem002();
        }

        [Theory]
        [InlineData(10L, 10L)]
        [InlineData(55L, 44L)]
        [InlineData(4000000L, 4613732L)]
        public void ShouldReturnCorrectlySumOfEvenFibNumber(long maxNumber, long answer)
        {
            var result = problem002.SumOfEvenFibNumber(maxNumber);

            result.Should().Be(answer);
        }

        [Theory]
        [InlineData(10L, 10L)]
        [InlineData(55L, 44L)]
        [InlineData(4000000L, 4613732L)]
        public void ShouldReturnCorrectlySumOfEvenFibNumberAtEveryThird(long maxNumber, long answer)
        {
            var result = problem002.SumOfEvenFibNumberAtEveryThird(maxNumber);

            result.Should().Be(answer);
        }
    }
}