using System;

class VowelsSum
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        int sum = 0;

        char letterA = 'a';
        char letterE = 'e';
        char letterI = 'i';
        char letterO = 'o';
        char letterU = 'u';

        foreach (var lett in word)
        {
            if (lett.Equals(letterA))
            {
                sum += 1;
            }
            else if (lett.Equals(letterE))
            {
                sum += 2;
            }
            else if (lett.Equals(letterI))
            {
                sum += 3;
            }
            else if (lett.Equals(letterO))
            {
                sum += 4;
            }
            else if (lett.Equals(letterU))
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}
