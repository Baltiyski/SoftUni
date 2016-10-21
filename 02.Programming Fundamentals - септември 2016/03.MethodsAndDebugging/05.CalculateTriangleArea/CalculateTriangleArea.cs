using System;

class CalculateTriangleArea
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine(FormulaTriangleArea(width,height));

    }

    static double FormulaTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
}
