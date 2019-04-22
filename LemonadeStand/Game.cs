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
            Store.ExploreStore();
            counter = 0;
            int customers = Day.CountCustomers();
            while(counter < customers)
            {
                if(counter > 0)
                {
                    Customer.BuyLemonade(price);
                    Player.CalculateTotal();
                    counter++;

                }
                else
                {
                    price = Player.SetPrice();
                    Customer.BuyLemonade(price);
                    Player.CalculateTotal();
                    counter++;
                }
                
            }
            Console.WriteLine("The day is now over. The total money you made today was" + ' ' + "$" + (Player.moneyMade) + ".");
            
            Player.SetPrice();
            //Player.CalculateTotal();

            Console.WriteLine(Math.Floor(210.0/20));
            
            
            
            
            



        }
    }
}
