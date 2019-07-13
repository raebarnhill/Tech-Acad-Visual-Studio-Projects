using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Make the Employee class take a generic type parameter.

//2.Add a property to the Employee class called "things" and have its 
//data type be a generic list matching the generic type of the class.

//3.Instantiate an Employee object with type "string" as its generic 
//parameter.Assign a list of strings as the property value of Things.

//4.Instantiate an Employee object with type "int" as its generic 
//parameter.Assign a list of integers as the property value of Things.

//5.Create a loop that prints all of the Things to the Console.

namespace Abstract_Method
{
    class Program
    {
        static void Main(string[] args)
        {

           

            List<string> Things = new List<string>() { "thing1", "thing2", "thing3" };
            //List<int> Things = new List<int>() { 21, 22, 23 };

            
            foreach (string Thing in Things)
            {
                Console.WriteLine(Thing);

            }
            Console.ReadLine();
            
            //foreach (int Thing in Things)
            //{
            //    Console.WriteLine(Thing);
            //}
            //Console.ReadLine();









            //Employee employee = new Employee();

            //Employee employeeID1 = new Employee { EmployeeId = 1234 };
            //Employee employeeID2 = employeeID1;
            //Employee employeeID3 = new Employee { EmployeeId = 2345 };

            //Console.WriteLine(employeeID1 == employeeID3);
            //Console.ReadLine();




            //IQuittable newGuy = new Employee();

            //newGuy.NewFName = "Bob";
            //newGuy.NewLName = "NewGuy";

            //newGuy.Quit();

            //Console.ReadLine();



            //Employee employee = new Employee();

            //employee.FirstName = "Sample";
            //employee.LastName = "Student";


            //string FullName = employee.SayName();
            //Console.WriteLine(FullName);
            //Console.ReadLine();


        }
    }
}
