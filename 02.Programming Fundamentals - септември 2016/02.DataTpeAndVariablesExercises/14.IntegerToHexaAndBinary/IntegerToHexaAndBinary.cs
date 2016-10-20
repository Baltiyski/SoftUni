using System;

class IntegerToHexaAndBinary
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        string hex = num.ToString("X");
        string result = Convert.ToString(num, 2);
        Console.WriteLine(hex);
        Console.WriteLine(result);
    }
}
