using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Input a number : ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Input a number : ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.Write("Input a number : ");
        double tirdNum = double.Parse(Console.ReadLine());

        double determinant = (secondNum * secondNum) - (4 * firstNum * tirdNum);

        double x1, x2;

        if (determinant < 0)
        {
            Console.WriteLine("No real roots!");            
        }
        else if (determinant == 0)
        {
            x1 = ((-secondNum - Math.Sqrt(determinant)) / (2 * firstNum));
            Console.WriteLine("Only one root x1 = {0}",x1);
        }
        else
        {
            x1 = ((-secondNum - Math.Sqrt(determinant)) / (2 * firstNum));
            x2 = ((-secondNum + Math.Sqrt(determinant)) / (2 * firstNum));
            Console.WriteLine("First root x1 = {0}    x2 = {1}",x1,x2);
        }
    }
}
