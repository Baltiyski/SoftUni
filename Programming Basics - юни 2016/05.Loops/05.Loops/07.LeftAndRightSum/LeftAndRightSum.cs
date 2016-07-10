using System;

class LeftAndRightSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 1; i <= n*2; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                leftSum += num;
            }
            else if(i <= n)
            {
                leftSum += num;
            }
            else if (i > n)
            {
                rightSum += num;
            }

        }
        
        int resul = Math.Abs(leftSum - rightSum);
        if (resul == 0)
        {
            Console.WriteLine("Yes, sum = {0}",leftSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}",resul);
        }
        
    }
}
