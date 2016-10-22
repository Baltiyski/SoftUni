using System;

class ReverseAnArrayOfIntegers
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        fillArray(lenght);
        
        
    }

    static void fillArray(int lenght)
    {
        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ",array[i]);
        }
        Console.WriteLine();

    }
}
