using System;

class MinMaxSumNAverageFromNumbers
{
    static void Main()
    {
        Console.Write("Write how many numbers you want to input: ");
        int howManyNum = int.Parse(Console.ReadLine());

        int numbers;
        int min = 0;
        int max = 0;
        int sum = 0;
        double average = 0;


        for (int i = 1; i <= howManyNum; i++)
        {
            Console.WriteLine("For place {0}, number: ",i);
            numbers = int.Parse(Console.ReadLine());

            if (i == 1)
            {
                min = numbers;
                max = numbers;
            }
            if (numbers > max)
            {
                max = numbers;
            }
            else if (numbers < min)
            {
                min = numbers;
            }
            sum += numbers;
        }

        average = (double)sum / howManyNum;

        Console.WriteLine();
        Console.WriteLine("Minimal number is {0}",min);
        Console.WriteLine("Maximal number is {0}",max);
        Console.WriteLine("The sum of the numbers is = {0}",sum);
        Console.WriteLine("The average of this numbers is = {0:F2}",average);
    }
}
