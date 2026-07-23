using System;
class Program
{
    static void Main()
    {
        string name;
        int m1, m2, m3;
        try
        {
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Marks 1: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks 3: ");
            m3 = Convert.ToInt32(Console.ReadLine())
            Console.WriteLine("\nStudent Name : " + name);
            Console.WriteLine("Total Marks : " + (m1 + m2 + m3));
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter only integer values for marks.");
        }
    }
}
