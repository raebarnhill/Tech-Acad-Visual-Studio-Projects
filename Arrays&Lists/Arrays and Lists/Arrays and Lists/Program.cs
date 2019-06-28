using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of strings. Ask the user to select an index 
            //of the Array and then display the string at that index 
            //on the screen


            string[] animals = { "dog", "chicken", "hippo" };
            Console.WriteLine("Please enter one of the following numbers: 0, 1 or 2:");
            int numSelected = Convert.ToInt32(Console.ReadLine());
            bool numGuess = false;

            while (!numGuess)

                switch (numSelected)
                {
                    case 0:
                        Console.WriteLine("You chose the animal " + animals[0] + " from the array!");
                        numGuess = true;
                        break;

                    case 1:
                        Console.WriteLine("You chose the animal " + animals[1] + " from the array!");
                        numGuess = true;
                        break;

                    case 2:
                        Console.WriteLine("You chose the animal " + animals[2] + " from the array!");
                        numGuess = true;
                        break;


                    default:
                        Console.WriteLine("Please enter a valid number:");
                        numSelected = Convert.ToInt32(Console.ReadLine());
                        break;
                }


            // Create an array of integers. Ask the user to select an index of the Array and then display 
            //the integer at that index on the screen.

     

            int[] numArray1 = new int[] { 23, 565, 346 };
            Console.WriteLine("Please select and enter one of the following numbers: 0, 1 or 2:");
            int numSelected1 = Convert.ToInt32(Console.ReadLine());
            bool numGuess1 = false;

            while (!numGuess1)

            switch (numSelected1)
            {
                case 0:
                        Console.WriteLine("You chose the number " + numArray1[0] + " from the array!");
                        numGuess1 = true;
                        break;

                case 1:
                        Console.WriteLine("You chose the number " + numArray1[1] + " from the array!");
                        numGuess1 = true;
                        break;

                case 2:
                        Console.WriteLine("You chose the number " + numArray1[2] + " from the array!");
                        numGuess1 = true;
                        break;


                default:
                        Console.WriteLine("Please enter a valid number:");
                        numSelected1 = Convert.ToInt32(Console.ReadLine());
                        break; 
        }

            //Create a List of strings.Ask the user to select an index of the List and then display 
            //the content at that index on the screen.

            string[] colors = { "Red", "Blue", "Green" };
            List<string> stringList = new List<string>();

            Console.WriteLine("Please select and enter one of the following numbers: 0, 1 or 2:");
            int numSelected2 = Convert.ToInt32(Console.ReadLine());
            bool numGuess2 = false;

            while (!numGuess2)

                switch (numSelected2)
                {
                    case 0:
                        Console.WriteLine("You chose the color " + colors[0] + " from the array!");
                        numGuess2 = true;
                        break;

                    case 1:
                        Console.WriteLine("You chose the color " + colors[1] + " from the array!");
                        numGuess2 = true;
                        break;

                    case 2:
                        Console.WriteLine("You chose the color " + colors[2] + " from the array!");
                        numGuess2 = true;
                        break;


                    default:
                        Console.WriteLine("Please enter a valid number:");
                        numSelected2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }


            Console.ReadLine();


        }
    }
}
