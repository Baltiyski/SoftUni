using System;

class DivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Write a positive number : ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}