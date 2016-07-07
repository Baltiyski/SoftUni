using System;

class FromOneToN
{
    static void Main()
    {
        Console.Write("Input a number: ");

        int toN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= toN; i++)
        {
            Console.WriteLine(i);
        }
    }
}

