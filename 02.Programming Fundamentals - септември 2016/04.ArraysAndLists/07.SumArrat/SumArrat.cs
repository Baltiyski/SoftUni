using System;

class SumArrat
{
    static void Main(string[] args)
    {
        string firstArrInput = Console.ReadLine();
        string[] firstArr = firstArrInput.Split(' ');
        int[] arrFirst = new int[firstArr.Length];

        string secondArrInput = Console.ReadLine();
        string[] secondArr = secondArrInput.Split(' ');
        int[] arrSecond = new int[secondArr.Length];

        for (int i = 0; i < firstArr.Length; i++)
        {
            arrFirst[i] = int.Parse(firstArr[i]);
        }
        for (int i = 0; i < secondArr.Length; i++)
        {
            arrSecond[i] = int.Parse(secondArr[i]);
        }

        int maxLength = Math.Max(firstArr.Length, secondArr.Length);
        int[] resultArray = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            resultArray[i] = arrFirst[i % firstArr.Length] + arrSecond[i % secondArr.Length];
        }

        Console.WriteLine(string.Join(" ",resultArray));
    }
}
