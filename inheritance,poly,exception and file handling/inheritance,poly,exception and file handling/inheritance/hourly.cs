using System;
class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
}

class HourlyEmployee : Person
{
    public double HoursWorked;
    public double PayPerHour;
    public HourlyEmployee(string name, double hours, double pay)
        : base(name)
    {
        HoursWorked = hours;
        PayPerHour = pay;
    }
    public double TotalSalary()
    {
        return HoursWorked * PayPerHour;
    }
}
class PermanentEmployee : Person
{
    public double HRA;
    public double DA;
    public double Tax;
    public double NetPay;
    public double TotalPay;
    public PermanentEmployee(string name, double hra, double da, double tax)
        : base(name)
    {
        HRA = hra;
        DA = da;
        Tax = tax;
        TotalPay = HRA + DA;
        NetPay = TotalPay - Tax;
    }
}

class Program
{
    static void Main()
    {
        HourlyEmployee h = new HourlyEmployee("Rahul", 8, 500);
        Console.WriteLine("Hourly Employee");
        Console.WriteLine("Name : " + h.Name);
        Console.WriteLine("Hours Worked : " + h.HoursWorked);
        Console.WriteLine("Pay Per Hour : " + h.PayPerHour);
        Console.WriteLine("Total Salary : " + h.TotalSalary());
        Console.WriteLine();
        PermanentEmployee p = new PermanentEmployee("Anjali", 20000, 10000, 3000);
        Console.WriteLine("Permanent Employee");
        Console.WriteLine("Name : " + p.Name);
        Console.WriteLine("HRA : " + p.HRA);
        Console.WriteLine("DA : " + p.DA);
        Console.WriteLine("Tax : " + p.Tax);
        Console.WriteLine("Total Pay : " + p.TotalPay);
        Console.WriteLine("Net Pay : " + p.NetPay);
    }
}
