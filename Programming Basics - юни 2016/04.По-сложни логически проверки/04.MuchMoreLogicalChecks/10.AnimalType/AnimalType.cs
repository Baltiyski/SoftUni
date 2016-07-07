using System;

class AnimalType
{
    static void Main(string[] args)
    {
        string animal = Console.ReadLine();

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "snake":
            case "crocodile":
            case "tortoise":
                Console.WriteLine("reptile");
                break;
            case "cat":
                Console.WriteLine("unknown");
                break;
            default:
                break;
        }
    }
}
