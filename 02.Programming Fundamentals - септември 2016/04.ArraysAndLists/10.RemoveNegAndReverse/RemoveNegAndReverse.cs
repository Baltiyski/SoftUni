using System;
using System.Collections.Generic;

class RemoveNegAndReverse
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        List<int> nums = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                nums.Add(numbers[i]);
            }
        }


        //nums.Add(int.Parse(input[i]));
        if (nums.Count > 0)
        {
            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums));
        }
        else
        {
            Console.WriteLine("empty");
        }
        

        
        

    }
}
