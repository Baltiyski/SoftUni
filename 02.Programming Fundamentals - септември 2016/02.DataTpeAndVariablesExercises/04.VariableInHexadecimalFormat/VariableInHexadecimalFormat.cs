using System;

class VariableInHexadecimalFormat
{
    static void Main(string[] args)
    {
        string word1 = Console.ReadLine();

        int num1 = Convert.ToInt32(word1, 16);

        Console.WriteLine(num1);
    }
}
