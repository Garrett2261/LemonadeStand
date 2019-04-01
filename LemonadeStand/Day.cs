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
        public double AmountEarnedOnDay;
        public double ProfitEarnedForDay;
        Random Demand = new Random();
        public int ChanceOfBuying;





        
        public Day()
        {
            Weather Weather = new Weather();
            
        }

        public void SeeDemand()
        {
            


        }


        public void CheckWeatherForecast()
        {
            List<string> WeatherForecast = new List<string>();
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

            
            
            
            
            
            
        }
    }
}
