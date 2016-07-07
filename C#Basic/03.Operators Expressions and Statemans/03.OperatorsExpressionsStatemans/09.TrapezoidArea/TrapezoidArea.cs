using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Input size for side A : ");
        double aSide = double.Parse(Console.ReadLine());

        Console.Write("Input size for side B : ");
        double bSide = double.Parse(Console.ReadLine());

        Console.Write("Input size for height H : ");
        double height = double.Parse(Console.ReadLine());

        double area = ((aSide + bSide) / 2) * height;

        Console.WriteLine("Trapezoid area is equal to - {0}!",area);
    }
}
