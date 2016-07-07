using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Write("What's your first name : ");
        String firstName = Console.ReadLine();

        Console.Write("What's your last name : ");
        String lastName = Console.ReadLine();


        String myFirstName = "Stefan";
        String myLastName = "Baltiyski";

        Console.WriteLine("Hy {0} {1}, my name is {2} {3}!",firstName,lastName,myFirstName,myLastName);
    }
}
