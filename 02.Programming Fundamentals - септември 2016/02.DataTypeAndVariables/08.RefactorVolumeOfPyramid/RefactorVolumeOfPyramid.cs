using System;

class RefactorVolumeOfPyramid
{
    static void Main(string[] args)
    {
        double lengh, width, high = 0;
        Console.Write("Length: ");
        lengh = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        high = double.Parse(Console.ReadLine());
        high = (lengh * width * high) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", high);

    }
}
