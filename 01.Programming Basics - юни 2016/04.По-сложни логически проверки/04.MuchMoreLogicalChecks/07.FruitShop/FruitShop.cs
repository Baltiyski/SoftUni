using System;

class FruitShop
{
    static void Main(string[] args)
    {
        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double amount = double.Parse(Console.ReadLine());

        switch (fruit)
        {
            case "banana":
                if(day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday") 
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}",amount * 2.50);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}",amount * 2.70);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "apple":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 1.20);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 1.25);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "orange":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 0.85);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 0.90);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "grapefruit":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 1.45);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 1.60);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "kiwi":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 2.70);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 3.00);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "pineapple":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 5.50);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 5.60);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            case "grapes":
                if (day.Equals("Monday") || day.Equals("Tuesday") || day.Equals("Wednesday") || day.Equals("Thursday")
                    || day.Equals("Friday"))
                {
                    Console.WriteLine("{0:F2}", amount * 3.85);
                }
                else if (day.Equals("Saturday") || day.Equals("Sunday"))
                {
                    Console.WriteLine("{0:F2}", amount * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }
                break;
            default:
                Console.WriteLine("error");
                break;
        }
    }
}
