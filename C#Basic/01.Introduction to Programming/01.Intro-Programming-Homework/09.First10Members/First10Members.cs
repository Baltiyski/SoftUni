using System;

class First10Members
{
    static void Main()
    {
        // for loop  - from 2 to 12 spin numbers
        for (int i = 2; i <= 12; i++)
        {
            //check for positive and negativ numbers,
            //if is negative print befor the numbers "-"
            if (i % 2 == 0)
            {
                Console.Write(i + ",");
            }
            else
            {
                Console.Write(-i + ",");
            }
        }

        //This is for new line - else "Press any key .." would be in the same line
        Console.WriteLine();
    }
}
