using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method
{
    class Car
    {
       
        public void TopSpeed(int carSpeed = 80, int speedLimit = 25)
        {

            int overLimit = carSpeed - speedLimit;
            Console.WriteLine(speedLimit);
             return;
        }



        public Car()
        {
            List<Type> Types = new List<Type>();
            List<string> Makes = new List<string>() { "Honda", "Geo", "Toyota" };
            List<string> Models = new List<string>() { "Civic", "Metro", "Yaris" };



            foreach (string make in Makes)
            {
                foreach (string model in Models)
                {
                    Type type = new Type();
                    type.Make = make;
                    type.Model = model;
                    Types.Add(type);
                }

            }

        }

    }
}

