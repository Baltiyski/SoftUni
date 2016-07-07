using System;

class SumFactOverPowOfX
{
    static void Main(string[] args)
    {
        Console.Write("Write a number : ");
        decimal n = decimal.Parse(Console.ReadLine());

        Console.Write("Write a number : ");
        decimal x = decimal.Parse(Console.ReadLine());

        decimal factoriel = 1.0m;
        decimal power = 1.0m;
        decimal sum = 0.0m;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            power *= x;
            sum += factoriel / power;
        }

        Console.WriteLine("The sum is {0:F5}",sum);
    }
}
