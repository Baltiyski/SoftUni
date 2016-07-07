using System;

class StringsAndObjects
{
    static void Main()
    {
        String hello = "Hello";
        String world = "World";

        object helloWorld = hello + " " + world;

        Console.WriteLine(helloWorld);

        string helloWorldObject = (string)helloWorld;
        Console.WriteLine(helloWorldObject);
    }
}
