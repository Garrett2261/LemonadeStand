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
        //Customer Customer = new Customer();
        Inventory Inventory = new Inventory();
        Recipe Recipe = new Recipe();
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
            Day DayOfLemonadeStand = new Day();
            DayOfLemonadeStand.CheckTodaysWeather();
            Store.ExploreStore();
            Inventory.DisplayAmountOfEachIngredient();
            Recipe.GetNumberOfLemonsUsed();
            Recipe.GetNumberOfCupsOfSugarUsed();
            Recipe.GetNumberOfIceCubesUsed();
            price = Player.SetPrice();
            counter = 0;
            int customers = Day.CountCustomers();
            while(counter < customers)
            {
                if(counter > 0)
                {
                    counter++;
                    Customer Customer = new Customer();
                    Customer.BuyLemonade(price);
                    Player.CalculateTotal();
                }    
            }
            Inventory.SubtractLemonsFromCupsSold(Day, Recipe);
            Inventory.SubtractCupsOfSugarFromCupsSold(Day, Recipe);
            Inventory.SubstractIceCubesFromCupsSold(Day, Recipe);
            Inventory.DisplayAmountOfEachIngredient();
            Console.WriteLine("You now have" + ' ' + "$" + Player.moneyLeft + ".");
            if(Player.dailyProfit > 0)
            {
                Console.WriteLine("You made a profit of" + ' ' + "$" + Player.dailyProfit + ' ' + "for the day.");
            }
            else if(Player.dailyProfit < 0)
            {
                Console.WriteLine("You went under today and had a loss of" + ' ' + "$" + Player.dailyProfit + ' ' + "for the day.");
            }
            if(Player.totalProfit > 0)
            {
                Console.WriteLine("For the number of days you have played so far, you have a profit of" + ' ' + "$" + Player.totalProfit + ".");
            }
            else if(Player.totalProfit < 0)
            {
                Console.WriteLine("For the number od days you have played so far, you have a loss of -" + "$" + Player.totalProfit + ".");
            }
            
            
            
            
            
            
            
            



        }
    }
}
