using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int num2 = 50;
            int Total = number * num2;
            Console.WriteLine("Your number multiplied by 50 is: ");
            Console.WriteLine(Total);

            Console.WriteLine("Please enter a number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int num3 = 25;
            int Total2 = number2 + num3;
            Console.WriteLine("Your number plus 25 is:");
            Console.WriteLine(Total2);
            
            Console.WriteLine("Please enter a number:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            float num4 = 12.5f;
            float Total3 = number3 / num4;
            Console.WriteLine("Your number divided by 12.5 is:");
            Console.WriteLine(Total3);

            Console.WriteLine("Please enter a number to determine if it is greater than 50:");
            int number4 = Convert.ToInt32(Console.ReadLine());
            int num5 = 50;
            bool trueOrFalse = number4 > num5;
            Console.WriteLine(trueOrFalse);

            Console.WriteLine("Please enter a number:");
            int number5 = Convert.ToInt32(Console.ReadLine());
            int num6 = 7;
            int remainder = number5 % num6;
            Console.WriteLine("When your number, " + number5 + " is divided by 7, it leaves a remainder of:" );
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
