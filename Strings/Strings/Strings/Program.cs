using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite color:");
            string color = Console.ReadLine();

            Console.WriteLine("Now please enter your favorite animal:");
            string animal = Console.ReadLine();

            Console.WriteLine("Now please enter your favorite name:");
            string animalName = Console.ReadLine();

            Console.WriteLine("You've created a(n) " + color + " " + animal + " " + "named " + animalName + "!");
            Console.WriteLine("That's a pretty cool animal!");

            Console.WriteLine("My favorite animal is a:");
            string favAnimal = "Red dog named Clifford";
            string str1 = favAnimal.ToUpper();
            Console.WriteLine(str1);



            StringBuilder sb = new StringBuilder("Clifford ", 50);

            sb.AppendLine("is a big red dog created in 1963.");
            sb.AppendLine("Clifford is owned by a girl named Emily Elizabeth.");
            sb.AppendLine("Clifford is the star of many books.");
            sb.AppendLine("And he also had his very own show.");
            Console.WriteLine(sb);

            


        }
    }
}
