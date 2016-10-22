using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int num = int.Parse(Console.ReadLine());

        if (num < 1 || num > 7)
        {
            Console.WriteLine("Invalid Day!");
        }
        else
        {
            Console.WriteLine(dayOfWeek[num - 1]);
        }
       
    }
}
