using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public double cupsOfLemonade;
        public double customerTotal;
        public int maxMoneyToPay;
        public double maxCostOfLemonade;
        public Random Random = new Random();
        Weather Weather = new Weather();
        Player Player = new Player();
        public Customer()
        {
            this.maxMoneyToPay = Random.Next(0,5);
            this.maxCostOfLemonade = Random.NextDouble();
        }

        public double BuyLemonade(double price /*string weather, int temperature*/)
        {
            //price = Player.SetPrice();
            if(price > maxCostOfLemonade)
            {
                cupsOfLemonade = Random.Next(0, 1);
                
            }
            //Include the max cost of lemonade too in this function.
            else if(price <= maxCostOfLemonade)
            {
                //weather = Weather.GetWeatherCondition();
                //temperature = Weather.GetTemperature();
                cupsOfLemonade = Math.Floor(maxMoneyToPay / price);
                
            }
            return cupsOfLemonade;
            


            //return an int for the cupsOfLemonade variable and the number returned is based on factors such as the weather and price
            //This will vary from customer to customer and also may depend on the amount of money 
            //Or have a thing where depending on the price a certain number of cups will be bough
        }


    }
}
