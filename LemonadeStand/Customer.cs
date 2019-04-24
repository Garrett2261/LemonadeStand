using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int cupsOfLemonade;
        public int spendingLimit;
        public double costLimit;
        public Random Random = new Random();
        Inventory Inventory = new Inventory();
        Day Day = new Day();
        public Customer()
        {
            this.spendingLimit = Random.Next(0,5);
            this.costLimit = Random.NextDouble();
        }

        public void BuyLemonade(double price/*string weather, int temperature*/)
        {
            
            if(price > costLimit)
            {
                cupsOfLemonade = Convert.ToInt32(Random.Next(0, 1));
                Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
            }
            //Include the max cost of lemonade too in this function.
            else if(price <= costLimit)
            {
                //weather = Weather.GetWeatherCondition();
                //temperature = Weather.GetTemperature();
                cupsOfLemonade = Convert.ToInt32(Math.Floor(spendingLimit / price));
                Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                
            }
            Day.CheckCupsBoughtFromSale(cupsOfLemonade);
            
            
            
            


            //return an int for the cupsOfLemonade variable and the number returned is based on factors such as the weather and price
            //This will vary from customer to customer and also may depend on the amount of money 
            //Or have a thing where depending on the price a certain number of cups will be bough
        }


    }
}
