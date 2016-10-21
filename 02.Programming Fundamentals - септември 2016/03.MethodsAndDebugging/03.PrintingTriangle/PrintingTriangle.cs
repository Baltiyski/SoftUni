using System;

class PrintingTriangle
{
    static void Main(string[] args)
    {
        int endLine = int.Parse(Console.ReadLine());
        printTriangle(endLine);
        
    }

    static void printTriangle(int endLine)
    {
        for (int i = 1; i <= endLine; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        for (int i = endLine - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

    }
}
