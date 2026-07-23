using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        int sum = 0;
        Console.WriteLine("Enter 10 Numbers:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum = sum + arr[i];
        }
        // Descending Order
        for (int i = 0; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("\nDescending Order:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i] + " ");
        }
        int min = arr[9];
        int max = arr[0];
        Console.WriteLine("\n\nMinimum Value = " + min);
        Console.WriteLine("Maximum Value = " + max);
        Console.WriteLine("Sum = " + sum);
    }
}
