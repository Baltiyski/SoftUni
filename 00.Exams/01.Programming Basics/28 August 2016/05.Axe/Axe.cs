using System;

class Axe
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int i = 1;
        int howManyrow = 0;

        if (num >= 2 && num <= 42)
        {
            if (num % 2 == 0)
            {
                howManyrow = num * 2;
            }
            else
            {
                howManyrow = (num * 2) - 1;
            }

            for (int row = 1; row <= num; row++)
            {
                for (int coll = 1; coll <= num * 5; coll++)
                {
                    if (row <= num && (coll == num * 3 + 1))
                    {
                        Console.Write("*");
                    }
                    if (coll == num * 3 + i)
                    {
                        Console.Write("*");

                    }
                    else if (coll < num * 5)
                    {
                        Console.Write("-");
                    }
                }
                i++;
                Console.WriteLine();
            }

            int copyNum = num;

            if (copyNum % 2 == 0)
            {
                copyNum = num / 2;
            }
            else
            {
                copyNum = num % 2 + 1;
            }

            for (int row = 1; row <= copyNum; row++)
            {
                for (int coll = 1; coll <= num * 5; coll++)
                {
                    if (coll == (num * 5) - (num - 1) || coll < num * 3 + 2)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            i = 1;
            for (int row = 1; row <= copyNum; row++)
            {

                for (int coll = 1; coll <= num * 5; coll++)
                {

                    if (row < copyNum)
                    {
                        if (row == i && (coll == (num * 5) - (num - i) || coll == num * 3 - i + 2))
                        {
                            Console.Write("*");
                        }

                        else
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        if (coll >= num * 3 - (row - 2))
                        {
                            if (coll >= num * 5 - num + row + 1)
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write("*");
                            }

                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }

                }
                i++;
                Console.WriteLine();
            }
        }
        
    }
}
