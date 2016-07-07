using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        byte type = byte.Parse(Console.ReadLine());

        double number;

        switch (type)
        {
            case (1):
                Console.Write("Write a number : ");
                number = int.Parse(Console.ReadLine());
                number += 1;
                Console.WriteLine(number);
                break;
            case (2):
                Console.Write("Write a number : ");
                number = double.Parse(Console.ReadLine());
                number += 1;
                Console.WriteLine(number);
                break;
            case (3):
                Console.Write("Write a word : ");
                string word = Console.ReadLine();
                word = word + "*";
                Console.WriteLine(word);
                break;
            default:
                break;
        }
    }
}
