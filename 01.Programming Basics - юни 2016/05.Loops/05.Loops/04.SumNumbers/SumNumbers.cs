using System;

class SumNumbers
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < input; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;

        }
        Console.WriteLine(sum);
    }
}
