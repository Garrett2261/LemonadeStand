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
            //Use if statements after the new customer object is made and then 
            Player.moneyMade = 0;
            Store.totalCostSpentOnIngredients = 0;
            Player.dailyProfit = 0;
            Day.CheckWeatherForecast();
            Day DayOfTheWeek = new Day();
            DayOfTheWeek.CheckTodaysWeather();
            Store.ExploreStore(Player, Inventory);
            Inventory.DisplayAmountOfEachIngredient();
            Recipe.GetNumberOfLemonsUsed(Inventory);
            Recipe.GetNumberOfCupsOfSugarUsed(Inventory);
            Recipe.GetNumberOfIceCubesPerCup(Inventory);
            Pitcher Pitcher = new Pitcher();
            Pitcher.GetCupsInPitcher(Recipe);
            price = Player.SetPrice();
            counter = 0;
            int customers = DayOfTheWeek.CountCustomers(Player);
            while((Inventory.paperCups > 0 && Inventory.lemons > 0 && Inventory.cupsOfSugar > 0 && Inventory.iceCubes > 0) && counter < customers)
            {
                if (counter >= 0)
                {
                    Console.WriteLine("Customer " + (counter + 1));
                    counter++;
                    Customer Customer = new Customer();
                    if(DayOfTheWeek.weatherCondition == "Clear Skies" && DayOfTheWeek.temperature >= 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if(chance <= 95)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                        
                    }
                    else if(DayOfTheWeek.weatherCondition == "Clear Skies" && DayOfTheWeek.temperature < 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if(chance <= 80)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if(DayOfTheWeek.weatherCondition == "Rainy" && DayOfTheWeek.temperature >= 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if(chance <= 30)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if (DayOfTheWeek.weatherCondition == "Rainy" && DayOfTheWeek.temperature < 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if (chance <= 20)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if (DayOfTheWeek.weatherCondition == "Partly Cloudy" && DayOfTheWeek.temperature >= 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if (chance <= 85)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if (DayOfTheWeek.weatherCondition == "Partly Cloudy" && DayOfTheWeek.temperature < 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if (chance <= 65)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if (DayOfTheWeek.weatherCondition == "Overcast" && DayOfTheWeek.temperature >= 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if (chance <= 55)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }
                    else if (DayOfTheWeek.weatherCondition == "Overcast" && DayOfTheWeek.temperature < 75)
                    {
                        int chance = ChanceOfBuying.Next(1, 100);
                        if (chance <= 45)
                        {
                            Customer.BuyLemonade(price);
                            if (Pitcher.cupsInPitcher == 0)
                            {
                                Inventory.lemons -= Recipe.lemons;
                                Inventory.cupsOfSugar -= Recipe.cupsOfSugar;
                                Pitcher.cupsInPitcher += Pitcher.cupsForPitcher;
                            }
                            else if (Pitcher.cupsInPitcher > 0)
                            {
                                Pitcher.cupsInPitcher -= Customer.cupsOfLemonade;
                            }
                            Inventory.paperCups -= Customer.cupsOfLemonade;
                            Inventory.iceCubes -= Customer.cupsOfLemonade * Recipe.iceCubesPerCup;
                            Inventory.GetPaperCupsRemaining();
                            Inventory.GetLemonsRemaining();
                            Inventory.GetCupsOfSugarRemaining();
                            Inventory.GetIceCubesRemaining();
                            Player.CalculateTotal(Customer);
                        }
                    }


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
