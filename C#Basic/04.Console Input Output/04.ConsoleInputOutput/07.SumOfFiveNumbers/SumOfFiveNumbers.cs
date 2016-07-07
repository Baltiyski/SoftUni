using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Write five numbers, separated by space: ");
        string[] numbers = Console.ReadLine().Split();

        double firstNum = double.Parse(numbers[0]);
        double secondNum = double.Parse(numbers[1]);
        double TirdNum = double.Parse(numbers[2]);
        double fourthNum = double.Parse(numbers[3]);
        double fiftNum = double.Parse(numbers[4]);

        double sumOfFiveNumbers = firstNum + secondNum + TirdNum + fourthNum + fiftNum;

        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",firstNum,
                                secondNum,TirdNum,fourthNum,fiftNum,sumOfFiveNumbers);

    }
}
