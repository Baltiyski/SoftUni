using System;

class EmployeeData
{
    static void Main(string[] args)
    {

        string fName = Console.ReadLine();
        string lName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long idPerson = long.Parse(Console.ReadLine());
        int empNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine("First name: {0}",fName);
        Console.WriteLine("Last name: {0}", lName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", idPerson);
        Console.WriteLine("Unique Employee number: {0}", empNum);
        


    }
}
