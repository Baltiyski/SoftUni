using System;

class GreaterOfTwoValues
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        findInut(input);
    }

    static int GetIntMax(int num1, int num2)
    {
        if (num1 >= num2)
        {
            return num1;
        }
        return num2;
    }

    static char GetCharMax(char ch1, char ch2)
    {
        if (ch1 >= ch2)
        {
            return ch1;
        }
        return ch2;
    }

    static string GetMaxString(string name1, string name2)
    {
        if (name1.CompareTo(name2) >=0)
        {
            return name1;
        }
        return name2;
    }

    static void findInut(string input)
    {
        if (input == "int")
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetIntMax(num1, num2));
        }
        else if (input == "char")
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine(GetCharMax(ch1, ch2)); 
        }
        else
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            Console.WriteLine(GetMaxString(name1, name2)); 
        }
    }
}
