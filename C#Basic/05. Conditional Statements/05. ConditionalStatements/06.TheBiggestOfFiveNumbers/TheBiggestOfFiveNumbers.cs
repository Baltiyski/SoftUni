using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Write a number:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("The biggest numbers is " + a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("The biggest numbers is " + b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("The biggest numbers is " + c);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine("The biggest numbers is " + d);
        }
        else
        {
            Console.WriteLine("The biggest numbers is " + e);
        }

    }
}
