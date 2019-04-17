using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public double startingMoney;
        public double MoneyMade;
        public int NumberOfDays;
        public int NumberOfLemons;
        public int CupsOfSugar;
        public int NumberOfIceCubes;
        public double costOfLemonade;
        public double totalCost;
        public double totalCups;
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

        public double CalculateTotal(double price)
        {
            price = costOfLemonade;
            Customer Customer = new Customer();
            totalCups = Customer.BuyLemonade(price);
            startingMoney = 0;
            totalCost = totalCups * price;
            if(MoneyMade > 0)
            {
                MoneyMade += totalCost;
            }
            else
            {
                MoneyMade = totalCost;
            }
            return MoneyMade;
            
            

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
