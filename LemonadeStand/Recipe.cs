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
        public int iceCubesPerCup;
        Inventory Inventory = new Inventory();
        public Recipe()
        {

        }

        public int GetNumberOfLemonsUsed()
        {
            Console.WriteLine("The basic recipe amounts for 4 lemons. You can change this and set it to whatever you'd like.");
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

        public int GetNumberOfCupsOfSugarUsed()
        {
            Console.WriteLine("The basic recipe amounts for 4 cups of sugar. You can change this and set it to whatever you'd like.");
            Console.WriteLine("How many cups of sugar would you like to use in your recipe?");
            string number = Console.ReadLine();
            int sugar = Int32.Parse(number);
            if(sugar <= Inventory.cupsOfSugar)
            {
                cupsOfSugar = sugar;
            }
            else if(sugar > Inventory.cupsOfSugar)
            {
                Console.WriteLine("You don't have that many cups of sugar. Either buy some more from the store, or choose a lower amount.");
            }
            return cupsOfSugar;
        }

        public int GetNumberOfIceCubesPerCup()
        {
            Console.WriteLine("The basic recipe amounts for 4 ice cubes. You can change this and set it to whatever you'd like.");
            Console.WriteLine("How many ice cubes would you like to use in each cup?");
            string number = Console.ReadLine();
            int ice = Int32.Parse(number);
            if(ice <= Inventory.iceCubes)
            {
                iceCubesPerCup = ice;
            }
            else if(ice > Inventory.iceCubes)
            {
                Console.WriteLine("You don't have that many ice cubes. Either buy some more from the store, or choose a lower amount.");
            }
            return iceCubesPerCup;
        }
    }
}
