using System;
interface IPayable
{
    double CalculatePay();
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Method CalculatePay declared successfully.");
    }
}

OUTPUT
Method CalculatePay declared successfully.

5) Implement the interface in above derived classes and test the interface implementation by passing some values.
using System;
interface IPayable
{
    double CalculatePay();
}
class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
}
class HourlyEmployee : Person, IPayable
{
    public double HoursWorked;
    public double PayPerHour;
    public HourlyEmployee(string name, double hours, double pay)
        : base(name)
    {
        HoursWorked = hours;
        PayPerHour = pay;
    }
    public double CalculatePay()
    {
        return HoursWorked * PayPerHour;
    }
}
class PermanentEmployee : Person, IPayable
{
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double Tax;
    public PermanentEmployee(string name, double basic, double hra, double da, double tax)
        : base(name)
    {
        BasicSalary = basic;
        HRA = hra;
        DA = da;
        Tax = tax;
    }
    public double CalculatePay()
    {
        return BasicSalary + HRA + DA - Tax;
    }
}
class Program
{
    static void Main()
    {
        HourlyEmployee h = new HourlyEmployee("Rahul", 8, 500);
        PermanentEmployee p = new PermanentEmployee("Anjali", 30000, 5000, 3000, 2000);
        Console.WriteLine("Hourly Employee Pay : " + h.CalculatePay());
        Console.WriteLine("Permanent Employee Pay : " + p.CalculatePay());
    }
}
