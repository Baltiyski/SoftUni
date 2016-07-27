using System;

class NumberTable
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int minus = 1;
        int result = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (result >= n)
                {
                    //result = result = i + j - minus;
                    //minus++;
                    minus = result - b;
                    Console.Write("{0} ",minus);
                    b++;
                }
                else
                {
                    result = i + j;
                    Console.Write("{0} ", result);
                }

            }
            result = 0;
            b = 1;
            minus = 1;
            Console.WriteLine();
        }
    }
}
