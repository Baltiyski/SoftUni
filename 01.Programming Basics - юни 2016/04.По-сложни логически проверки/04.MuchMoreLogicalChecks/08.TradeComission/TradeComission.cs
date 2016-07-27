using System;

class TradeComission
{
    static void Main(string[] args)
    {
        string town = Console.ReadLine();
        double salse = double.Parse(Console.ReadLine());

        if (salse >= 0)
        {
            double comission = -1;
            if (town.Equals("Sofia"))
            {
                if (salse >= 0 && salse<=500)
                {
                    Console.WriteLine("{0:F2}",salse * 0.05);
                }
                else if (salse > 500 && salse <= 1000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.07);
                }
                else if (salse > 1000 && salse <= 10000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.08);
                }
                else
                {
                    Console.WriteLine("{0:F2}", salse * 0.12);
                }

            }
            else if (town.Equals("Varna"))
            {
                if (salse >= 0 && salse <= 500)
                {
                    Console.WriteLine("{0:F2}", salse * 0.045);
                }
                else if (salse > 500 && salse <= 1000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.075);
                }
                else if (salse > 1000 && salse <= 10000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.10);
                }
                else
                {
                    Console.WriteLine("{0:F2}", salse * 0.13);
                }
            }
            else if (town.Equals("Plovdiv"))
            {
                if (salse >= 0 && salse <= 500)
                {
                    Console.WriteLine("{0:F2}", salse * 0.055);
                }
                else if (salse > 500 && salse <= 1000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.08);
                }
                else if (salse > 1000 && salse <= 10000)
                {
                    Console.WriteLine("{0:F2}", salse * 0.12);
                }
                else
                {
                    Console.WriteLine("{0:F2}", salse * 0.145);
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
        

    }
}
