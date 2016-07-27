using System;
class GuesThePassword
{
    static void Main(string[] args)
    {
        string pass = "s3cr3t!P@ssw0rd";
        string input = Console.ReadLine();

        if (input == pass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}