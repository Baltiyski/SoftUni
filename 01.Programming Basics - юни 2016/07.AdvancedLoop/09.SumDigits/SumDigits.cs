using System;

class SumDigits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long result = 1;
        int copyN = 0;

        
        while (n > 0)
        {
            copyN = n % 10;
            result += copyN;
            n = n / 10;
        }

        Console.WriteLine(result - 1);
       
    }
}
