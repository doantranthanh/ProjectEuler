namespace PE.Solutions.Problems
{
    public class Problem003
    {
        public long GetLargestPrimeFactor(long n)
        {
            if (n < 2)
            {
                return n;
            }
            long largestPrimeFactor = 0;
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    if (i > largestPrimeFactor)
                    {
                        largestPrimeFactor = i;
                    }
                    n = n / i;
                }
            }
            return largestPrimeFactor;
        }
    }
}