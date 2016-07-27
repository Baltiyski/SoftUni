using System;

class InchesToCentimeters
{
    static void Main(string[] args)
    {
        Console.Write("inches = ");
        var inches = double.Parse(Console.ReadLine());
        var centimeters = inches * 2.54;
        Console.Write("Centimeters = ");
        Console.WriteLine(centimeters);
    }
}
