using System;

class Greeting
{
    static void Main(string[] args)
    {
        String fName = Console.ReadLine();
        String lName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Hello, {0} {1}. You are {2} years old.",fName, lName, age);
    }
}
