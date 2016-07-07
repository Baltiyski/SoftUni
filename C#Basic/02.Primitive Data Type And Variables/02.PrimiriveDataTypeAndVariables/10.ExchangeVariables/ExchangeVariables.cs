using System;

class ExchangeVariables
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;

        Console.WriteLine("a = {0} \nb = {1}",a,b);

        //buffer helps to exchange variables
        byte buffer = a;
        a = b;
        b = buffer;

        Console.WriteLine("Now a = {0} \nNow b = {1}",a,b);
    }
}
