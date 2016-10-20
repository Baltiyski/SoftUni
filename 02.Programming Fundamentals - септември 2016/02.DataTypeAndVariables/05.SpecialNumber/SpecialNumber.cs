using System;

class SpecialNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int secondNum = 0;
        int copyI = 0;
        int copyNum = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i < 10)
            {
                if (i == 5 || i == 7)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
            else
            {
                copyNum = i;
                while (copyNum > 0)
                {
                    secondNum = copyNum % 10;
                    copyNum = copyNum / 10;
                    copyI = copyI + secondNum;
                }

                if (copyI == 5 || copyI == 7 || copyI == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
            copyI = 0;
        }
        
    }
}
