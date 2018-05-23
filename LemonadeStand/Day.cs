using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather Weather;



        
        public Day()
        {
            
        }

        public void SeeDemand()
        {
            
        }

        public void CheckWeatherForecast()
        {
            Weather.GetWeeklyForecast();
        }
    }
}
