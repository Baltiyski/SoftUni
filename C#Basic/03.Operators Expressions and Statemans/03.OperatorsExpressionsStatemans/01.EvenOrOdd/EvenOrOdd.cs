using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.Write("Input number: ");
        int theNumber = int.Parse(Console.ReadLine());

        if (theNumber % 2 == 0)
        {
            Console.WriteLine("The numbers is Even!");
        }
        else
        {
            Console.WriteLine("The number is Odd!");
        }
    }
}
    