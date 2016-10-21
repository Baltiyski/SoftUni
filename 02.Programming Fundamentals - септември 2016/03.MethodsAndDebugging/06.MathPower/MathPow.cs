using System;

class MathPow
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        double toPower = double.Parse(Console.ReadLine());
        Console.WriteLine(ReiseToPower(number,toPower));
    }

    static double ReiseToPower(double number, double toPower)
    {
        double result = 0d;
        result = Math.Pow(number, toPower);

        return result;
    }
}
