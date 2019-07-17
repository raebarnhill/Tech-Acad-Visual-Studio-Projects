using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Prints the current date and time to the console.

//2. Asks the user for a number.

//3. Prints to the console the exact time it will be in 
//X hours, X being the number the user entered in step 2.

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is:");
            System.DateTime dateTime = new System.DateTime();
            dateTime = System.DateTime.Now;
            Console.WriteLine(dateTime + "\n");


            Console.WriteLine("Please enter a number:");
            int hours = Convert.ToInt32(Console.ReadLine());

            dateTime = dateTime.AddHours(hours);
            Console.WriteLine("In " + hours + " hours, the time will be: " + dateTime);
            Console.ReadLine();


        }
    }
}
