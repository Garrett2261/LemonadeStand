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
        public int temp;
        List<string> WeatherForecast = new List<string>();







        public Day(/*string weather, int temperature*/)
        {
            //this.weatherCondition = weather;
            //this.temp = temperature;
            
            //amountEarnedOnDay = 0;
        }

        public void SeeDemand()
        {
           
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
            var dayWeather = Weather.GetWeatherCondition();
            var dayTemperature = Weather.GetTemperature();
            Console.WriteLine(dayWeather + ' ' + dayTemperature);
            Console.ReadLine();
            weatherCondition = dayWeather;
            temp = dayTemperature;
            

            
            
            
            
            
            
        }

        
    }
}
