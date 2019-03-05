using FluentAssertions;
using PE.Solutions.Problems;
using Xunit;

namespace PE.Tests.Problems
{
    public class Problem004Test
    {
        private Problem004 problem004;

        public Problem004Test()
        {
            problem004 = new Problem004();
        }

        [Fact]
        public void ShouldReturnLargestPalindromeOfTwoThreeDigits()
        {
            var result = problem004.LargestPalindrome();

            result.Should().Be(906609);
        }

    }
}