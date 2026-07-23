using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name cannot be empty.");
            }
            foreach (char ch in firstName)
            {
                if (!char.IsLetter(ch))
                    throw new Exception("First Name should contain only alphabets.");
            }
            foreach (char ch in lastName)
            {
                if (!char.IsLetter(ch))
                    throw new Exception("Last Name should contain only alphabets.");
            }
            Console.WriteLine("Valid Name");
            Console.WriteLine("First Name : " + firstName);
            Console.WriteLine("Last Name : " + lastName);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
