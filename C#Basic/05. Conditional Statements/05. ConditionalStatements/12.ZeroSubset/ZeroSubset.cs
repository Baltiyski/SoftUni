using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter the first number : ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number : ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the next number : ");
        int tirdNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the next number : ");
        int fourthNum = int.Parse(Console.ReadLine());

        Console.Write("Enter the next number : ");
        int fiftNum = int.Parse(Console.ReadLine());

        bool isZero = false;

        Console.WriteLine();

        if ((firstNum + secondNum + tirdNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} + {4} = 0", 
                                                                firstNum, secondNum, tirdNum, fourthNum, fiftNum);
        }
        if ((firstNum + secondNum + tirdNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} = 0", 
                                                                firstNum, secondNum, tirdNum, fourthNum);
        }
        if ((firstNum + secondNum + tirdNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} = ", 
                                                                firstNum, secondNum, tirdNum, fiftNum);
        }
        if ((firstNum + secondNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} = 0", 
                                                                firstNum, secondNum, fourthNum, fiftNum);
        }
        if ((firstNum + tirdNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} = 0", 
                                                                firstNum, tirdNum, fourthNum, fiftNum);
        }
        if ((secondNum + tirdNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} + {3} = 0", 
                                                                secondNum, tirdNum, fourthNum, fiftNum);
        }
        if ((firstNum + secondNum + tirdNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, secondNum, tirdNum);
        }
        if ((firstNum + secondNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, secondNum, fourthNum);
        }
        if ((firstNum + secondNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, secondNum, fiftNum);
        }
        if ((firstNum + tirdNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, tirdNum, fourthNum);
        }
        if ((firstNum + tirdNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, tirdNum, fiftNum);
        }
        if ((firstNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", firstNum, fourthNum, fiftNum);
        }
        if ((secondNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", secondNum, fourthNum, fiftNum);
        }
        if ((tirdNum + fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", tirdNum, fourthNum, fiftNum);
        }
        if ((secondNum + tirdNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", secondNum, tirdNum, fourthNum);
        }
        if ((secondNum + tirdNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} + {2} = 0", secondNum, tirdNum, fiftNum);
        }
        if ((firstNum + secondNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", firstNum, secondNum);
        }
        if ((firstNum + tirdNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", firstNum, tirdNum);
        }
        if ((firstNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", firstNum, fourthNum);
        }
        if ((firstNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", firstNum, fiftNum);
        }
        if ((secondNum + tirdNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", secondNum, tirdNum);
        }
        if ((secondNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", secondNum, fourthNum);
        }
        if ((secondNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", secondNum, fiftNum);
        }
        if ((tirdNum + fourthNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", tirdNum, fourthNum);
        }
        if ((tirdNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", tirdNum, fiftNum);
        }
        if ((fourthNum + fiftNum) == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0} + {1} = 0", fourthNum, fiftNum);
        }
        if (firstNum == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0}", firstNum);
        }
        if (secondNum == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0}", secondNum);
        }
        if (tirdNum == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0}", tirdNum);
        }
        if (fourthNum == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0}", fourthNum);
        }
        if (fiftNum == 0)
        {
            isZero = true;
            Console.WriteLine("This Subset is Zero: {0}", fiftNum);
        }
        if (!isZero)
        {
            Console.WriteLine("No zero subset!");
        }
        Console.WriteLine();
    }
}