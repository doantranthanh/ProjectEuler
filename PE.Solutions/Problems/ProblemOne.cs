using System;
namespace PE.Solutions.Problems
{
    public class ProblemOne
    {
        public int SumMultipleThreeAndFive(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum > Math.Pow(2, 31) ? -1 : sum;
        }
    }
}