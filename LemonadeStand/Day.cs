using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        Weather Weather = new Weather();
        public Random Demand = new Random();
        public string demand;
        public string weatherCondition;
        public int temperature;
        public int customersForDay;
        public int potentialCustomersForDay;
        public int cupsSold;
        public int cupsSoldForTheDay;
        List<string> WeatherForecast = new List<string>();
        public Day()
        {
            this.weatherCondition = Weather.GetWeatherCondition();
            this.temperature = Weather.GetTemperature();
        }
        //The better the weather then the more potential customers that will show up which means a higher demand. 
        public int CountPotentialCustomers()
        {
            if (weatherCondition == "Clear Skies")
            {
                if ((temperature >= 75) && (temperature <= 100))
                {
                    potentialCustomersForDay = 100;
                }
                else if ((temperature >= 50) && (temperature <= 75))
                {
                    potentialCustomersForDay = 75;
                }
            }
            else if (weatherCondition == "Rainy")
            {
                if ((temperature >= 75) && (temperature <= 100))
                {
                    potentialCustomersForDay = 48;
                }
                else if ((temperature >= 50) && (temperature <= 75))
                {
                    potentialCustomersForDay = 24;
                }
            }
            else if (weatherCondition == "Partly Cloudy")
            {
                if ((temperature >= 75) && (temperature <= 100))
                {
                    potentialCustomersForDay = 25;
                }
                else if ((temperature >= 50) && (temperature <= 75))
                {
                    potentialCustomersForDay = 50;
                }
            }
            else if (weatherCondition == "Overcast")
            {
                if ((temperature >= 75) && (temperature <= 100))
                {
                    potentialCustomersForDay = 50;
                }
                else if ((temperature >= 50) && (temperature <= 75))
                {
                    potentialCustomersForDay = 25;
                }
            }
            return potentialCustomersForDay;
        }
        //The amount of Customers should be based on the price and weather. How ever many customers I get is how many times I run the BuyLemonade function from the Customer Class
        //Do that in the Game Class in the StartGame function
        public int CountCustomers(Player Player)
        {
           if(weatherCondition == "Clear Skies")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(50, 75);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(50,65);
                }
                else
                {
                    customersForDay = 50;
                }
                
            }
           else if(weatherCondition == "Rainy")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(25,40);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(15, 20);
                }
                else
                {
                    customersForDay = 15;
                }
            }
           else if(weatherCondition == "Partly Cloudy")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(50, 75);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(30, 60);
                }
                else
                {
                    customersForDay = 50;
                }
            }
           else if(weatherCondition == "Overcast")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(15, 25);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(15, 25);
                }
                else
                {
                    customersForDay = 15;
                }
            }
            else
            {
                customersForDay = 15;
            }
            return customersForDay;
        }
        public int CheckCupsBoughtFromSale(int customerCups)
        {
            cupsSold = customerCups;
            return cupsSold;
        }
        public int CheckTotalCupsBoughtForTheDay()
        {
            if(cupsSoldForTheDay > 0)
            {
                cupsSoldForTheDay += cupsSold;
            }
            else
            {
                cupsSoldForTheDay = cupsSold;
            }
            return cupsSoldForTheDay;
        }

        public void CheckWeatherForecast()
        {
            for (int i = 0; i < 7; ++i)
            {
                var dayWeather = Weather.GetWeatherCondition();
                var dayTemperature = Weather.GetTemperature();
                WeatherForecast.Add((dayWeather + ' ' + dayTemperature.ToString()));
                Console.WriteLine(dayWeather + ' ' + dayTemperature);
                
            }    
        }
        public void CheckTodaysWeather()
        {
            Console.WriteLine(weatherCondition + ' ' + temperature);
                 
        }    
    }
}
