using System;

class ManWeightOnMoon
{
    static void Main()
    {
        Console.Write("How weight you are : ");
        double manWeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Your weght on the Moon is : {0}", manWeight * 0.17 );
    }
}
