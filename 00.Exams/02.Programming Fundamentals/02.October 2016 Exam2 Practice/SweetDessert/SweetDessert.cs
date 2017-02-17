using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SweetDessert
{
    static void Main(string[] args)
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal bananas = decimal.Parse(Console.ReadLine());
        decimal eggs = decimal.Parse(Console.ReadLine());
        decimal berries = decimal.Parse(Console.ReadLine());
        int portions = 0;
        decimal neededCash = 0;

        if (guests % 6 !=0)
        {
            portions = (guests / 6) + 1;
        }
        else
        {
            portions = guests / 6;
        }

        neededCash = portions * (2 * bananas) + portions * (4 * eggs) + portions * (0.2m * berries);
        if (cash < neededCash)
        {
            neededCash = neededCash - cash;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededCash:F2}lv more.");
        }
        else
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {neededCash:F2}lv.");
        }
    }
}
