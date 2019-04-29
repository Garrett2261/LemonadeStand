using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int paperCups;
        public int lemons;
        public int cupsOfSugar;
        public int iceCubes;
        public Inventory() 
        {
            
        }

        public void DisplayAmountOfEachIngredient()
        {
            Console.WriteLine("You have" + ' ' + paperCups + ' ' + "paper cups.");
            Console.ReadLine();
            Console.WriteLine("You have" + ' ' + lemons + ' ' + "lemons.");
            Console.ReadLine();
            Console.WriteLine("You have" + ' ' + cupsOfSugar + ' ' + "cups of sugar.");
            Console.ReadLine();
            Console.WriteLine("You have" + ' ' + iceCubes + ' ' + "ice cubes.");
            Console.ReadLine();
        }

        public int AddPaperCupsFromStore(int paperCupsBought)
        {
            if(paperCups >= 0)
            {
                paperCups += paperCupsBought;
            }
            else
            {
                paperCups = paperCupsBought;
            }
            return paperCups;
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

        public int GetPaperCupsRemaining()
        {
            if(paperCups >= 0)
            {
                paperCups -= 0;
            }
            else if(paperCups < 0)
            {
                paperCups = 0;
            }
            return paperCups;
        }

        public int GetLemonsRemaining()
        {
            if(lemons >= 0)
            {
                lemons -= 0;
            }
            else if(lemons < 0)
            {
                lemons = 0;
            }
            return lemons;
        }

        public int GetCupsOfSugarRemaining()
        {
            if(cupsOfSugar >= 0)
            {
                cupsOfSugar -= 0;
            }
            else if(cupsOfSugar < 0)
            {
                cupsOfSugar = 0;
            }
            return cupsOfSugar;
        }

        public int GetIceCubesRemaining()
        {
            if(iceCubes >= 0)
            {
                iceCubes -= 0;
            }
            else if(iceCubes < 0)
            {
                iceCubes = 0;
            }
            return iceCubes;
        }
    }
}
