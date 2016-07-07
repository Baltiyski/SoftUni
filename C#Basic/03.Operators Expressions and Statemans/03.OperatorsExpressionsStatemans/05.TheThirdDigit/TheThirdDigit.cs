using System;

class TheThirdDigit
{
    static void Main()
    {
        Console.Write("Input number : ");
        int number = int.Parse(Console.ReadLine());

        int divideBy100 = number / 100;
        int dividBy10 = divideBy100 % 10;

        if (dividBy10 == 7)
        {
            Console.WriteLine("Third digit is 7!");
        }
        else
        {
            Console.WriteLine("Third digit isn't 7!");
        }

    }
}
