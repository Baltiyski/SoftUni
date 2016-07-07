using System;

class CheckBitPosition
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Input number for position : ");
        int position = int.Parse(Console.ReadLine());

        int index = 1;

        int mask = 1 << position;
        int addMask = number & mask;

        Console.WriteLine(addMask != 0 ? "True" : "False" );
    }
}
