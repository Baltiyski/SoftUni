using System;

class ThreeEqualNumbers
{
    static void Main(string[] args)
    {
        int num00 = int.Parse(Console.ReadLine());
        int num01 = int.Parse(Console.ReadLine());
        int num02 = int.Parse(Console.ReadLine());

        if ((num00 == num01) && (num01 == num02))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
