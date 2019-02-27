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
        [InlineData(10, 10)]
        [InlineData(55, 44)]
        [InlineData(4000000, 4613732)]
        public void ShouldReturnCorrectlySumOfEvenFibNumber(int maxNumber, int answer)
        {
            var result = problem002.SumOfEvenFibNumber(maxNumber);

            result.Should().Be(answer);
        }
    }
}