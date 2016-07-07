using System;

class DividBy5And7
{
    static void Main()
    {
        Console.WriteLine("Input a number");
        int number = int.Parse(Console.ReadLine());

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
