using System;
using System.Text;

class CopyRightTriangle
{
    static void Main()
    {
        char s = '\u00A9';

        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine(@"
         {0}
        {0}{0}{0}
       {0}{0}{0}{0}{0}", s);
    }
}