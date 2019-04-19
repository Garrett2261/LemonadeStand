using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        Store Store = new Store();
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

        public int AddLemonsFromStore(int lemonsBought)
        {
            if(lemons >= 0)
            {
                lemons += lemonsBought;
            }
            else
            {
                lemons = lemonsBought;
            }
            return lemons;
        }

        public int CheckCupsOfSugarAfterStore(int cupsOfSugarBought)
        {
            if(cupsOfSugar >= 0)
            {
                cupsOfSugar += cupsOfSugarBought;
            }
            else
            {
                cupsOfSugar = cupsOfSugarBought;
            }
            return cupsOfSugar;
        }

        public int CheckIceCubesAfterStore(int iceCubesBought)
        {
            if(iceCubes >= 0)
            {
                iceCubes += iceCubesBought;
            }
            else
            {

            }
        }
    }
}
