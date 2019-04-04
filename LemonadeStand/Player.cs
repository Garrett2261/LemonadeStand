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
        public double costOfLemonade;
        Inventory Inventory = new Inventory();
        Day Day = new Day();
        public Player ()
        {
            Inventory Inventory = new Inventory();
            Day Day = new Day();

        }

        public void GetRecipe()
        {
            Inventory.CheckLemons();


            

        }

        public void SellLemonade()
        {
            Day Day = new Day();
            
        }
        
        public double SetPrice()
        {
            Console.WriteLine("What would you like your price for a cup of lemonade to be? Please enter your price in total cents. For example if your price was $3.50, you would enter 350.");
            string price = Console.ReadLine();
            int cost = Int32.Parse(price);
            costOfLemonade = cost * .01;
            return costOfLemonade;
        }
    }
}
