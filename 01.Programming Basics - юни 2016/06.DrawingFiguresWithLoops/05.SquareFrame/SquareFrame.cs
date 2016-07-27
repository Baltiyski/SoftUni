using System;

class SquareFrame
{
    static void Main(string[] args)
    {
        int stars = int.Parse(Console.ReadLine());

        for (int i = 0; i < stars; i++)
        {
            for (int j = 0; j < stars; j++)
            {
                if ((j == 0 || j == stars -1) && (i == 0 || i == stars - 1))
                {
                    if (stars < 3)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("+");
                    }
                    
                }
                else if (j >= 1 && j <= stars - 2)
                {
                    if (j == stars - 2)
                    {
                       Console.Write(" - ");
                    }
                    else if (j == 1)
                    {
                        Console.Write(" -");
                    }
                    else
                    {
                        Console.Write(" -");
                    }
                    
                }
                else
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
        }
    }
}
