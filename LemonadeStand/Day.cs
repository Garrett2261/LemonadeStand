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
        public bool chanceOfBuying;
        public string weatherCondition;
        public int temperature;
        public int chance;
        List<string> WeatherForecast = new List<string>();







        public Day()
        {
            Weather Weather = new Weather();
            Customer Customer = new Customer();
            amountEarnedOnDay = 0;
        }

        

        public void CheckPurchases()
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
            temperature = dayTemperature;
            

            
            
            
            
            
            
        }

        
    }
}
