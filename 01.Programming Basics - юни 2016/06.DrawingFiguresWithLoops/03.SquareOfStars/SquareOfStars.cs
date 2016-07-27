using System;

class SquareOfStars
{
    static void Main(string[] args)
    {
        int stars = int.Parse(Console.ReadLine());

        for (int i = 0; i < stars; i++)
        {
            Console.Write("*");
            for (int j = 0; j < stars - 1; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
