using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1. Create a class. In that class, create a method that will take in an integer, 
//do a math operation to it and then return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the one 
//method, passing in an integer, such as 12. Then display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, 
//do a different math operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the second 
//method, passing in a decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a string, 
//convert it to an integer if possible, do a different math operation to it and then return 
//the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the third method, 
//passing in a string that equates to an integer.Display the result to the screen.


namespace Wildlife_Refuge
{
    class Program
    {
         static void Main(string[] args)
        {
              Inhabitant inhabitant = new Inhabitant();

            Console.WriteLine("Please enter how many tigers will be at the wildlife refuge:");
            int tigerAdd = Convert.ToInt32(Console.ReadLine());
            int answer = inhabitant.EnclosureDetails(tigerAdd);
            Console.WriteLine("These tigers will need " + answer + " acres of space.");
            Console.ReadLine();
        


        Console.WriteLine("Please enter how many half bags of food are available (i.e. 2.5):");
            decimal bagsFood = Convert.ToDecimal(Console.ReadLine());
            int bagsFood1 = Convert.ToInt32(bagsFood);
            int answer2 = inhabitant.EnclosureDetails(bagsFood1);
            Console.WriteLine(answer2 + " bags of food are needed for two tigers.");
            Console.ReadLine();

            Console.WriteLine("Please enter the number of toys you'd like to donate to the tigers:");
            string numToys = Console.ReadLine();
            int answer3 = inhabitant.EnclosureDetails(inhabitant, numToys);
            Console.WriteLine("Thank you, we now have " + answer3 + " tiger toy(s) left over.");
            Console.ReadLine();







        }
        
        
    }
}
