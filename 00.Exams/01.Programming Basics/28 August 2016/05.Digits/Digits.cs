using System;

class Digits
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int firstDig = num /100 ;
        int midDig = num / 10;
        midDig = midDig % 10;
        int lastDig = num % 10;

        int row = firstDig + midDig;
        int coll = firstDig + lastDig;

        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= coll; j++)
            {
                if (num % 5 == 0)
                {
                    num -= firstDig;
                    Console.Write(num + " ");
                }
                else if (num % 3 == 0)
                {
                    num -= midDig;
                    Console.Write(num + " ");
                }
                else
                {
                    num += lastDig;
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
