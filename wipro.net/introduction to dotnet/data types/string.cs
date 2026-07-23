using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        // 1. Reverse the string
        string reverse = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse = reverse + str[i];
        }
        Console.WriteLine("Reverse String: " + reverse);
        // 2. Extract from 2nd position till end
        string sub = str.Substring(1);
        Console.WriteLine("Substring: " + sub);
        // 3. Replace character with '$'
        Console.Write("Enter character to replace: ");
        char ch = Convert.ToChar(Console.ReadLine());
        string replaced = str.Replace(ch, '$');
        Console.WriteLine("After Replace: " + replaced);

       // 4. Copy string and modify second string
        string str2 = str;
        str2 = str2 + " CSharp";
        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Modified Copied String: " + str2);
    }
}
