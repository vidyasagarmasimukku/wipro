using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[6];
        int count = 0;
        Console.WriteLine("Enter 6 Elements:");
        for (int i = 0; i < 6; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            count++;
        }
        Console.WriteLine("Number of Elements = " + count);
    }
}
