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
            for(int i = 0; i < 7; ++i)
            {
                Console.Write(Weather.GetWeatherCondition());
                Console.Write(Weather.GetTemperature());
                Console.ReadLine();
            }
            
        }

        public void CheckTodaysWeather()
        {
            Weather.GetWeatherCondition();
            Weather.GetTemperature();

            
            
            
            
            
            
        }
    }
}
