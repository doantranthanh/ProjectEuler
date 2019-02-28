using System;

namespace PE.Solutions.Problems
{
    public class Problem002
    {
        public long SumOfEvenFibNumber(long maxNumber)
        {
            long sum = 0;
            long first = 1;
            long second = 2;
            while (second < maxNumber)
            {
                if (second % 2 == 0)
                {
                    sum += second;
                }
                var temp = first;
                first = second;
                second = first + temp;
            }
            return sum;
        }

        public long SumOfEvenFibNumberAtEveryThird(long maxNumber)
        {
            long sum = 0;
            long a = 1;
            long b = 1;
            long c = a + b;
            while (c < maxNumber)
            {
                sum += c;
                a = b + c;
                b = a + c;
                c = a + b;
            }
            return sum;
        }
    }
}