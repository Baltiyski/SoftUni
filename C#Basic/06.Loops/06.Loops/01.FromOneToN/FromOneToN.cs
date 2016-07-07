using System;

class FromOneToN
{
    static void Main()
    {
        Console.Write("Write a number : ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
