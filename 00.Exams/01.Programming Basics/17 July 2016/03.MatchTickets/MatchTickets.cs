using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatchTickets
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        string ticketCategory = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double moneyAfterTransport = 0;

        if (people >= 1 && people <= 4)
        {
            moneyAfterTransport = budget - (budget * 0.75);

        }
        else if (people >= 5 && people <= 9)
        {
            moneyAfterTransport = budget - (budget * 0.6);
        }
        else if (people >= 10 && people <= 24)
        {
            moneyAfterTransport = budget - (budget * 0.5);
        }
        else if (people >= 25 && people <= 49)
        {
            moneyAfterTransport = budget - (budget * 0.4);
        }
        else
        {
            moneyAfterTransport = budget - (budget * 0.25);
        }

        if (ticketCategory == "VIP")
        {
            double vipTick = 499.99 * people;
            if (moneyAfterTransport < vipTick)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.",(vipTick - moneyAfterTransport));
            }
            else
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.",(moneyAfterTransport - vipTick));
            }
        }
        else
        {
            double normalTick = 249.99 * people;
            if (moneyAfterTransport < normalTick)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", (normalTick - moneyAfterTransport));
            }
            else
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", (moneyAfterTransport - normalTick));
            }
        }
    }
}
