using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Abstract_Method
{
     interface IQuittable
    {
         void Quit();

        
        string NewFName { get; set; }
        string NewLName { get; set; }

    }

}
