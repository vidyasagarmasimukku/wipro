using System;
class RandomHelper
{
    static Random random = new Random();

    // Static method to generate random integer
    public static int RandInt(int min, int max)
    {
        return random.Next(min, max + 1);
    }
    // Static method to generate random double
    public static double RandDouble(int min, int max)
    {
        return min + random.NextDouble() * (max - min);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Random Integer : " + RandomHelper.RandInt(1, 10));
        Console.WriteLine("Random Double  : " + RandomHelper.RandDouble(1, 10).ToString("F2"));

        Console.ReadLine();
    }
}
