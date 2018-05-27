using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public int NumberOfDays;
        public int NumberOfLemons;
        public int CupsOfSugar;
        public int NumberOfIceCubes;
        Inventory Inventory = new Inventory();
        public Player ()
        {
            Inventory Inventory = new Inventory();

        }

        public void GetRecipe()
        {
            Inventory.CheckLemons();

            

        }

        public void SellLemonade()
        {

        }
        
    }
}
