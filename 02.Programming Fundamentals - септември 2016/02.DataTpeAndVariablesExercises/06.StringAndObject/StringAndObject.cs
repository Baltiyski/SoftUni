using System;

class StringAndObject
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";

        object helloW = hello + " " + world;
        Console.WriteLine(helloW);
    }
}