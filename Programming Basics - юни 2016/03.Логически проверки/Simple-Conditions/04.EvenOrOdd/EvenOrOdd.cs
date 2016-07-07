using System;
class EvenOrOdd
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
