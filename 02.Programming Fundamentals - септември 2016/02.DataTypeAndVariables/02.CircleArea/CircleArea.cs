using System;

class CircleArea
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double area = pi * Math.Pow(radius, 2);

        Console.WriteLine("{0:F12}",area);
    }
}
