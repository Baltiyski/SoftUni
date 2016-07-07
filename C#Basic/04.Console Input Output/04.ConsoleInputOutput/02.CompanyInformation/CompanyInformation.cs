using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Fill the Company information!");

        Console.Write("Company name : ");
        String companyName = Console.ReadLine();

        Console.Write("Address : ");
        String address = Console.ReadLine();

        Console.Write("Phone number : ");
        int companyNumber = int.Parse(Console.ReadLine());

        Console.Write("Fax number");
        int faxNumber = int.Parse(Console.ReadLine());

        Console.Write("Web site : ");
        String webSite = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Fill the manager information!");

        Console.Write("Manager name : ");
        String managerName = Console.ReadLine();

        Console.Write("Manager age : ");
        short age = short.Parse(Console.ReadLine());

        Console.Write("Manager phone number : ");
        int managerPhoneNum = int.Parse(Console.ReadLine());
    }
}
