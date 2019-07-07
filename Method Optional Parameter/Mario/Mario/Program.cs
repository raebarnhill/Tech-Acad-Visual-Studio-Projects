using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class. In that class, create a method that takes two integers as parameters.
//Make one of them optional.Have the method do a math operation and return a integer result.

//2.In the Main() method of the console app, instantiate the class.

//3.Ask the user to input two numbers, one at a time.Let them know they need not enter 
//anything for the second number.

//4.Call the method in the class, passing in the one or two numbers entered.

//5.Try various combinations of numbers on the code, including having no second number.



namespace Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            //Console.WriteLine("Please enter a number for how many apples Yoshi has eaten:");
            //int apples = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a number for how many bananas Yoshi has eaten (0 is a valid number):");
            //int bananas = Convert.ToInt32(Console.ReadLine());
            //int answer = character.FruitEaten(apples, bananas);
            //Console.WriteLine("Yoshi has eaten " + answer + " total fruits.");
            //Console.ReadLine();




            //int apples = 12;
            //int bananas = 23;
            //int totalFruit = character.FruitEaten(12,23);

            //Console.WriteLine("Yoshi has eaten " + totalFruit + " total fruits.");





            int apples = 12;
            int totalFruit = character.FruitEaten(12);

            Console.WriteLine("Yoshi has eaten " + totalFruit + " total fruits.");


        }
    }
}
