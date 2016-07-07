using System;

class EmployeeDate
{
    static void Main()
    {
        String firstName = "Stefan";
        String lastName = "Baltiyski";
        byte age = 24;
        bool isMale = true;
        long personalID = 8306112507;
        int uniqueEmployeNum = 27560000;

        Console.WriteLine("I'm am a Man - {0}",isMale);
        Console.WriteLine("My name is {0} {1}, and i'm am at {2} years old!", firstName, lastName, age);
        Console.WriteLine("My personal ID is {0} \nMy Uniqew Employe Number is {1}",personalID,uniqueEmployeNum);
    }
}
