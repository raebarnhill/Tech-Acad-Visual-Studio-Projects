using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 5:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool numGuess = false;

            while (!numGuess) 
             {
                switch (num)
                    {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5:");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5:");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5:");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, you are correct!");
                        numGuess = true;
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number between 1 and 5:");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please guess a number between 1 and 5.");
                        break;
                }
                
               
            }
            Console.ReadLine();
        }
    }
}
