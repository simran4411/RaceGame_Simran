using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceGame_Simran
{
   public static  class Man
    {
        //if the player won the game then the increment method will be called other wise the decrement will be called 
        public static int increment(int budget, int amunt)
        {
            return budget + amunt;
        }
        public static int deccrement(int budget, int amunt)
        {
            return budget - amunt;
        }
    }
}
