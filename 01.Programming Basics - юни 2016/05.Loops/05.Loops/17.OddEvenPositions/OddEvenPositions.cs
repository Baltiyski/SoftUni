using System;

class OddEvenPositions
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double OddSum = 0;
        double OddMin = 0;
        double OddMax = 0;
        double EvenSum = 0;
        double EvenMin = 0;
        double EvenMax = 0;
        double num = 0;

        if (n == 1)
        {
            num = double.Parse(Console.ReadLine());
            Console.WriteLine("OddSum={0},", num);
            Console.WriteLine("OddMin={0},", num);
            Console.WriteLine("OddMax={0},", num);

            Console.WriteLine("EvenSum=0,");
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else if (n == 0)
        {
            Console.WriteLine("OddSum=0,");
            Console.WriteLine("OddMin=No,");
            Console.WriteLine("OddMax=No,");

            Console.WriteLine("EvenSum=0,");
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)//even
                {
                    EvenSum += num;
                    if (i == 2)
                    {
                        EvenMin = num;
                        EvenMax = num;
                    }
                    if (EvenMin > num)
                    {
                        EvenMin = num;
                    }
                    if (EvenMax < num)
                    {
                        EvenMax = num;
                    }

                }
                else //odd
                {
                    OddSum += num;
                    if (i == 1)
                    {
                        OddMin = num;
                        OddMax = num;
                    }
                    if (OddMin > num)
                    {
                        OddMin = num;
                    }
                    if (OddMax < num)
                    {
                        OddMax = num;
                    }
                }
            }

            Console.WriteLine("OddSum={0},", OddSum);
            Console.WriteLine("OddMin={0},", OddMin);
            Console.WriteLine("OddMax={0},", OddMax);

            Console.WriteLine("EvenSum={0},", EvenSum);
            Console.WriteLine("EvenMin={0},", EvenMin);
            Console.WriteLine("EvenMax={0}", EvenMax);
        }
        
    }
}                                                                                     
