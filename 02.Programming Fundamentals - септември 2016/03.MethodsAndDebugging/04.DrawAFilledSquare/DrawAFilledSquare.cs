using System;

class DrawAFilledSquare
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        PrintHeaderRow(number);
        PrintMiddleRow(number);
        PrintLastRow(number);
    }

    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-',2 * n));
    }

    static void PrintMiddleRow(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 1; j <= n * 2 ; j++)
            {
                if (j == 1)
                {
                    Console.Write("-");
                }
                else if (j == (n * 2))
                {
                    Console.Write("-");
                }
                else if(j % 2==0)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write("/");
                }
            }
            Console.WriteLine();        
        }        
    }

    static void PrintLastRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
}
