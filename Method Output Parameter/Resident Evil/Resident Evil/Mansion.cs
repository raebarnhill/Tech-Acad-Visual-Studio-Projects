using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Resident_Evil
{
    class Mansion
    {
        public void Zombies(out int zombiesKilled)
        {
            zombiesKilled = Convert.ToInt32(Console.ReadLine());
            int zombEach = 2;
            zombiesKilled = zombiesKilled / zombEach;
            

        }

        public static int Zombies(int mansionZombs, int totalZombs)
        {
            int input = mansionZombs;
            return totalZombs - mansionZombs;
        }


        
    }
}
