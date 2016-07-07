using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Input first number : ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Inut second number : ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Input third number : ");
        int thirdNum = int.Parse(Console.ReadLine());

        int theSumOfNumbers = firstNum + secondNum + thirdNum;

        Console.WriteLine("The sum of the three numbers is : {0}", theSumOfNumbers);
    }
}
