using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. In the Main() method, create a list of at least 10 employees.
//Each employee should have a first and last name, as well as an Id.
//At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the 
//first name "Joe".

//3. Do the same thing again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an 
//Id number greater than 5.

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> employees = new List<string>() { "Joe Schmoe, 11", "Joe Moe, 12", "Rick Grimes, 13", "Maggie Greene, 14", "Beth Greene, 15", "Hershel Greene, 16", "Daryl Dixon, 17", "Merl Dixon, 18", "Carol Peletier, 19", "Glen Rhee, 20" };

            //foreach (string employee in employees)
            //{
            //    if (employee.StartsWith("Joe"))
            //       { 
            //        Console.WriteLine(employee);

            //    }


            //List<string> employees = new List<string>() { "Joe Schmoe, 1", "Joe Moe, 2", "Rick Grimes, 3", "Maggie Greene, 4", "Beth Greene, 5", "Hershel Greene, 6", "Daryl Dixon, 7", "Merl Dixon, 8", "Carol Peletier, 9", "Glen Rhee, 10" };
            //List<string> joeEmployees = new List<string> { }; 


            //    joeEmployees = employees.Where(x => x.StartsWith("Joe")).ToList();

            // foreach (string joeEmployee in joeEmployees)
            //{
            //    Console.WriteLine(joeEmployee);
            //}


            List<string> employees = new List<string>() { "Joe Schmoe, 1", "Joe Moe, 2", "Rick Grimes, 3", "Maggie Greene, 4", "Beth Greene, 5", "Hershel Greene, 6", "Daryl Dixon, 7", "Merl Dixon, 8", "Carol Peletier, 9", "Glen Rhee, 10" };

            List<string> joeEmployees = new List<string> { };

            joeEmployees = employees.Find(x => x.Contains(x > 5)).ToList();

            Console.WriteLine(joeEmployees);


        }

       
        }
    }

