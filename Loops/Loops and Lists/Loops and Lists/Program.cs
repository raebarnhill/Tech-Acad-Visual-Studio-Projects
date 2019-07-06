using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loops_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Create a one-dimensional Array of strings.Ask the user to
            //input some text.Create a loop that goes through each string
            //in the Array, adding the user’s text to the string.Then 
            //create a loop that prints off each string in the Array on
            //a separate line.


            Console.WriteLine("Please enter your favorite animal:");
            string favAnimal = Console.ReadLine();
            string[] animals = { "cat ", "butterfly ", "zebra ", favAnimal };


            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();



            //2. Create an infinite loop



            //for (; ;)
            //{
            //    Console.WriteLine("Oops..");
            //}


            //3. Fix the infinite loop so it will execute
            //4.Create a loop where the comparison used to determine whether to continue 
            //iterating the loop is a “<” operator.

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Some pretty colors:");
            //}
            //Console.ReadLine();


            //5.Create a loop where the comparison used to determine whether to continue 
            //iterating the loop is a “<=” operator.

            //int x = 1;

            //while (x <= 10)
            //{
            //    Console.WriteLine("iterate");
            //    x++;
            //}
            //Console.ReadLine


            //6.Create a List of strings where each item in the list is unique.Ask the user 
            //to select text to search for in the List.Create a loop that iterates through 
            //the list and then displays the index of the array that contains matching text 
            //on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8.Add code to that above loop that stops it from executing once a match has been found.

            //List<string> colors = new List<string>();
            //colors.Add("Red");
            //colors.Add("Green");
            //colors.Add("Blue");

            //Console.WriteLine("Please enter one of the following: Red, Green or Blue:");
            //string colorChoice = Console.ReadLine();
            //string color = colorChoice;
            //bool colorGuess = false;

            //while (!colorGuess)

            //switch (color)
            //    {
            //        case "Red":
            //        int index = colors.IndexOf("Red");
            //        Console.WriteLine("You chose the color " + colors[0] + " from index: " + index);
            //            colorGuess = true;
            //            break;

            //        case "Green":
            //        index = colors.IndexOf("Green");
            //        Console.WriteLine("You chose the color " + colors[1] + " from index: " + index);
            //            colorGuess = true;
            //            break;

            //        case "Blue":
            //        index = colors.IndexOf("Blue");
            //        Console.WriteLine("You chose the color " + colors[2] + " from index: " + index);
            //            colorGuess = true;
            //            break;


            //        default:
            //            Console.WriteLine("Please enter a valid color:");
            //            color = (Console.ReadLine());
            //            break;
            //    }


            //Console.ReadLine();




            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to 
            //select text to search for in the List.Create a loop that iterates through the list and then displays 
            //the indices of the array that contain matching text on the screen.
            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> animals = new List<string>() { "cat", "cat", "dog", "dog", "cow", "horse", "fish" };


            //Console.WriteLine("Please enter a type of animal:");
            //string animalChoice = Console.ReadLine();

            //for (int i = 0; i < animals.Count; i++)
            //{
            //    if (animalChoice == animals[i])
            //    {
            //        Console.WriteLine("You've chosen the animal " + animalChoice + " at index " + i);

            //    }

            //    else if (!animals.Contains(animalChoice))
            //    {
            //        Console.WriteLine("The animal you've chosen isn't in the list.");
            //        Console.ReadLine();
            //    }








            //11.Create a List of strings that has at least two identical strings in the List. Create a foreach loop that 
            //evaluates each item in the list, and displays a message showing the string and whether or not it has already 
            //appeared in the list.

            //string[] names = { "Evan", "Abi", "Abi", "Daniel", "Daniel" };

            //List<string> myList = new List<string>();

            //   foreach (string name in names)
            //   {
            //       if (!myList.Contains(name))
            //       {
            //           myList.Add(name);
            //          Console.WriteLine(name + "  has not appeared in the list");

            //       }

            //       else
            //           Console.WriteLine(name + " has already appeared");
            

            //       Console.ReadLine();
        }



    }
    }
        }
    


   




   