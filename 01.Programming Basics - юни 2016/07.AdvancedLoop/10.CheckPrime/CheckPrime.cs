using System;

class CheckPrime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = false;

        if (n < 2)
        {
            Console.WriteLine("Not Prime");
        }
        else if (n == 2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime = true;
                }
            }

            if (!isPrime)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
