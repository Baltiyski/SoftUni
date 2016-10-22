using System;

class CondenseArrayToNumber
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int[] numbers = new int[input.Length];

        int[] condensed = new int[numbers.Length - 1];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        if (numbers.Length <= 1)
        {
            Console.WriteLine(numbers[0]);
        }
        else
        {
            for (int i = 0; i < condensed.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }

                Array.Copy(condensed, numbers, condensed.Length - i);
            }

            Console.WriteLine(condensed[0]);
        }  

    }
}
