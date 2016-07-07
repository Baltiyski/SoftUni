using System;
using System.Numerics;

class FactorialsDivision2
{
    static void Main()
    {
        Console.Write("Please, enter a whole number, bigger from 1 for K = ");
        string numberStr = Console.ReadLine();
        int numK = int.Parse(numberStr);
        Console.Write("Enter other whole number, bigger from K for N = ");
        numberStr = Console.ReadLine();
        int numN = int.Parse(numberStr);
        if (numK < 2 || numN < 3 || numN <= numK || numK >= 100 || numN >= 100)
        {
            Console.WriteLine("Error - Invalid Input !!!");
        }
        else
        {
            BigInteger factorialNtoK = 1;
            for (int i = numN; i > numK; i--)
            {
                factorialNtoK *= i;
            }
 
            BigInteger dividerFactorial = 1;
            for (int j = 2; j <= (numN - numK); j++)
            {
                dividerFactorial *= j;
            }
 
            BigInteger resultDivision = factorialNtoK / dividerFactorial;
            Console.WriteLine("The result from that factorials division is:");
            Console.WriteLine("RESULT = {0} !", resultDivision);
        }
        Console.ReadLine();
    }
}
