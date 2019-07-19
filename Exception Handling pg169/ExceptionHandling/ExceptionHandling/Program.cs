using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Ask the user for his age.

//2. Display the year user born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if user enters zero or negative numbers.

//5. Display a general message if exception caused by anything else.

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            bool agecheck = false;
            while (!agecheck)
            {
                try
                {

                    Console.WriteLine("Please enter your age:");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer <= 0) { throw new InvalidAgeException(); };
                    var myDate = DateTime.Now;
                    var newDate = myDate.AddYears(-(answer));

                    int year = newDate.Year;

                    Console.WriteLine("You were born in the year: " + year);
                    Console.ReadLine();
                    return;
                }
                catch (InvalidAgeException)
                {

                    Console.WriteLine("Zero and negative numbers are not a valid age." + "\n");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter your name using only digits.");
                   
                }
            }
        }
    }
}
