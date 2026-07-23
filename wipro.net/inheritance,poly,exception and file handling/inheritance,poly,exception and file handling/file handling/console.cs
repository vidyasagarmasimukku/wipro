using System;
using System.IO;
class Program
{
    static void Main()
    {
        string fileName = "Student.txt";
        FileStream fs = new FileStream(fileName, FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("Name : RAVI");
        sw.WriteLine("Course : C#");
        sw.WriteLine("College : VVITU");
        sw.Close();
        fs.Close();
        Console.WriteLine("File created successfully.");
    }
}
