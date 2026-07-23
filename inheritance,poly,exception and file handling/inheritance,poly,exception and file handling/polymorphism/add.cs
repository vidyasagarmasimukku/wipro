using System;
class Math
{
    // Add
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    // Multiply
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    // Subtract
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }
    // Divide
    public int Divide(int a, int b)
    {
        return a / b;
    }
    public int Divide(int a, int b, int c)
    {
        return a / b / c;
    }
}
class Program
{
    static void Main()
    {
        Math obj = new Math();
        Console.WriteLine("Add (2 numbers): " + obj.Add(10, 20));
        Console.WriteLine("Add (3 numbers): " + obj.Add(10, 20, 30));
        Console.WriteLine("Multiply (2 numbers): " + obj.Multiply(5, 4));
        Console.WriteLine("Multiply (3 numbers): " + obj.Multiply(2, 3, 4));
        Console.WriteLine("Subtract (2 numbers): " + obj.Subtract(20, 10));
        Console.WriteLine("Subtract (3 numbers): " + obj.Subtract(30, 10, 5));
        Console.WriteLine("Divide (2 numbers): " + obj.Divide(20, 5));
        Console.WriteLine("Divide (3 numbers): " + obj.Divide(40, 2, 4));
    }
}
