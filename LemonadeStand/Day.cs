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
        public string weatherCondition;
        public int temperature;
        public int customersForDay;
        List<string> WeatherForecast = new List<string>();







        public Day()
        {
            this.weatherCondition = Weather.GetWeatherCondition();
            this.temperature = Weather.GetTemperature();
        }

        public int CountCustomers()
        {
           if(weatherCondition == "Sunny")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(40,50);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(25,40);
                }
                else
                {
                    customersForDay = 25;
                }
            }
           else if(weatherCondition == "Rainy")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(15, 25);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(5, 15);
                }
                else
                {
                    customersForDay = 5;
                }
            }
           else if(weatherCondition == "Partly Cloudy")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(35, 45);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(20, 35);
                }
                else
                {
                    customersForDay = 20;
                }
            }
           else if(weatherCondition == "Overcast")
            {
                if((temperature >= 75) && (temperature <= 100))
                {
                    customersForDay = Demand.Next(5, 15);
                }
                else if((temperature >= 50) && (temperature <= 75))
                {
                    customersForDay = Demand.Next(1, 5);
                }
                else
                {
                    customersForDay = 1;
                }
            }
            else
            {
                customersForDay = Demand.Next(0, 50);
            }
            return customersForDay;
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
            //var dayWeather = Weather.GetWeatherCondition();
            //var dayTemperature = Weather.GetTemperature();
            Console.WriteLine(weatherCondition + ' ' + temperature);
            Console.ReadLine();
            //weatherCondition = dayWeather;
            //temp = dayTemperature;
            

            
            
            
            
            
            
        }

        
    }
}
