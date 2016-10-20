using System;

class DaySalary
{
    static void Main(string[] args)
    {
        int workinDayInMonth = int.Parse(Console.ReadLine());
        double daySalary = double.Parse(Console.ReadLine());
        double usdToBgn = double.Parse(Console.ReadLine());

        double monthOfSalary = workinDayInMonth * daySalary;
        double yearSalary = (monthOfSalary * 12) + (monthOfSalary * 2.5);
        double payTaxex = yearSalary * 0.25;
        double clearYearSalary = (yearSalary - payTaxex) * usdToBgn;

        double avgDaySal = clearYearSalary / 365;
        Console.WriteLine("{0:F2}",avgDaySal);


    }
}
