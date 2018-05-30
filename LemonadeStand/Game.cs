using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player Player = new Player();
        Day Day = new Day();
        Weather Weather = new Weather();
        
        
        
        public Game()
        {
            Player Player = new Player();
            Weather Weather = new Weather();
            Store Store = new Store();
            Day Day = new Day();

            
        }

        public void StartGame()
        {
            Day.CheckTodaysWeather();
            Day.CheckWeatherForecast();



        }
    }
}
