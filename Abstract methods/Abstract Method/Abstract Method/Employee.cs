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
        public override bool Equals(object obj)
        {
            if (!(obj is Employee))
                return false;

            var other = obj as Employee;

            if (EmployeeId != other.EmployeeId)
                return false;

            return true;
        }



        public static bool operator ==(Employee employeeID1, Employee employeeID2)
        {
            return employeeID1.Equals(employeeID2);
        }

        public static bool operator !=(Employee employeeID1, Employee employeeID2)
        {
            return !(employeeID1 == employeeID2);
        }





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
