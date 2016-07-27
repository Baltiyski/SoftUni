using System;

class AreaOfFigures
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        double num00, num01, sum;
        switch (figure)
        {
            case "square":
                num00 = double.Parse(Console.ReadLine());
                num00 *= num00;
                Console.WriteLine("{0:F3}",num00);
                break;
            case "rectangle":
                num00 = double.Parse(Console.ReadLine());
                num01 = double.Parse(Console.ReadLine());
                sum = num00 * num01;
                Console.WriteLine("{0:F3}", sum);
                break;
            case "circle":
                Console.WriteLine("inupt");
                num00 = double.Parse(Console.ReadLine());
                sum = (num00 * num00) * Math.PI;
                Console.WriteLine("{0:F3}", sum);
                break;
            case "triangle":
                num00 = double.Parse(Console.ReadLine());
                num01 = double.Parse(Console.ReadLine());
                sum = (num00 * num01) / 2;
                Console.WriteLine("{0:F3}", sum);
                break;
            default:
                break;
        }
    }
}