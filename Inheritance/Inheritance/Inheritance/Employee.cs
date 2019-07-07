using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
    {
        internal void SayName(string firstName, string lastName)
        {
            string FullName = "FirstName" + "LastName";
            Console.WriteLine("Name: [" + FullName + "]");
            return;
        }

        public int Id { get; set; }
    }

  
}
