using System;

class EvenPowerOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            int two = 2;
            if (i % 2 == 0)
            {
                Console.WriteLine(Math.Pow(two, i));
            }
        }
    }
}
