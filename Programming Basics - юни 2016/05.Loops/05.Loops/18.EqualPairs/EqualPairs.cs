using System;

class EqualPairs
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        int first = 0;
        int second = 0;
        int sum = 0;
        int p = 1;
        int[] arr = new int[n];

        for (int i = 0; i < n*2; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                first = num;
            }
            else
            {
                second = num;
                sum = first + second;
                arr[i - p] = sum;
                p++;
            }
        }

    }
}
