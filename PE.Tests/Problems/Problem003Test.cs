using FluentAssertions;
using PE.Solutions.Problems;
using Xunit;

namespace PE.Tests.Problems
{
    public class Problem003Test
    {
        private Problem003 problem003;
        public Problem003Test()
        {
            problem003 = new Problem003();
        }

        [Theory]
        [InlineData(13195L, 29L)]
        [InlineData(600851475143L, 6857L)]
        public void ShouldReturnLargestPrimeOfANumber(long n, long largestPrimeFactor)
        {
            var result = problem003.GetLargestPrimeFactor(n);

            result.Should().Be(largestPrimeFactor);
        }
    }
}