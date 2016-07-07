using System;

class ExchangeNumbersBySmallestToGreatest
{
    static void Main()
    {
        Console.Write("Write a number : ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Write a number : ");
        double secondNum = double.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.WriteLine("{0} {1}", secondNum, firstNum);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNum, secondNum);
        }

    }
}
