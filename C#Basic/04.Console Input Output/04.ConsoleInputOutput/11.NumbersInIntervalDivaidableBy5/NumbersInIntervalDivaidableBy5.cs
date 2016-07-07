using System;

class NumbersInIntervalDivaidableBy5
{
    static void Main()
    {
        Console.Write("Input a number from where to start : ");
        int startNumber = int.Parse(Console.ReadLine());

        Console.Write("Input a number from where to stop : ");
        int stopNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = startNumber; i <= stopNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ",");
                counter++;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("Interval betwen {0} and {1} hav {2} divaidable by 5!",startNumber,stopNumber,counter);
    }
}
