using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//1. Ask a user for a number.

//2. Log that number to a text file.

//3. Print the text file back to the user.

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string text = string.Format(Console.ReadLine());
            File.WriteAllText(@"C:\Users\Student\Documents\Test\MyFile.txt", text);

            string text1 = File.ReadAllText(@"C:\Users\Student\Documents\Test\MyFile.txt");
            Console.WriteLine(text1);
            Console.ReadLine();
        }
    }
}
