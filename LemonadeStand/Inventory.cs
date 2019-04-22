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
        Customer Customer = new Customer();
        Recipe Recipe = new Recipe();
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

        public void DisplayAmountOfEachIngredient()
        {
            Console.WriteLine("You have" + ' ' + lemons + ' ' + "lemons.");
            Console.ReadLine();
            Console.WriteLine("You have" + ' ' + cupsOfSugar + ' ' + "cups of sugar.");
            Console.ReadLine();
            Console.WriteLine("You have" + ' ' + iceCubes + ' ' + "ice cubes.");
            Console.ReadLine();
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

        public int AddCupsOfSugarFromStore(int cupsOfSugarBought)
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

        public int AddIceCubesFromStore(int iceCubesBought)
        {
            if(iceCubes >= 0)
            {
                iceCubes += iceCubesBought;
            }
            else
            {
                iceCubes = iceCubesBought;
            }
            return iceCubes;
        }

        public int SubtractLemonsFromCupsSold(Day Day, Recipe Recipe)
        {
            if(lemons >= 0)
            {
                lemons -= Day.cupsSold * Recipe.GetNumberOfLemonsUsed();
            }
            else if(lemons < 0)
            {
                lemons = 0;
            }
            return lemons;
        }

        public int SubtractCupsOfSugarFromCupsSold(Day Day, Recipe Recipe)
        {
            if(cupsOfSugar >= 0)
            {
                cupsOfSugar -= Day.cupsSold * Recipe.GetNumberOfCupsOfSugarUsed();
            }
            else if(cupsOfSugar < 0)
            {
                cupsOfSugar = 0;
            }
            return cupsOfSugar;
        }

        public int SubstractIceCubesFromCupsSold(Day Day, Recipe Recipe)
        {
            if(iceCubes >= 0)
            {
                iceCubes -= Day.cupsSold * Recipe.GetNumberOfIceCubesUsed();
            }
            else if(iceCubes < 0)
            {
                iceCubes = 0;
            }
            return iceCubes;
        }
    }
}
