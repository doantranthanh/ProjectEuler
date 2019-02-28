using System;
namespace PE.Solutions.Problems
{
    public class Problem001
    {
        public long SumMultipleThreeAndFive(long n)
        {
            long sum = 0;
            for (long i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public long SumMultipleThreeAndFiveTwo(long number)
        {
            var sum1 = SumMultipleThree(number);
            var sum2 = SumMultipleFive(number);
            var sum3 = SumMultipleFifteen(number);
            return SumMultipleThree(number) + SumMultipleFive(number) - SumMultipleFifteen(number);
        }

        private long SumMultipleFifteen(long n)
        {
            long sum = 0;
            for (long i = 0; i < n; i++)
            {
                if (i % 15 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private long SumMultipleFive(long n)
        {
            long sum = 0;
            for (long i = 0; i < n; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private long SumMultipleThree(long n)
        {
            long sum = 0;
            for (long i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        private long SumDivisibleBy(long target, long number)
        {
            long p = (target / number);
            return number * (p * (p + 1)) / 2;
        }
        public long SumDivisibleBy(long target)
        {
            return SumDivisibleBy(target - 1, 3) + SumDivisibleBy(target - 1, 5) - SumDivisibleBy(target - 1, 15);
        }
    }
}