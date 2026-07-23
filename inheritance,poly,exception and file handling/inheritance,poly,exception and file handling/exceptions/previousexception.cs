using System;
class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Person p = new Person(name, age);
            Console.WriteLine("Name : " + p.Name);
            Console.WriteLine("Age : " + p.Age);
        }
        catch (FormatException)
        {
            Console.WriteLine("Age must be an integer.");
        }
    }
}
