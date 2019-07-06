using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Shelter
    {
        //Method 1
        //int answer = shelter.CatsRemain(30);
        //Console.WriteLine(answer);
        public int CatsRemain(int spotsAvail)
        {
            int input = spotsAvail;
            int totalCats = 20;
            return totalCats - input;

        }

        //Method 2
        //int answer2 = shelter.TabbyCount(6);
        //Console.WriteLine(answer2);
        public int TabbyCount(int TabbysAllowed)
        {
            int input = TabbysAllowed;
            int totalSpots = 10;
            return totalSpots - input;
        }
        
        //Method 3
        //int answer3 = shelter.FoodNeeded(20);
        //Console.WriteLine(answer3);

        public int FoodNeeded(int CatCount)
        {
            int input = CatCount;
            int bagsPerCat = 2;
            return bagsPerCat * input;

        }





        public Shelter()
        {
            Cats = new List<Cat>();
            List<string> Breeds = new List<string>() { "Tabby", "Siamese", "Ragdoll", "Calico" };
            List<string> Colors = new List<string>()
            { "Black", "Brown", "Orange", "White", "Grey"};



            foreach (string breed in Breeds)
            {
                foreach (string color in Colors)
                {
                    Cat cat = new Cat();
                    cat.Breed = breed;
                    cat.Color = color;
                    Cats.Add(cat);
                }


            }
         }


        public List<Cat> Cats { get; set; }
    }
}
