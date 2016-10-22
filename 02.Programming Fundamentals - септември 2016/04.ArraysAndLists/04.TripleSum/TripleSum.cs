using System;

class TripleSum
{
    static void Main(string[] args)
    {
        string value = Console.ReadLine();
        string[] items = value.Split(' ');

        int[] arr = new int[items.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(items[i]);
        }

        bool sumFound = false;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] + arr[j] == arr[k])
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                        sumFound = true;
                        break;
                    }
                }
            }
        }

        if (!sumFound)
        {
            Console.WriteLine("No");
        }
    }
}
