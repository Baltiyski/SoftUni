using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Input a number from 1 to 9 : ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 9)
        {
            Console.WriteLine("Invalid score");
            Console.WriteLine("Please try again!");
            Console.WriteLine();
            Main();
        }
        else if (number >=1 && number <= 3)
        {
            number *= 10;
            Console.WriteLine(number);
        }
        else if (number >= 4 && number <= 6)
        {
            number *= 100;
            Console.WriteLine(number);
        }
        else
        {
            number *= 1000;
            Console.WriteLine(number);
        }

    }
}
