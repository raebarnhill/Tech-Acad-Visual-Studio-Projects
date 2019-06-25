using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a nice day.");
             
            }
            else if (packageWeight <= 50)
            {
                Console.WriteLine("Please enter the package width:");
            }
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your estimated total for shipping this package is:");
            int quote = (packageWidth + packageHeight + packageLength) * packageWeight;
            float finalQuote = (float)quote / 100;

            Console.WriteLine("$" + finalQuote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            

        }
    }
}
