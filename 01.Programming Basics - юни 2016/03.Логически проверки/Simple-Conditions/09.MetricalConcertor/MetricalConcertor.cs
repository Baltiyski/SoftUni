using System;

class MetricalConcertor
{
    static void Main(string[] args)
    {
        //Metrical values form meter : 1m = ...
        double mm = 1000;
        double cm = 100;
        double mi = 0.000621371192;
        double inch = 39.3700787;
        double km = 0.001;
        double ft = 3.2808399;
        double yd = 1.0936133;

        double number = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        switch (from)
        {
            case "mm":
                if (to == "mm" && from == "mm")
                {
                    Console.WriteLine(number);
                }

                number = number / mm;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "cm":
                if (to == "cm" && from == "cm")
                {
                    Console.WriteLine(number);
                }

                number = number / cm;
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "m":
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "mi":
                if (to == "mi" && from == "mi")
                {
                    Console.WriteLine(number);
                }

                number = number / mi;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;

            case "in":
                if (to == "in" && from == "in")
                {
                    Console.WriteLine(number);
                }

                number = number / inch;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "km":
                if (to == "km" && from == "km")
                {
                    Console.WriteLine(number);
                }

                number = number / km;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "ft":
                if (to == "ft" && from == "ft")
                {
                    Console.WriteLine(number);
                }

                number = number / ft;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "yd")
                {
                    number *= yd;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            case "yd":
                if (to == "yd" && from == "yd")
                {
                    Console.WriteLine(number);
                }

                number = number / yd;
                if (to == "cm")
                {
                    number *= cm;
                    Console.WriteLine(number);
                }
                if (to == "mi")
                {
                    number *= mi;
                    Console.WriteLine(number);
                }
                if (to == "in")
                {
                    number *= inch;
                    Console.WriteLine(number);
                }
                if (to == "km")
                {
                    number *= km;
                    Console.WriteLine(number);
                }
                if (to == "ft")
                {
                    number *= ft;
                    Console.WriteLine(number);
                }
                if (to == "mm")
                {
                    number *= mm;
                    Console.WriteLine(number);
                }
                if (to == "m")
                {
                    Console.WriteLine(number);
                }
                break;
            default:
                break;
        }
    }
}
