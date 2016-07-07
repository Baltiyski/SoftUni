using System;

class PerimeterNAreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter the radius of Circle : R = ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * (radius * radius);

        Console.WriteLine("The Circle perimeter is - {0}", perimeter);
        Console.WriteLine("The Circle area is - {0}", area);
    }
}
