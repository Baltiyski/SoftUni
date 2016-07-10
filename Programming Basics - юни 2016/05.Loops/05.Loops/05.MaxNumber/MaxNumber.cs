using System;

class MaxNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int greatherNum = 0;

        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    greatherNum = num;
                }
                else if(num > greatherNum)
                {
                    greatherNum = num;
                }
            }
            Console.WriteLine(greatherNum);
        }
    }
}
