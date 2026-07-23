using System;
class Area
{
    // Area of Circle
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }
    // Area of Rectangle
    public double CalculateArea(double length, double breadth)
    {
        return length * breadth;
    }
    // Area of Triangle
    public double CalculateArea(double b, double h, int triangle)
    {
        return 0.5 * b * h;
    }
}
class Program
{
    static void Main()
    {
        Area obj = new Area();
        Console.WriteLine("Area of Circle : " + obj.CalculateArea(5));
        Console.WriteLine("Area of Rectangle : " + obj.CalculateArea(10, 5));
        Console.WriteLine("Area of Triangle : " + obj.CalculateArea(8, 6, 1));
    }
}
