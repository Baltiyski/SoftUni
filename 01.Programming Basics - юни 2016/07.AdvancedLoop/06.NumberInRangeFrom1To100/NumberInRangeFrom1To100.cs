using System;

class NumberInRangeFrom1To100
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Enter number in the range [1...100]:");
            n = int.Parse(Console.ReadLine());
            if (n < 100 && n > 1)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }

        } while (n > 100 || n < 1 );

        Console.WriteLine("The number is: {0}",n);
    }
}
