﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a struct called Number and give it the property "Amount" 
//and have it be of data type decimal.

//2. In the Main() method, create an object of data type Number and 
//assign an amount to it.

//3. Print this amount to the console.


namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number1 = new Number();
            number1.Amount = 100.5m;

            Console.WriteLine(number1.Amount);
            Console.ReadLine();

        }
    }
}
