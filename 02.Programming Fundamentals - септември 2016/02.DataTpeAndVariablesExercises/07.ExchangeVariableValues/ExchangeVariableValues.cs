using System;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before: \na = {0} \nb = {1}",a,b);

        int buffer = a;
        a = b;
        b = buffer;
        Console.WriteLine("After: \na = {0} \nb = {1}", a, b);
    }
}
