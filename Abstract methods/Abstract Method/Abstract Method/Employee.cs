using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
   public class Employee : Person, IQuittable 
    {
       public override string SayName()
        {
            string FullName = FirstName + LastName;
            return FullName;
        }

       
        public string Quit(string newEmployee)
        {   
            string newEmployeeName = newEmployee;
            return newEmployeeName;
        }
    }
}
