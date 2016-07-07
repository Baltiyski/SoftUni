using System;

class DeckOfCards
{
    static void Main()
    {
        char paint;

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i < 11)
                {
                    switch (j)
                    {
                        case (1):
                            Console.Write("{0}{1} ", i, paint = '\u2663');
                            break;
                        case (2):
                            Console.Write("{0}{1} ", i, paint = '\u2666');
                            break;
                        case (3):
                            Console.Write("{0}{1} ", i, paint = '\u2665');
                            break;
                        case (4):
                            Console.Write("{0}{1}", i, paint = '\u2660');
                            break;
                        default:
                            break;
                    }
                }
                else if (i == 11)
                {
                    switch (j)
                    {
                        case (1):
                            Console.Write("J{0} ",paint = '\u2663');
                            break;
                        case (2):
                            Console.Write("J{0} ",paint = '\u2666');
                            break;
                        case (3):
                            Console.Write("J{0} ",paint = '\u2665');
                            break;
                        case (4):
                            Console.Write("J{0}",paint = '\u2660');
                            break;
                        default:
                            break;
                    }
                }
                else if (i == 12)
                {
                    switch (j)
                    {
                        case (1):
                            Console.Write("Q{0} ", paint = '\u2663');
                            break;
                        case (2):
                            Console.Write("Q{0} ", paint = '\u2666');
                            break;
                        case (3):
                            Console.Write("Q{0} ", paint = '\u2665');
                            break;
                        case (4):
                            Console.Write("Q{0}", paint = '\u2660');
                            break;
                        default:
                            break;
                    }   
                }
                else if (i == 13)
                {
                    switch (j)
                    {
                        case (1):
                            Console.Write("K{0} ",paint = '\u2663');
                            break;
                        case (2):
                            Console.Write("K{0} ",paint = '\u2666');
                            break;
                        case (3):
                            Console.Write("K{0} ",paint = '\u2665');
                            break;
                        case (4):
                            Console.Write("K{0}",paint = '\u2660');
                            break;
                        default:
                            break;
                    }
                }
                else if (i == 14)
                {
                    switch (j)
                    {
                        case (1):
                            Console.Write("A{0} ",paint = '\u2663');
                            break;
                        case (2):
                            Console.Write("A{0} ",paint = '\u2666');
                            break;
                        case (3):
                            Console.Write("A{0} ",paint = '\u2665');
                            break;
                        case (4):
                            Console.Write("A{0}",paint = '\u2660');
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}