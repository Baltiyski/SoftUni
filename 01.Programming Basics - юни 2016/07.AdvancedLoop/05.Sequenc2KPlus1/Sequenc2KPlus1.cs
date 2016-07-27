using System;

class Sequenc2KPlus1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        int copyNum = 0;

        //Console.WriteLine(1);
        while (num < n)
        {
            copyNum = num;

            num = copyNum * 2 + 1;
            if (num > n)
            {

            }
            else
            {
                Console.WriteLine(num);
            }
                     
        }
    }
}
