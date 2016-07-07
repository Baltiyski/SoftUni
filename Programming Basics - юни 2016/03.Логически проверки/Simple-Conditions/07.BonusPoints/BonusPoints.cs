using System;

class BonusPoints
{
    static void Main(string[] args)
    {
        Console.Write("Enter score: ");
        double num = double.Parse(Console.ReadLine());

        double bonus = 0;

        if(num % 2 == 0)
        {
            bonus += 1;
        }
        else if((num % 10)==5)
        {
            bonus += 2 ;
        }

        if(num < 100)
        {
            bonus += 5;
        }
        else if(num >= 1000)
        {
            bonus = bonus + ((num * 10)/100);
        }
        else if(num >= 100)
        {
            bonus = bonus + ((num * 20) / 100);
        }

        Console.WriteLine("Bonus score: " + bonus);
        Console.WriteLine("Total score: " + (num + bonus));

    }
}
