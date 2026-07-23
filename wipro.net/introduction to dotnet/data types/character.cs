using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";
        foreach (char ch in str)
        {
            if (char.IsLetter(ch))
            {
                char newChar = (char)(ch + 1);
                if (char.IsUpper(newChar))
                    result += char.ToLower(newChar);
                else
                    result += char.ToUpper(newChar);
            }
            else
            {
                result += ch;
            }
        }
        Console.WriteLine("Output: " + result);
    }
}
