using System;

class VowelOrDigit
{
    static void Main(string[] args)
    {
        int i = 0;
        string letter = Console.ReadLine();
        bool result = int.TryParse(letter, out i);
                                         
        if (letter == "A" || letter == "a" ||
            letter == "E" || letter == "E" ||
            letter == "I" || letter == "i" ||
            letter == "O" || letter == "o" ||
            letter == "U" || letter == "u" ||
            letter == "Y" || letter == "y")
        {
            Console.WriteLine("vowel");
        }
        else if (result)
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
