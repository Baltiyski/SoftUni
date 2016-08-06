using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Harvest
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());
        double workers = double.Parse(Console.ReadLine());

        double allFruits = x * y;
        double wine = 0.4 * allFruits / 2.5;

        double leftWine = 0;
        if (wine < z)
        {
            leftWine = z - wine;
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(leftWine));
        }
        else
        {
            leftWine = wine - z;
            double wineForWorkers = leftWine / workers;
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.",
                                                            Math.Floor(wine), Math.Ceiling(leftWine), Math.Ceiling(wineForWorkers));
        }

    }
}
