using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Inheritance
{
    class Person
    {
        public void SayName()
        {
            
            string FullName = "FirstName" + "LastName";
            Console.WriteLine("Name: [" + FullName + "]");
            return;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    

    }
    }

    

