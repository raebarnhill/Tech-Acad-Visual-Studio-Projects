using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1.Create a class. In that class, create a void method that outputs an integer.
//Have the method divide the data passed to it by 2.

//2.In the Main() method, instantiate that class.

//3.Have the user enter a number.Call the method on that number.
//Display the output to the screen. It should be the entered number, 
//divided by two.

//4.Create a method with output parameters.

//5.Overload a method.

//6.Declare a class to be static.



namespace Resident_Evil
{
    class Program
    {
        static void Main(string[] args)
        {
            Mansion mansion = new Mansion();

            Console.WriteLine("Please enter a number for how many Zombies have been eliminated:");
            int zombiesKilled; 
            mansion.Zombies(out zombiesKilled);
            Console.WriteLine("You and your partner have each eliminated approximately " + zombiesKilled + " zombies each. Good Job!");
            Console.ReadLine();


            Console.WriteLine("Please enter the number of zombies eliminated in the Mansion:");
            int mansionZombs = Convert.ToInt32(Console.ReadLine());
            int answer = Mansion.Zombies(mansionZombs, 798);
            Console.WriteLine("You still have " + answer + " zombies to defeat.");
            Console.ReadLine();

           


        }
    }
}
