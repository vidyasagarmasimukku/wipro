using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 % 10 == num2)
            Console.WriteLine("Second number is in Unit's place");
        else if ((num1 / 10) % 10 == num2)
            Console.WriteLine("Second number is in Ten's place");
        else if ((num1 / 100) % 10 == num2)
            Console.WriteLine("Second number is in Hundred's place");
        else if ((num1 / 1000) % 10 == num2)
            Console.WriteLine("Second number is in Thousand's place");
        else
            Console.WriteLine("Number not found");
    }
}
