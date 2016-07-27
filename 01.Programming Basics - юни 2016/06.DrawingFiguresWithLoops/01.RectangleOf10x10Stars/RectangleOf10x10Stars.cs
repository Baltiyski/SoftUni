using System;

class RectangleOf10x10Stars
{
    static void Main(string[] args)
    {
        int stars = 10;

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
