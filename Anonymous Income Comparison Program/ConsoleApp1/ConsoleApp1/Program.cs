using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly rate?");
            int hourlyRate1 = 16;
            string hourlyWage1 = hourlyRate1.ToString();
            Console.WriteLine(hourlyRate1);
            Console.WriteLine("Hours worked per week?");
            int hoursWorked1 = 45;
            string weeklyHours1 = hoursWorked1.ToString();
            Console.WriteLine(hoursWorked1);

            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly rate?");
            int hourlyRate2 = 25;
            string hourlyWage2 = hourlyRate2.ToString();
            Console.WriteLine(hourlyRate2);
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = 39;
            string weeklyHours2 = hoursWorked2.ToString();
            Console.WriteLine(hoursWorked2);

            Console.WriteLine("Weekly Salary of Person 1:");
            int daysWeek = 5;
            int hoursDay = 8;
            int product = (hourlyRate1 * hoursDay) * daysWeek;
            Console.WriteLine(product);

            Console.WriteLine("Weekly Salary of Person 2:");
            int product2 = (hourlyRate2 * hoursDay) * daysWeek;
            Console.WriteLine(product2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = product > product2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
