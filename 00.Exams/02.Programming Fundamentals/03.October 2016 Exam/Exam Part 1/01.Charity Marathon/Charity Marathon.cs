using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long daysDays = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());
            

            if ((trackCapacity * daysDays) < runners)
            {
                runners = trackCapacity * daysDays;
            }

            long totalMeters = runners * laps * trackLength;
            long totalKm = totalMeters / 1000;
            decimal moneyCollect = moneyPerKm * totalKm;
            Console.WriteLine($"Money raised: {moneyCollect:F2}");

        }
    }
}
