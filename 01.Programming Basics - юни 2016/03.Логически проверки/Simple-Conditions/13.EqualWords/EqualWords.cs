using System;

class EqualWords
{
    static void Main(string[] args)
    {
        string word00 = Console.ReadLine();
        string word01 = Console.ReadLine();

        word00 = word00.ToLower();
        word01 = word01.ToLower();

        if (word00 == word01)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
