using System;

class ExtractBits
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        int position = 3;

        int index = 1;

        int mask = 1 << position;
        int addMask = number & mask;

        Console.WriteLine(addMask != 0 ? 1 : 0);
    }
}
