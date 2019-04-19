using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemons;
        public int cupsOfSugar;
        public int iceCubes;
        Inventory Inventory = new Inventory();
        public Recipe()
        {

        }

        public int GetNumberOfLemonsUsed()
        {
            Console.WriteLine("The basic recipe amounts for 4 lemons, 4 cups of sugar, and 4 ice cubes. You can change this and set it to whatever you'd like.");
            Console.WriteLine("How many lemons would you like to use in your recipe?");
            string number = Console.ReadLine();
            int amountOfLemons = Int32.Parse(number);
            if(amountOfLemons <= (Inventory.lemons))
            {
                lemons = amountOfLemons;
            }
            else if(amountOfLemons > Inventory.lemons)
            {
                Console.WriteLine("You don't have that many lemons. Either buy more lemons from the store, or choose a lower amount.");
            }
            return lemons;

        }
    }
}
