using System;

class Elevator
{
    static void Main(string[] args)
    {
        int person = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int course = 0;

        int leftpeople = person % capacity;
        if (leftpeople > 0 )
        {
            course = (person / capacity) + 1;
        }
        else
        {
            course = person / capacity;
        }
        Console.WriteLine(course);
    }
}
