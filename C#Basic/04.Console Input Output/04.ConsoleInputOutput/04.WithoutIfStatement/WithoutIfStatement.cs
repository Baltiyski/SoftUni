using System;

class WithoutIfStatement
{
    static void Main()
    {
        Console.Write("Input a number : ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Input a number : ");
        int secondNum = int.Parse(Console.ReadLine());

        int maxNum = Math.Max(firstNum, secondNum);

        Console.WriteLine(maxNum);
    }
}
