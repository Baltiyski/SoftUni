using System;

class SumSeconds
{
    static void Main(string[] args)
    {
        int s1 = int.Parse(Console.ReadLine());
        int s2 = int.Parse(Console.ReadLine());
        int s3 = int.Parse(Console.ReadLine());

        int sum = s1 + s2 + s3;
        int sec = 0;

        if(sum >= 0 && sum <= 59)
        {
            sec = sum;
            if (sec < 10)
            {
                Console.WriteLine("0:0" + sec);
            }
            else
            {
                Console.WriteLine("0:" + sec);
            }
        }
        if (sum >= 60 && sum <= 119)
        {
            sec = sum - 60;
            if (sec < 10)
            {
                Console.WriteLine("1:0" + sec);
            }
            else
            {
                Console.WriteLine("1:" + sec);
            }
        }
        if (sum >= 120 && sum <= 179)
        {
            sec = sum - 120;
            if(sec < 10)
            {
                Console.WriteLine("2:0" + sec);
            }
            else
            {
                Console.WriteLine("2:" + sec);
            }
            
        }

    }
}
