using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Type yor age : ");
        short age = short.Parse(Console.ReadLine());

        Console.WriteLine("Your age is {0}, after 10 years wil bie at {1} year old!",age, age+10);
    }   
}