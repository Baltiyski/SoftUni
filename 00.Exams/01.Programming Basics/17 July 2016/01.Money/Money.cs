using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Money
{
    static void Main(string[] args)
    {
        double peshoBitCoint = double.Parse(Console.ReadLine());
        double peshoChIoan = double.Parse(Console.ReadLine());
        double comission = double.Parse(Console.ReadLine());

        //Money Value im BGN and USD
        double bitCointToBGN = 1168;
        double chIoanToUSD = 0.15;
        double USDToBGN = 1.76;
        double EuroToBGN = 1.95;

        double bitToBGN = peshoBitCoint * bitCointToBGN;
        double ioanToBGN = (peshoChIoan * chIoanToUSD) * USDToBGN;
        double amountOfMoneyInEuro = (bitToBGN + ioanToBGN) / EuroToBGN;

        double commisionReal = amountOfMoneyInEuro * (comission / 100);
        double afterComission = amountOfMoneyInEuro - commisionReal;
        Console.WriteLine(afterComission);


    }
}
