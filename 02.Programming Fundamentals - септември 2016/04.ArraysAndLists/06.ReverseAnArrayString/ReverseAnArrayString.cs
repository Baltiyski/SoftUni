using System;
using System.Collections.Generic;
using System.Linq;
class ReverseAnArrayString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] array = input.Split(' ');

        Array.Reverse(array);
        Console.WriteLine(string.Join(" ",array));
    }
}
