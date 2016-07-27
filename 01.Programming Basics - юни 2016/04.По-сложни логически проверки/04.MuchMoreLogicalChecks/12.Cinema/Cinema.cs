using System;

class Cinema
{
    static void Main(string[] args)
    {
        string cinema = Console.ReadLine();
        int r = int.Parse(Console.ReadLine());//how many rows
        int c = int.Parse(Console.ReadLine()); //how many columns

        int rowsCallAmount = r * c;

        if (cinema.Equals("Premiere"))
        {
            Console.WriteLine("{0:F2} leva", rowsCallAmount * 12.00);
        }
        else if (cinema.Equals("Normal"))
        {
            Console.WriteLine("{0:F2} leva", rowsCallAmount * 7.50);
        }
        else
        {
            Console.WriteLine("{0:F2} leva", rowsCallAmount * 5.00);
        }

    }
}
