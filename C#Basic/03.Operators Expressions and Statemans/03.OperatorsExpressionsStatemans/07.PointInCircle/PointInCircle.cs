using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Input size for point X : ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Input size for point Y : ");
        double y = double.Parse(Console.ReadLine());

        double pointIn = (x * x) + (y * y);

        Console.WriteLine(pointIn <= (2 * 2) ? "True" : "False");
    }
}
