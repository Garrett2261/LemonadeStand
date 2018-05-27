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





        
        public Day()
        {
            Weather Weather = new Weather();
            
        }

        public void SeeDemand()
        {
            
        }

        public void CheckWeatherForecast()
        {
            Weather.GetWeeklyForecast();
            Weather.GetDailyForecast();
        }
    }
}
