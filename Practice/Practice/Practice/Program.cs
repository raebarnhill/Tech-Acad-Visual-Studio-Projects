using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a const variable

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            const string racoonCity = "Raccoon City PD";
            
            var officer1 = "Helena";

            Console.WriteLine("Leon and " + officer1 + " are officers with the {0}.", racoonCity);

            Console.ReadLine();


        }
    }
}
