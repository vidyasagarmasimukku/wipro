using System;
class NegativeNumberException : Exception
{
    public NegativeNumberException(string msg) : base(msg)
    {
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks < 0)
            {
                throw new NegativeNumberException("Marks cannot be negative.");
            }
            Console.WriteLine("Marks Entered : " + marks);
        }
        catch (NegativeNumberException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Enter only integer values.");
        }
    }
}
