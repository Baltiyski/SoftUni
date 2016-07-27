using System;

class FruitOrVegetable
{
    static void Main(string[] args)
    {
        string grocery = Console.ReadLine();

        if (grocery == "banana" || grocery == "apple" || grocery == "kiwi" || grocery == "cherry" || grocery == "lemon" ||
            grocery == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (grocery == "tomato" || grocery == "cucumber" || grocery == "pepper" || grocery == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
