using System;

class From0to100ToText
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int e = 0;
        int s = 0;
        string dec = "";
        string f = "";

        if (num >= 0 && num <=100)
        {
            if (num < 9)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Zero");
                        break;
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    default:
                        break;
                }
            }
            if (num > 9 && num <= 20)
            {
                switch (num)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 14:
                        Console.WriteLine("Fourteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;
                    case 16:
                        Console.WriteLine("Sixteen");
                        break;
                    case 17:
                        Console.WriteLine("Seventeen");
                        break;
                    case 18:
                        Console.WriteLine("Eighteen");
                        break;
                    case 19:
                        Console.WriteLine("Nineteen");
                        break;
                    case 20:
                        Console.WriteLine("twenty");
                        break;
                    default:
                        break;
                }
            }
            if (num >= 21 && num <= 99)
            {

                e = num / 10; //first num
                s = num % 10;//second num

                switch (s)
                {
                    case 0:
                        f = null;
                        break;
                    case 1:
                        f = "one";
                        break;
                    case 2:
                        f = "two";
                        break;
                    case 3:
                        f = "three";
                        break;
                    case 4:
                        f = "four";
                        break;
                    case 5:
                        f = "five";
                        break;
                    case 6:
                        f = "six";
                        break;
                    case 7:
                        f = "seven";
                        break;
                    case 8:
                        f = "eight";
                        break;
                    case 9:
                        f = "nine";
                        break;
                    default:
                        break;
                }
                switch (e)
                {
                    case 2:
                        dec = "twenty";
                        break;
                    case 3:
                        dec = "thirty";
                        break;
                    case 4:
                        dec = "fourty";
                        break;
                    case 5:
                        dec = "fifty";
                        break;
                    case 6:
                        dec = "sixty";
                        break;
                    case 7:
                        dec = "seventy";
                        break;
                    case 8:
                        dec = "eighty";
                        break;
                    case 9:
                        dec = "ninety";
                        break;
                    default:
                        break;
                }

                Console.WriteLine("{0} {1}", dec, f);
            }
            if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
        }
        else
        {
            Console.WriteLine("invalid number");
        }
        
    }
}
