using System;
class TriangleOfDollars
{
    static void Main(string[] args)
    {
        int stars = int.Parse(Console.ReadLine());

        for (int i = 0; i < stars; i++)
        {
            Console.Write("$");
            for (int j = 0; j < i; j++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }
    }
}
