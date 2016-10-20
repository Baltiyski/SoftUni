using System;

class RefactorSpecialNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int secondNum = 0;
        int copyI = 0;
        bool special = false;
        for (int ch = 1; ch <= number; ch++)
        {
            copyI = ch;
            while (ch > 0)
            {
                secondNum += ch % 10;
                ch = ch / 10;
            }
            special = (secondNum == 5) || (secondNum == 7) || (secondNum == 11);
            Console.WriteLine("{0} -> {1}", copyI, special);
            secondNum = 0;
            ch = copyI;
        }
    }
}
