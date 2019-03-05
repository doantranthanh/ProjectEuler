namespace PE.Solutions.Problems
{
    public class Problem004
    {
        public int LargestPalindrome()
        {
            int largestPalindrome = 0;
            int a = 100;
            while (a <= 999)
            {
                int b = 100;
                while (b <= 999)
                {
                    var prod = a * b;
                    if (IsPalindrome(prod) && prod > largestPalindrome)
                    {
                        largestPalindrome = prod;
                    }
                    b += 1;
                }
                a += 1;
            }
            return largestPalindrome;
        }

        private bool IsPalindrome(int n)
        {
            return n == Rev(n);
        }

        private int Rev(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                rev = rev * 10 + (n % 10);
                n = n / 10;
            }
            return rev;
        }
    }
}