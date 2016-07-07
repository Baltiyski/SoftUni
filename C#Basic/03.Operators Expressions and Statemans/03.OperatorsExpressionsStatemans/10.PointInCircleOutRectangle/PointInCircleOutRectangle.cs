using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Input size for point X : ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Input size for point Y : ");
        double y = double.Parse(Console.ReadLine());

        double top = 1;
        double left = -1;
        double width = 6;
        double height = 2;

        double pointInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1);

        if (pointInCircle <= (1.5 * 1.5))
        {
            Console.WriteLine("The point is in circle!");
        }
        else
        {
            Console.WriteLine("The point is not in circle!");
        }
        if (((x > 1) || (x < 6)) && ((y > -1) || (y < 2)))
        {
            Console.WriteLine("The point is out of rectangle!");
        }
        else
        {
            Console.WriteLine("The point is in rectangle!");
        }
    }
}