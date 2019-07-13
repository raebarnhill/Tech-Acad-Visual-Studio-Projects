using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create an enum for the days of the week.

//2. Prompt the user to enter the current day of the week.

//3. Assign the value to a variable of that enum data type 
//you just created.

//4. Wrap the above statement in a try/catch block and have it print 
//"Please enter an actual day of the week." to the console if an error occurs.


namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the current day of the week:");
            string value = Console.ReadLine();

            DaysOfTheWeek daysOfTheWeek;
            try
            {
                daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week:");
            }


        }

        


    }


}

