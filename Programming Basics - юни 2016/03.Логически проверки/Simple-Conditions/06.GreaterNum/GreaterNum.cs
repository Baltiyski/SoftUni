using System;

class GreaterNum
{
    static void Main(string[] args)
    {
        Console.Write("Input number: ");
        int num00 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num01 = int.Parse(Console.ReadLine());

        if(num00 >= num01)
        {
            Console.WriteLine(num00);
        }
        if(num00 < num01)
        {
            Console.WriteLine(num01);
        }
    }
}
