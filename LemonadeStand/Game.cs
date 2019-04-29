using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //double startingMoney = 20.00;
        Player Player = new Player();
        Day Day = new Day();
        Weather Weather = new Weather();
        Store Store = new Store();
        //Customer Customer = new Customer();
        Inventory Inventory = new Inventory();
        Recipe Recipe = new Recipe();
        public int counter;
        public int secondCounter;
        public Random Rand = new Random();
        public double price;
        public int numberOfDays;
        

        
        
        
        public Game()
        {
            this.numberOfDays = Player.SetLength();
        }
        public void WhileLoopExplanation()
        {
            int i = 0;
            while(i < 2)
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = 1;

                i++;

                while(j < 2)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                }
            }
        }

        

        public void StartGame()
        {
            
            Day.CheckWeatherForecast();
            Day DayOfTheWeek = new Day();
            DayOfTheWeek.CheckTodaysWeather();
            Store.ExploreStore(Player);
            Inventory.DisplayAmountOfEachIngredient();
            Recipe.GetNumberOfLemonsUsed();
            Recipe.GetNumberOfCupsOfSugarUsed();
            Recipe.GetNumberOfIceCubesPerCup();
            Pitcher Pitcher = new Pitcher();
            Pitcher.GetCupsInPitcher(Recipe);
            price = Player.SetPrice();
            secondCounter = 0;
            int customers = DayOfTheWeek.CountCustomers();
            while(Inventory.paperCups > 0 || Inventory.lemons > 0 || Inventory.cupsOfSugar > 0 || Inventory.iceCubes > 0)
            {
                
                while(secondCounter < customers)
                {
                    if (secondCounter >= 0)
                    {
                        secondCounter++;
                        Customer Customer = new Customer();
                        Customer.BuyLemonade(price);
                        if(Pitcher.cupsInPitcher == 0)
                        {
                            Inventory.lemons -= Recipe.lemons;
                            Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                            Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                        }
                        else if(Pitcher.cupsInPitcher > 0)
                        {
                            Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                        }
                        Inventory.paperCups -= Customer.cupsOfLemonade;
                        Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                        Inventory.GetPaperCupsRemaining();
                        Inventory.GetLemonsRemaining();
                        Inventory.GetCupsOfSugarRemaining();
                        Inventory.GetIceCubesRemaining();
                        //Inventory.SubtractPaperCupsFromLemonadeSold(Customer);
                        //Inventory.SubtractIceCubesFromCupsSold(Customer, Recipe);
                        Player.CalculateTotal(Customer);
                    }
                }
                Console.WriteLine("You have run out of ingredients for your lemonade. You are sold out. Please try again tomorrow.");
                break;
            }
            
            //Inventory.SubtractLemonsFromCupsSold(, Recipe);
            //Inventory.SubtractCupsOfSugarFromCupsSold(DayOfTheWeek, Recipe);
            //Inventory.SubstractIceCubesFromCupsSold(DayOfTheWeek, Recipe);
            Inventory.DisplayAmountOfEachIngredient();
            Console.WriteLine("You now have" + ' ' + "$" + Player.money + ".");
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
