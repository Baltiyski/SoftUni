using System;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            if ((n % i == 0) && (m % i == 0))
            {
                result = i;
            }
        }

        Console.WriteLine(result);

    }
}
