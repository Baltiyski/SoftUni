using System;

class PrimeNimber
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = false;

        if (number == 0 || number == 1)
        {
            Console.WriteLine("Prime = " + isPrime);
        }
        else if (number == 2 || number == 3 || number == 5 || number == 7)
        {
            isPrime = true;
            Console.WriteLine("Prime = " + isPrime);
        }
        else if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 ||
                 number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0)
        {
            Console.WriteLine("Prime = " + isPrime);
        }
        else
        {
            isPrime = true;
            Console.WriteLine("Prime = " + isPrime);
        }
    }
}
