using System;

class RhombusOfStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n - row; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int col = 1; col < row; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        for (int row = n; row >= 2; row--)
        {
            for (int col = 1; col <= n - row + 1; col++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int col = 1; col < row - 1; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
