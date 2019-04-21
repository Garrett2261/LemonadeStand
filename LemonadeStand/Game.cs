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
        Store Store = new Store();
        Customer Customer = new Customer();
        public int counter;
        public Random Rand = new Random();
        public double price;
        public int numberOfDays;
        

        
        
        
        public Game()
        {
            this.numberOfDays = Player.SetLength();
        }

        

        public void StartGame()
        {
            Day.CheckWeatherForecast();
            Day.CheckTodaysWeather();
            counter = 0;
            int customers = Day.CountCustomers();
            while(counter < customers)
            {
                if(counter > 0)
                {
                    var money = Player.CalculateTotal();
                    Console.WriteLine(money);
                    counter++;

                }
                else
                {
                    var cost = Player.SetPrice();
                    price = cost;
                    var total = Player.CalculateTotal();
                    Console.WriteLine(total);
                    counter++;
                }
                
            }
            Player.SetPrice();
            //Player.CalculateTotal();

            Console.WriteLine(Math.Floor(210.0/20));
            
            
            
            
            



        }
    }
}
