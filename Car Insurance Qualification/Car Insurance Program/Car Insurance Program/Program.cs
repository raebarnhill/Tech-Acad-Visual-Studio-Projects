using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter true or false.");
            bool hadDUI = true;
            string DUI = Console.ReadLine();

            
            

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = (age > 15 && hadDUI && numTickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
