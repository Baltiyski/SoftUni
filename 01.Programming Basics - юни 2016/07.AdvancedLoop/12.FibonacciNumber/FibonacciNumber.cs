using System;

class FibonacciNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int f0 = 1;
        int f1 = 1;
        int result = 1;
        for (int i = 1; i < n; i++)
        {
            result = result + f0;
            f0 = f1;
            f1 = result;
        }
        Console.WriteLine(result);
    }
}
