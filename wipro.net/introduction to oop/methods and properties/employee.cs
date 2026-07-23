using System;
class Employee
{
    string empName;
    double basicSalary;
    double hra, da, tax, grossPay, netPay;
    // Constructor
    public Employee(string name, double salary)
    {
        empName = name;
        basicSalary = salary;
    }
    // Method to calculate salary
    public void CalculateNetPay()
    {
        hra = basicSalary * 0.15;
        da = basicSalary * 0.10;
        grossPay = basicSalary + hra + da;
        tax = grossPay * 0.08;
        netPay = grossPay - tax;
    }
    // Display Method
    public void Display()
    {
        Console.WriteLine("Employee Name : " + empName);
        Console.WriteLine("Basic Salary  : " + basicSalary);
        Console.WriteLine("HRA           : " + hra);
        Console.WriteLine("DA            : " + da);
        Console.WriteLine("Gross Pay     : " + grossPay);
        Console.WriteLine("Tax           : " + tax);
        Console.WriteLine("Net Pay       : " + netPay);
    }
    static void Main()
    {
        Employee emp = new Employee("Gowtham", 50000);

        emp.CalculateNetPay();
        emp.Display();

        Console.ReadLine();
    }
}
