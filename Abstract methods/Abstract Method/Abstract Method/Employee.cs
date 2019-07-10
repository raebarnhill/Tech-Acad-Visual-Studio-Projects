using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Overload the "==" operator so it checks if two Employee 
//objects are equal by comparing their Id property.

namespace Abstract_Method
{
   public class Employee : Person, IQuittable 
    {
       public override string SayName()
        {
            string FullName = FirstName + LastName;
            return FullName;
        }

       
       public void Quit()
        {
            string newEmployeeName = NewFName + NewLName;
            Console.WriteLine(newEmployeeName);

        }

        public string NewFName { get; set; }
        public string NewLName { get; set; }

    }
}
