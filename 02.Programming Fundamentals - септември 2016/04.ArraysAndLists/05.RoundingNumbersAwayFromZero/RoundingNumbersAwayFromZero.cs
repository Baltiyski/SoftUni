using System;

class RoundingNumbersAwayFromZero
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] items = input.Split(' ');
        double[] numbers = new double[items.Length];
        int[] roundedNum = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(items[i]);
        }

        for (int i = 0; i < roundedNum.Length; i++)
        {
            roundedNum[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            Console.WriteLine("{0} => {1}",numbers[i], roundedNum[i]);
        }

        
    }
}
