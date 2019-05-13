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
        Store Store = new Store();
        Inventory Inventory = new Inventory();
        Recipe Recipe = new Recipe();
        public int counter;
        public int secondCounter;
        public Random ChanceOfBuying = new Random();
        public double price;
        public int numberOfDays;
        

        
        
        
        public Game()
        {
            this.numberOfDays = Player.SetLength();
        }
        public void StartGame()
        {
            Player.moneyMade = 0;
            Store.totalCostSpentOnIngredients = 0;
            Player.dailyProfit = 0;
            Day.CheckWeatherForecast();
            Day DayOfTheWeek = new Day();
            DayOfTheWeek.CheckTodaysWeather();
            Store.ExploreStore(Player, Inventory);
            Inventory.DisplayAmountOfEachIngredient();
            Console.WriteLine("Now that you have some ingredients, you can set the price and make the recipe for your lemonade. If you need help enter 'help'.");
            string action = Console.ReadLine();
            switch (action)
            {
                case "help":
                    Recipe.Help();
                    break;
                default:
                    break;
            }
            price = Player.SetPrice();
            Recipe.GetNumberOfLemonsUsed(Inventory);
            Recipe.GetNumberOfCupsOfSugarUsed(Inventory);
            Recipe.GetNumberOfIceCubesPerCup(Inventory);
            Inventory.lemons -= Recipe.lemons;
            Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
            Pitcher Pitcher = new Pitcher();
            Pitcher.GetCupsInPitcher(Recipe);
            counter = 0;
            secondCounter = 1;
            int customers = DayOfTheWeek.CountCustomers(Player);
            int cupsInPitcher = Pitcher.cupsInPitcher;

            while ((Inventory.paperCups > 0 && Inventory.lemons > 0 && Inventory.cupsOfSugar > 0 && Inventory.iceCubes > 0) && counter < customers)
            {
                if (counter >= 0)
                {
                    if(secondCounter % 10 == 0)
                    {
                        Player.ChangePriceDuringDay();
                    }
                    secondCounter++;
                    Console.WriteLine("Customer " + (counter + 1));
                    counter++;
                    Customer Customer = new Customer();
                    Customer.BuyLemonade(DayOfTheWeek, Player);
                    if(Customer.cupsOfLemonade > Pitcher.cupsInPitcher)
                    {
                        Inventory.paperCups -= Customer.cupsOfLemonade;
                        Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                        Inventory.GetPaperCupsRemaining();
                        Inventory.GetIceCubesRemaining();
                        Customer.cupsOfLemonade -= Pitcher.cupsInPitcher;
                        Pitcher.cupsInPitcher -= Pitcher.cupsInPitcher;
                        Inventory.lemons -= Recipe.lemons;
                        Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                        Pitcher.cupsInPitcher += cupsInPitcher;
                        Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                    }
                    else if(Customer.cupsOfLemonade == Pitcher.cupsInPitcher)
                    {
                        Inventory.paperCups -= Customer.cupsOfLemonade;
                        Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                        Inventory.GetPaperCupsRemaining();
                        Inventory.GetIceCubesRemaining();
                        Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                        Inventory.lemons -= Recipe.lemons;
                        Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                        Pitcher.cupsInPitcher += cupsInPitcher;
                    }
                    else if (Customer.cupsOfLemonade < Pitcher.cupsInPitcher)
                    {
                        Inventory.paperCups -= Customer.cupsOfLemonade;
                        Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                        Inventory.GetPaperCupsRemaining();
                        Inventory.GetIceCubesRemaining();
                        Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                    }
                    
                    Player.CalculateTotal(Customer);
                }
            }
            
            if(Inventory.paperCups == 0 || Inventory.lemons == 0 || Inventory.cupsOfSugar == 0 || Inventory.iceCubes == 0)
            {
                Console.WriteLine("You ran out of ingredients and cannot sell anymore lemonade for the rest of the day. Please try again tomorrow.");
                Console.WriteLine("You made a total of $" + Player.moneyMade + ' ' + "before you ran out of ingredients.");
            } 
            if(counter >= customers)
            {
                Console.WriteLine("The day is over now. You made $" + Player.moneyMade + ' ' + "for the day.");
            }
            if(Pitcher.cupsInPitcher > 0)
            {
                Inventory.lemons -= Recipe.lemons;
                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
            }
            if(Inventory.iceCubes > 0)
            {
                Console.WriteLine("Your remaining ice cubes have melted.");
                Inventory.iceCubes -= Inventory.iceCubes;
            }
            Inventory.DisplayAmountOfEachIngredient();
            Console.WriteLine("You now have" + ' ' + "$" + Player.money + ".");
            Player.GetDailyProfit(Store);
            Player.GetTotalRunningProfit();
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
