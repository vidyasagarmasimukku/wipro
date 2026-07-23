using System;
class Program
{
    static void Main()
    {
        string username = "Admin";
        string password = "1234";
        int count = 0;
        while (count < 3)
        {
            Console.Write("Enter Username: ");
            string user = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            if (user == username && pass == password)
            {
                Console.WriteLine("Login Successful");
                return;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
                count++;
            }
        }
        Console.WriteLine("User Rejected");
    }
}
