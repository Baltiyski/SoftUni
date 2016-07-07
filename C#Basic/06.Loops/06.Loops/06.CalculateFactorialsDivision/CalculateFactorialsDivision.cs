using System;

class CalculateFactorialsDivision
{
    static void Main()
    {
        Console.Write("Write a number : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Write a number : ");
        int k = int.Parse(Console.ReadLine());

        int factoriel = 0;

        for (int i = n; i < k; i++)
        {
            factoriel += n;
        }

        Console.WriteLine(factoriel);
    }
}
