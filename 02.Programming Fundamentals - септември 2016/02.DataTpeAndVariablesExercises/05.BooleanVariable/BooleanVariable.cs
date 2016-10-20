using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        string trueOr = Console.ReadLine();
        bool isTrue = Convert.ToBoolean(trueOr);
        if (isTrue)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
