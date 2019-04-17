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
        public int counter;
        public Random Rand = new Random();
        public double price;

        
        
        
        public Game()
        {
            Player Player = new Player();
            Weather Weather = new Weather();
            Store Store = new Store();
            Day Day = new Day();

            
        }

        public void StartGame()
        {
            counter = 0;
            
            while(counter < 26)
            {
                if(counter > 0)
                {
                    var money = Player.CalculateTotal(price);
                    Console.WriteLine(money);
                    counter++;

                }
                else
                {
                    var cost = Player.SetPrice();
                    price = cost;
                    var total = Player.CalculateTotal(cost);
                    Console.WriteLine(total);
                    counter++;
                }
                
            }
            Player.SetPrice();
            //Player.CalculateTotal();

            Console.WriteLine(Math.Floor(210.0/20));
            
            Console.WriteLine("Welcome to Lemondade Stand! The goal of the game is to make as much money as you can in one week selling lemonade. You start off with $20.00 and you will need ingredients for your lemonade. These ingredients can be found in the store where you can purchase them. After every day you will get a report on how much of a profit you made for that day. If you go bankrupt, you lose the game. Good luck!");
            Day.CheckWeatherForecast();
            Day.CheckTodaysWeather();
            Store.LemonCost();
            



        }
    }
}
