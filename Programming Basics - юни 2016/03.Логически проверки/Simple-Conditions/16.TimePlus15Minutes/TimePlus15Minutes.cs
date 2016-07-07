using System;

class TimePlus15Minutes
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int fifteen = 15;

        minute += fifteen;

        if (minute > 59)
        {
            hour += 1;
            if (hour > 23)
            {
                hour = 0;
            }
            minute -= 60;
        }
        if (minute < 9)
        {
            Console.WriteLine("{0}:0{1}",hour,minute);
        }
        else
        {
            Console.WriteLine("{0}:{1}", hour, minute);
        }
        
    }
}
