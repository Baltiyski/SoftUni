using System;

class Sort3NumbersInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Write a number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Write a number:");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            if (c > b)
            {
                Console.WriteLine("{0} {1} {2}",a,c,b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }
            
        }
        else if (b > a && b > c)
        {
            if (a < c)
            {
                Console.WriteLine("{0} {1} {2}",b,c,a);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",b,a,c);
            }
            
        }
        else
        {
            if (a < b)
            {
                Console.WriteLine("{0} {1} {2}",c,b,a);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",c,a,b);
            }
        }
    }
}
