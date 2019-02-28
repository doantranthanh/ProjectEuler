using System;
namespace PE.Solutions.Problems
{
    public class Problem001
    {
        public long SumMultipleThreeAndFive(long n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}