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
        public double spendingLimit;
        public double costLimit;
        public Random Random = new Random();
        public Customer()
        {
            
            //this.spendingLimit = Random.Next(100, 500)/100;
            //this.costLimit = Random.NextDouble();
        }
        //Get the number of cups the customers will buy based on the weather conditions and the price
        //Base how many cups the Customer will possibly by based on the different weather conditions
        //and temperatures, as well as the different prices. 
        //Think about doing a willingness to pay in regards to the price of the cup of lemonade and 
        public int BuyLemonade(Day Day, Player Player)
        {
            if(Day.weatherCondition == "Clear Skies" && (Day.temperature >= 75))
            {
                costLimit = Random.Next(76, 100) * .01;
                
                if (Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 5);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if(Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
                
            }
            else if (Day.weatherCondition == "Clear Skies" && (Day.temperature < 75))
            {
                costLimit = Random.Next(76, 90) * .01;
                
                if (Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 4);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if (Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }

            }
            else if (Day.weatherCondition == "Rainy" && (Day.temperature >= 75))
            {
                costLimit = Random.Next(20, 25) * .01;
                
                if(Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 2);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if(Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
            }
            else if (Day.weatherCondition == "Rainy" && (Day.temperature < 75))
            {
                costLimit = Random.Next(10, 20) * .01;
                
                if (Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 2);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if (Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
            }
            else if (Day.weatherCondition == "Partly Cloudy" && (Day.temperature >= 75))
            {
                costLimit = Random.Next(55, 70) * .01;
                
                if(Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 4);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if(Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
            }
            else if (Day.weatherCondition == "Partly Cloudy" && (Day.temperature < 75))
            {
                costLimit = Random.Next(55, 60) * .01;
                
                if (Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 3);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if (Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
            }
            else if (Day.weatherCondition == "Overcast" && (Day.temperature >= 75))
            {
                costLimit = Random.Next(45, 50) * .01;
                
                if(Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 3);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if(Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }
                
            }
            else if (Day.weatherCondition == "Overcast" && (Day.temperature < 75))
            {
                costLimit = Random.Next(30, 40) * .01;
                
                if (Player.costOfLemonade <= costLimit)
                {
                    cupsOfLemonade = Random.Next(1, 2);
                    Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
                }
                else if (Player.costOfLemonade > costLimit)
                {
                    cupsOfLemonade = 0;
                }

            }

            return cupsOfLemonade;
        }
    }
}
