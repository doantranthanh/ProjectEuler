namespace PE.Solutions.Problems
{
    public class Problem002
    {
        public int SumOfEvenFibNumber(int maxNumber)
        {
            int sum = 0;
            int first = 1;
            int second = 2;
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
    }
}