using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Write a number : ");
        int n = int.Parse(Console.ReadLine());

        uint first = 0;
        uint second = 1;

        uint sum;

        if (n >= 2)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
        else if (n >= 1)
        {
            Console.WriteLine(first);
        }
        

        for (int i = 2; i < n; i++)
        {
            sum = first + second;
            first = second;
            second = sum;
            Console.WriteLine(sum);
        }

    }
}
