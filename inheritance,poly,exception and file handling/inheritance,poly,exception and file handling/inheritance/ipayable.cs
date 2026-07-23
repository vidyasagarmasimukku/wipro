using System;
interface IPayable
{
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
    public HourlyEmployee(string name) : base(name)
    {
    }
}
class PermanentEmployee : Person, IPayable
{
    public PermanentEmployee(string name) : base(name)
    {
    }
}
class Program
{
    static void Main()
    {
        HourlyEmployee h = new HourlyEmployee("raju");
        PermanentEmployee p = new PermanentEmployee("ravi");
        Console.WriteLine("Hourly Employee: " + h.Name);
        Console.WriteLine("Permanent Employee: " + p.Name);
    }
}
