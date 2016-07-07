using System;

class FormatingNumbers
{
    static void Main()
    {

        Console.Write("Write a number it's greater then 0 and smaller then 500 : ");
        int numberOne;
        while (!int.TryParse(Console.ReadLine(), out numberOne) || numberOne < 0 || numberOne > 500)
        {
            Console.WriteLine("Error! Try agayn!");
            Console.Write("Write a number it's greater then 0 and smaller then 500 : ");
        }

        Console.Write("Write a number : ");
        double numberTwo = double.Parse(Console.ReadLine());

        Console.Write("Write a number : ");
        double numberThree = double.Parse(Console.ReadLine());

        Console.Write("|{0, -10:X}|{1}|{2}|", numberOne, Convert.ToString(numberOne, 2).PadLeft(10, '0'), 
                                                                        numberTwo.ToString().PadLeft(10, ' '));

        bool check = Convert.ToString(numberThree).IndexOf(".") > 0;
        Console.WriteLine(check ? "{0:0.000}         |" : "{0}", numberThree);

        Console.WriteLine();

    }
}
