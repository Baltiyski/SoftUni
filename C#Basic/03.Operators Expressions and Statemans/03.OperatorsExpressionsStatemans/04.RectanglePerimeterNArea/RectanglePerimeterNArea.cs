using System;

class RectanglePerimeterNArea
{
    static void Main()
    {
        Console.Write("Input size for weight : ");
        double weidth = double.Parse(Console.ReadLine());

        Console.Write("Input suze for height : ");
        double height = double.Parse(Console.ReadLine());

        double area = weidth * height;

        double perimeter = 2*(weidth + height);

        Console.WriteLine("Rectangle area is {0}",area);
        Console.WriteLine("Rectangle perimeter {0}",perimeter);
    }
}
