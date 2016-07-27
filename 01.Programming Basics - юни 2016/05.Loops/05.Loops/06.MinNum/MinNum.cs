using System;

class MinNum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int smallNum = 0;

        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    smallNum = num;
                }
                else if (num < smallNum)
                {
                    smallNum = num;
                }
            }
            Console.WriteLine(smallNum);
        }
    }
}
