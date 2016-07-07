using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Write a number:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The biggest number is " + a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("The biggest number is " + b);
        }
        else
        {
            Console.WriteLine("The biggest number is " + c);
        }
    }
}
