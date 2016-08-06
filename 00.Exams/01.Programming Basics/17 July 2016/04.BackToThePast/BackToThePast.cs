using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BackToThePast
{
    static void Main(string[] args)
    {
        
        decimal heriteg = decimal.Parse(Console.ReadLine());
        long yearForLiving = long.Parse(Console.ReadLine());

        long years = yearForLiving - 1800;
        decimal leftMoney = heriteg;
        int manYears = 18;

        for (int i = 0; i <= years; i++)
        {
            if (i % 2 == 0)
            {
                leftMoney -= 12000;
            }
            else
            {
                leftMoney -= 12000 + (manYears * 50);
            }
            manYears++;
        }

        if (leftMoney >= 0)
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",leftMoney);
        }
        else
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.",(leftMoney * (-1)));
        }
        
    }
}
