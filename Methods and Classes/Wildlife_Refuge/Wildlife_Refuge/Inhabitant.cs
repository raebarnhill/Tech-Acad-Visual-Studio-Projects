using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wildlife_Refuge
{
    public class Inhabitant
    {
        public int EnclosureDetails(int tigers)
        {
            int input = tigers;
            int spaceNeeded = 2;
            return spaceNeeded * input;
        }

        public decimal EnclosureDetails(decimal bagsFood1)
        {
            decimal input = bagsFood1;
            int bagsOfFood = Convert.ToInt32(input);
            int numTigers = 2;
            return bagsOfFood / numTigers;

        }

        public int EnclosureDetails(Inhabitant inhabitant, string numToys)
        {
            string input = numToys;
            int numOfToys = Convert.ToInt32(input);
            int toysPerTiger = 2;
            return numOfToys % toysPerTiger;
        }
        


        public static int Tigers { get; private set; }
        
    }
    }
  