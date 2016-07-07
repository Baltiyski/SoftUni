using System;

class PrintMyName
{
    static void Main()
    {
        Console.Write("What's your name - ");
        String yourName = Console.ReadLine();

        Console.WriteLine("Hy {0}, my name is Stefan!",yourName);
    }
}

