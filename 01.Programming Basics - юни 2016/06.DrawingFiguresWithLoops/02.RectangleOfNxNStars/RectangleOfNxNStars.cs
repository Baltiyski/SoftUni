using System;

class RectangleOfNxNStars
{
    static void Main(string[] args)
    {
        int stars = int.Parse(Console.ReadLine());

        for (int i = 0; i < stars; i++)
        {
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
