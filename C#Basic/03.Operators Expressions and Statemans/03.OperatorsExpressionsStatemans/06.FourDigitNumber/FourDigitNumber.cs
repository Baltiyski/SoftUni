using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter fourd digit number : ");
        int number = int.Parse(Console.ReadLine());

        //fourth digit
        int firstDigit = number % 10;

        //third digit
        int restNumberTwo = number / 10;
        int secondDigit = restNumberTwo % 10;

        //second digit
        int restNumberTree = number / 100;
        int thirdDigit = restNumberTree % 10;

        //first digit
        int restNumberFour = number / 1000;
        int fourthDigit = restNumberFour % 10;

        Console.WriteLine("Sum of digit's : {0}",(firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Reversed : {0}{1}{2}{3}",firstDigit,secondDigit,thirdDigit,fourthDigit);
        Console.WriteLine("Last digit in front : {0}{1}{2}{3}",firstDigit,fourthDigit,thirdDigit,secondDigit);
        Console.WriteLine("Second and Tird digits exchange : {0}{1}{2}{3}",fourthDigit,secondDigit,thirdDigit,firstDigit);

    }
}
