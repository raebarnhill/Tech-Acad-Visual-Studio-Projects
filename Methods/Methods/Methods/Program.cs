using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create three methods, each 
            //of which will take one integer parameter in and return an integer.
            //The methods should do some math operation on the received parameter.
            //Put this class in a separate.cs file in the application.
            //2. In the Main() program, ask the user what number they want to do the 
            //math operations on.
            //3. Call each method in turn, passing the user input to the method.
            //Display the returned integer to the screen.
            Shelter shelter = new Shelter();

            Console.WriteLine("To find how many cats remain at the shelter out of 20, please enter the number of cats you want to adopt:");
            int adopt = Convert.ToInt32(Console.ReadLine());
            int answer = shelter.CatsRemain(adopt);
            Console.WriteLine(answer + " cat(s) remain.");
            Console.ReadLine();

            Console.WriteLine("Please enter the total amount of Tabby cats you would like out of the 10 that are at the shelter:");
            int adoptTabby = Convert.ToInt32(Console.ReadLine());
            int answer2 = shelter.TabbyCount(adoptTabby);
            Console.WriteLine(answer2 + " tabby(s) remain.");
            Console.ReadLine();

            Console.WriteLine("Please enter the amount of cats you adopted to see how many bags of food you will need:");
            int catsAdopted = Convert.ToInt32(Console.ReadLine());
            int answer3 = shelter.FoodNeeded(catsAdopted);
            Console.WriteLine("You will need " + answer3 + " bags of food!");
            Console.ReadLine();

            


        }

        
    }
}
