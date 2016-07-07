using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Write how many numbers want to input: ");
        int howNumbers = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= howNumbers; i++)
        {
            Console.Write("Write {0} number - ",i);
            int numbers = int.Parse(Console.ReadLine());

            sum += numbers;
        }

        Console.WriteLine("Sum of this five number's is = {0}",sum);
    }
}
