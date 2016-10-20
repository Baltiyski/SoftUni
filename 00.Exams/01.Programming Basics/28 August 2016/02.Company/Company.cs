using System;

class Company
{
    static void Main(string[] args)
    {
        int hourOfTask = int.Parse(Console.ReadLine());
        int compDayForTask = int.Parse(Console.ReadLine());
        int personsForAfterWork = int.Parse(Console.ReadLine());

        double hoursForTraining = (compDayForTask - (compDayForTask * 0.1)) * 8;
        double allAfterWorkHours = personsForAfterWork * compDayForTask * 2;
        double allHoursOfWorking = allAfterWorkHours + hoursForTraining;

        if (allHoursOfWorking < hourOfTask)
        {
            double num = hourOfTask - allHoursOfWorking;
            Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(num));
        }
        else
        {
            double num = allHoursOfWorking - hourOfTask;
            Console.WriteLine("Yes!{0} hours left.", Math.Floor(num));
        }
    }
}
