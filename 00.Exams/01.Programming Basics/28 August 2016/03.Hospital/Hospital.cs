using System;

class Hospital
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int[] patients = new int[num];

        int treat = 0;
        int untreat = 0;

        int personal = 7;

        for (int i = 0; i < patients.Length; i++)
        {
            patients[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < patients.Length; i++)
        {
            if ((i + 1) % 3 == 0 && i > 0)
            {
                if (treat < untreat)
                {
                    personal++;
                }
            }
            if (patients[i] <= personal)
            {
                treat += patients[i];
            }
            else if (patients[i] > personal)
            {
                untreat += patients[i] - personal;
                treat += personal;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Treated patients: {0}.",treat);
        Console.WriteLine("Untreated patients: {0}.", untreat);
    }
}
