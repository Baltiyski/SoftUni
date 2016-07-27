using System;

class NumberPyramid
{
    static void Main(string[] args)
    {
        
        int res = 0;

        if (n < 2)
        {
            Console.WriteLine(1);
        }
        if(n >= 2)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (res >= n)
                    {
                        break;
                    }
                    else
                    {
                        res = res + 1;
                        Console.Write("{0} ", res);
                    }
                }
                if (res < n)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    break;
                }

            }
        }
        
    }
}
