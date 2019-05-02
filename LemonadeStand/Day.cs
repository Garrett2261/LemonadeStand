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
        public double amountEarnedOnDay;
        public double profitEarnedForDay;
        public Random Demand = new Random();
        public string demand;
        public string weatherCondition;
        public int temperature;
        public int customersForDay;
        public int cupsSold;
        public int cupsSoldForTheDay;
        List<string> WeatherForecast = new List<string>();
        public Day()
        {
            this.weatherCondition = Weather.GetWeatherCondition();
            this.temperature = Weather.GetTemperature();
        }
        
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
                    customersForDay = Demand.Next(50,75);
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
                    customersForDay = Demand.Next(25, 50);
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
           else if(weatherCondition == "Partly Cloudy")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(50, 75);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(25, 50);
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
                Console.ReadLine();
            }    
        }
        public void CheckTodaysWeather()
        {
            Console.WriteLine(weatherCondition + ' ' + temperature);
            Console.ReadLine();        
        }    
    }
}
