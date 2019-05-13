using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe:IUserInterface
    {
        public int lemons;
        public int cupsOfSugar;
        public int iceCubesPerCup;
        public Recipe()
        {

        }
        public int GetNumberOfLemonsUsed(Inventory Inventory)
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
        public int GetNumberOfCupsOfSugarUsed(Inventory Inventory)
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

        public int GetNumberOfIceCubesPerCup(Inventory Inventory)
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

        public void Help()
        {
            Console.WriteLine("Price/Quality Control Help");
            Console.WriteLine("The price you set will be a large factor in determining a customer's" +
                "happiness with your product. As the weather becomes hotter, and" +
                "clearer(not cloud, raining, or overcast), customers will be willing to pay" +
                "more for your product, because it's in a higher demand. As the weather" +
                "turns bad, there is less demand, and customers won't pay as much." +
                "" +
                "The amount of sugar and lemons you add determines the overall quality" +
                "of your product. Most people will expect 4 lemons and 4 cups of sugar" +
                "per pitcher of Lemonade, however to save on costs you can reduce this" +
                "(and reduce quality). If you're more concerned with satisfying the customers," +
                "you can add more lemons and sugar, and make a better" +
                "product that, over time, they'll be willing to pay a little extra for. (Also, if" +
                "you plan on overcharging for your product, this is a good way to help" +
                "offset the negative reputation you would otherwise build)." +
                "" +
                "The amount of ice should be determined by how hot is is outside. Too" +
                "much or too little ice will lower your quality, and your customer's" +
                "satisfaction! For instance, at 50 degrees, most people will want about 1-" +
                "4 ice cubes in their lemonade; as you get into the 95 degree days, I'd" +
                "recommend about 12-15 ice cubes per cup, to make sure it's nice and" +
                "cool for the customer. Another benefit of adding more ice, is that your pitcher" +
                "of lemonade will be able to make more cups-more ice and less" +
                "lemonade in each cups, means your pitcher of lemonade is spread out" +
                "among more cups!");
        }
    }
}
