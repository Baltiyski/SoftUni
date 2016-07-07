using System;

class NumberWithWord
{
    static void Main()
    {
        Console.Write("Write a number from \"0 to 999\"\nThe number = ");

        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Error!");
            return;
        }

        Console.Write("Number with word's: ");
        if (number >= 100)
        {
            int hundred = number / 100;
            switch (hundred)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    Console.WriteLine("Unexpected Error !!!");
                    break;
            }
            if ((number % 100) > 0)
            {
                Console.Write("and ");
                int tenth = (number % 100) / 10;
                if (tenth >= 1)
                {
                    switch (tenth)
                    {
                        case 1:
                            switch ((number % 100) % 10)
                            {
                                case 0:
                                    Console.WriteLine("ten !");
                                    Console.ReadLine();
                                    return;
                                case 1:
                                    Console.WriteLine("eleven !");
                                    Console.ReadLine();
                                    return;
                                case 2:
                                    Console.WriteLine("twelve !");
                                    Console.ReadLine();
                                    return;
                                case 3:
                                    Console.WriteLine("thirteen !");
                                    Console.ReadLine();
                                    return;
                                case 4:
                                    Console.WriteLine("fourteen !");
                                    Console.ReadLine();
                                    return;
                                case 5:
                                    Console.WriteLine("fifteen !");
                                    Console.ReadLine();
                                    return;
                                case 6:
                                    Console.WriteLine("sixteen !");
                                    Console.ReadLine();
                                    return;
                                case 7:
                                    Console.WriteLine("seventeen !");
                                    Console.ReadLine();
                                    return;
                                case 8:
                                    Console.WriteLine("eighteen !");
                                    Console.ReadLine();
                                    return;
                                case 9:
                                    Console.WriteLine("nineteen !");
                                    Console.ReadLine();
                                    return;
                            }
                            break;
                        case 2:
                            Console.Write("twenty ");
                            break;
                        case 3:
                            Console.Write("thirty ");
                            break;
                        case 4:
                            Console.Write("forty ");
                            break;
                        case 5:
                            Console.Write("fifty ");
                            break;
                        case 6:
                            Console.Write("sixty ");
                            break;
                        case 7:
                            Console.Write("seventy ");
                            break;
                        case 8:
                            Console.Write("eighty ");
                            break;
                        case 9:
                            Console.Write("ninety ");
                            break;
                        default:
                            Console.WriteLine("Unexpected Error !!!");
                            break;
                    }
                }
                int remainder = (number % 100) % 10;
                if (remainder > 0)
                {
                    switch (remainder)
                    {
                        case 1:
                            Console.Write("one ");
                            break;
                        case 2:
                            Console.Write("two ");
                            break;
                        case 3:
                            Console.Write("three ");
                            break;
                        case 4:
                            Console.Write("four ");
                            break;
                        case 5:
                            Console.Write("five ");
                            break;
                        case 6:
                            Console.Write("six ");
                            break;
                        case 7:
                            Console.Write("seven ");
                            break;
                        case 8:
                            Console.Write("eight ");
                            break;
                        case 9:
                            Console.Write("nine ");
                            break;
                        default:
                            Console.WriteLine("Unexpected Error !!!");
                            break;
                    }
                }
            }
        }
        else if (number < 100 && number >= 20)
        {
            int tenth = (number % 100) / 10;
            switch (tenth)
            {
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Forty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
                default:
                    Console.WriteLine("Unexpected Error !!!");
                    break;
            }
            int remainder = (number % 100) % 10;
            if (remainder > 0)
            {
                switch (remainder)
                {
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    default:
                        Console.WriteLine("Unexpected Error !!!");
                        break;
                }
            }
        }
        else if (number >= 0 && number < 20)
        {
            switch (number)
            {
                case 0:
                    Console.Write("Zero ");
                    break;
                case 1:
                    Console.Write("One ");
                    break;
                case 2:
                    Console.Write("Two ");
                    break;
                case 3:
                    Console.Write("Three ");
                    break;
                case 4:
                    Console.Write("Four ");
                    break;
                case 5:
                    Console.Write("Five ");
                    break;
                case 6:
                    Console.Write("Six ");
                    break;
                case 7:
                    Console.Write("Seven ");
                    break;
                case 8:
                    Console.Write("Eight ");
                    break;
                case 9:
                    Console.Write("Nine ");
                    break;
                case 10:
                    Console.Write("Ten ");
                    break;
                case 11:
                    Console.Write("Eleven ");
                    break;
                case 12:
                    Console.Write("Twelve ");
                    break;
                case 13:
                    Console.Write("Thirteen ");
                    break;
                case 14:
                    Console.Write("Fourteen ");
                    break;
                case 15:
                    Console.Write("Fifteen ");
                    break;
                case 16:
                    Console.Write("Sixteen ");
                    break;
                case 17:
                    Console.Write("Seventeen ");
                    break;
                case 18:
                    Console.Write("Eighteen ");
                    break;
                case 19:
                    Console.Write("Nineteen ");
                    break;
                default:
                    Console.WriteLine("Unexpected Error");
                    break;
            }
        }
        Console.WriteLine();
    }
}

