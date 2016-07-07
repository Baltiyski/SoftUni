using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Input number for position : ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Input a index 0 or 1 : ");
        int index = int.Parse(Console.ReadLine());

        int mask;
        int result;

        if (index == 0)
        {
            mask = ~(1 << position);
            result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << position;
            result = number | mask;
            Console.WriteLine(result);
        }
    }
}
