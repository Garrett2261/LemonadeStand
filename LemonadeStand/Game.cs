using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public int NumberOfDays;
        public double Price;
        public int NumberofLemons;
        public int CupsOfSugar;
        public int NumberOfIceCubes;
        Day Day1 = new Day();
        
        
        public Game()
        {
            Player Player = new Player();
            Weather Weather = new Weather();
            Store Store = new Store();
            Day Day = new Day();

            
        }

        public void StartGame()
        {
            Day1.CheckWeatherForecast();
        }
    }
}
