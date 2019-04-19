using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemons;
        public int cupsOfSugar;
        public int iceCubes;
        
        public Inventory() 
        {
            
            //when a new inventory object is created, I want it to include the total amount of lemons,
            //sugar, and ice cubes that the player has. Every time that a customer buys a cup or cups,
            //the amount of lemons, cups of sugar, and ice cubes that were used in the recipe will be 
            //substracted from the total currently in the inventory.
        }

        public void CheckLemons()
        {

        }
    }
}
