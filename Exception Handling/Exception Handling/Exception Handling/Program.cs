using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each 
            //number in the list by.Write a loop that takes each integer in the list,
            //divides it by the number the user entered, and displays the result to the
            //screen.

            //List<int> numbers = new List<int>
            //{
            //    20,
            //    100,
            //    50
            //};


            //foreach (int number in numbers)
            //{
            //    Console.WriteLine("Please enter a number:");
            //    int divisor = Convert.ToInt32(Console.ReadLine());
            //    int number1 = numbers[0] / divisor;
            //    Console.WriteLine("20 divided by your number equals: " + number1);

            //    int number2 = numbers[1] / divisor;
            //    Console.WriteLine("100 divided by your number is: " + number2);

            //    int number3 = numbers[2] / divisor;
            //    Console.WriteLine("50 divided by your number is: " + number3);
            //    Console.ReadLine();
            //}



            // 5.Now put the loop in a try/catch block.Below and outside of the try/catch block, 
            //make the program display a message to the display to let you know the program has 
            //emerged from the try/catch block and continued on with program execution.In the catch 
            //block, display the error message to the screen.Then try various combinations of user input: 
            //valid numbers, zero and a string.Ensure the proper error messages display on the screen, and 
            //that the code after the try/catch block gets executed.


            List<int> numbers = new List<int>
            {
                20,
                100,
                50
            };


            try
            {
                Console.WriteLine("Please enter a number:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int number1 = 20 / divisor;
                Console.WriteLine("20 divided by your number is: " + number1);
                int number2 = 100 / divisor;
                Console.WriteLine("100 divided by your number is: " + number2);
                int number3 = 50 / divisor;
                Console.WriteLine("50 divided by your number is: " + number3);
                Console.ReadLine();
            }


            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }

            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number.");
            }
          
            finally
            {
                Console.WriteLine("Exited the try/catch block.");
            }
            Console.ReadLine();
        }
    }
}
