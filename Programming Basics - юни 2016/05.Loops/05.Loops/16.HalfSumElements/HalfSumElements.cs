using System;

class HalfSumElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int greathenNum = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                greathenNum = numbers;
                sum = numbers;
            }
            if(greathenNum < numbers)
            {
                greathenNum = numbers;
            }
            if (i > 0)
            {
                sum += numbers;
            }
        }

        sum -= greathenNum;
        int result = Math.Abs(sum - greathenNum);

        if (result == 0)
        {
            Console.WriteLine("Yes Sum = {0}", greathenNum);
        }
        else
        {
            if (greathenNum > sum)
            {
                Console.WriteLine("No Diff = {0}", greathenNum - sum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", sum - greathenNum);
            }
           
        }
    }
}
