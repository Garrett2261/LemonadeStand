using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double startMoney;
        public double remainingMoney;
        public double paperCupCost;
        public double lemonCost;
        public double sugarCost;
        public double iceCubesCost;
        public int paperCupsBought;
        public int lemonsBought;
        public int cupsOfSugarBought;
        public int numberOfIceCubesBought;
        public double priceOfTwentyFivePaperCups;
        public double priceOfFiftyPaperCups;
        public double priceOfOneHundredPaperCups;
        public double priceOfTenLemons;
        public double priceOfThirtyLemons;
        public double priceOfSeventyFiveLemons;
        public double priceOfEightCupsOfSugar;
        public double priceOfTwentyCupsOfSugar;
        public double priceOfFortyEightCupsOfSugar;
        public double priceOfOneHundredIceCubes;
        public double priceOfTwoHundredFiftyIceCubes;
        public double priceOfFiveHundredIceCubes;
        public double totalCostSpentOnIngredients;
        Inventory Inventory = new Inventory();
        Player Player = new Player();
        public Store()
        {
            //this.startMoney = 20.00;
            this.priceOfTwentyFivePaperCups = 0.82;
            this.priceOfFiftyPaperCups = 1.60;
            this.priceOfOneHundredPaperCups = 2.83;
            this.priceOfTenLemons = 0.65;
            this.priceOfThirtyLemons = 2.16;
            this.priceOfSeventyFiveLemons = 4.34;
            this.priceOfEightCupsOfSugar = 0.53;
            this.priceOfTwentyCupsOfSugar = 1.51;
            this.priceOfFortyEightCupsOfSugar = 3.46;
            this.priceOfOneHundredIceCubes = 0.96;
            this.priceOfTwoHundredFiftyIceCubes = 2.14;
            this.priceOfFiveHundredIceCubes = 3.54;
        }

        public void ExploreStore(Player Player)
        {
            Console.WriteLine("Welcome to the store! Here you can buy all the ingredients you need for your lemonade such as lemons, sugar, and ice.");
            Console.WriteLine("Please choose 'lemons', 'sugar', or 'ice'. Or if you don't need any ingredients and or are done shopping, enter 'exit'.");
            string ingredient = Console.ReadLine();
            switch (ingredient)
            {
                case "lemons":
                    BuyLemons(Player);
                    break;
                case "sugar":
                    BuySugar(Player);
                    break;
                case "ice":
                    BuyIceCubes(Player);
                    break;
                case "exit":
                    break;
                default:
                    Console.WriteLine("Not a valid ingredient. You can only buy lemons, sugar, or ice. Please try again.");
                    break;
            }
            return;
        }
        
        public double GetRemainingMoney(double cost)
        {
            if(remainingMoney >= 0)
            {
                remainingMoney -= cost;
            }
            else
            {
                remainingMoney = startMoney - cost;
            }
            return remainingMoney;

        }
        public double SeeTotalCostForIngredients(double price)
        {
            totalCostSpentOnIngredients += price;
            return totalCostSpentOnIngredients;
        }

        

        public void BuyPaperCups(Player Player)
        {

            Console.WriteLine("You can either buy '25' paper cups for 0.82, '50' paper cups for 1.60, or '100' paper cups for 2.83. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "25":
                    paperCupsBought = 25;
                    break;
                case "50":
                    paperCupsBought = 50;
                    break;
                case "100":
                    paperCupsBought = 100;
                    break;
                case "menu":
                    ExploreStore(Player);
                    break;
                default:
                    Console.WriteLine("You can only purchase '25', '50', or '100' paper cups at a time. Please try again.");
                    BuyPaperCups(Player);
                    break;
            }
            double cost = PaperCupCost(paperCupsBought);
            if (Player.money >= cost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + paperCupsBought + ' ' + "paper cups.");
                SeeTotalCostForIngredients(cost);
                Player.money -= cost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddPaperCupsFromStore(paperCupsBought);
            }
            else if (Player.money < cost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of paper cups. Please choose a lower amount, or come back with more money. If you want to buy less paper cups, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyPaperCups(Player);
                        break;
                    case "menu":
                        ExploreStore(Player);
                        break;
                    default:
                        ExploreStore(Player);
                        break;
                }
            }

            BuyPaperCups(Player);
        }

        public void BuyLemons(Player Player)
        {
            
            Console.WriteLine("You can either buy '10' lemons for 0.65, '30' lemons for 2.16, or '75' lemons for 4.34. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "10":
                    lemonsBought = 10;
                    break;
                case "30":
                    lemonsBought = 30;
                    break;
                case "75":
                    lemonsBought = 75;
                    break;
                case "menu":
                    ExploreStore(Player);
                    break;
                default:
                    Console.WriteLine("You can only purchase '10', '30', or '75' lemons at a time. Please try again.");
                    BuyLemons(Player);
                    break;       
            }
            double cost = LemonCost(lemonsBought);
            if(Player.money >= cost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + lemonsBought + ' ' + "lemons.");
                SeeTotalCostForIngredients(cost);
                Player.money -= cost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddLemonsFromStore(lemonsBought);
            }
            else if(Player.money < cost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of lemons. Please choose a lower amount, or come back with more money. If you want to buy less lemons, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyLemons(Player);
                        break;
                    case "menu":
                        ExploreStore(Player);
                        break;
                    default:
                        ExploreStore(Player);
                        break;
                }
            }
            
            BuyLemons(Player);
            }
        public void BuySugar(Player Player)
        {
            Console.WriteLine("You can either buy '8' cups of sugar for 0.53, '20' cups of sugar for 1.51, or '48' cups of sugar for 3.46. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "8":
                    cupsOfSugarBought = 8;
                    break;
                case "20":
                    cupsOfSugarBought = 20;
                    break;
                case "48":
                    cupsOfSugarBought = 48;
                    break;
                case "menu":
                    ExploreStore(Player);
                    break;
                default:
                    Console.WriteLine("You can only purchase '8', '20', or '48' cups of sugar at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar(Player);
                    break;
            }
            double cost = SugarCost(cupsOfSugarBought);
            if (Player.money >= cost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + cupsOfSugarBought + ' ' + "cups of sugar.");
                SeeTotalCostForIngredients(cost);
                Player.money -= cost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddCupsOfSugarFromStore(cupsOfSugarBought);
            }
            else if(Player.money < cost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of sugar. Please choose a lower amount, or come back with more money. If you want to buy less sugar, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuySugar(Player);
                        break;
                    case "menu":
                        ExploreStore(Player);
                        break;
                    default:
                        ExploreStore(Player);
                        break;
                }
            }
            
            BuySugar(Player);
        }

        public void BuyIceCubes(Player Player)
        {
            Console.WriteLine("You can either buy '100' ice cubes for 0.96, '250' ice cubes for 2.14, or '500' ice cubes for 3.54. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "100":
                    numberOfIceCubesBought = 100;
                    break;
                case "250":
                    numberOfIceCubesBought = 250;
                    break;
                case "500":
                    numberOfIceCubesBought = 500;
                    break;
                case "menu":
                    ExploreStore(Player);
                    break;
                default:
                    Console.WriteLine("You can only purchase '100', '250', or '500' ice cubes at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar(Player);
                    break;
            }
            double cost = IceCubeCost(numberOfIceCubesBought);
            if (Player.money >= cost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + numberOfIceCubesBought + ' ' + "ice cubes.");
                SeeTotalCostForIngredients(cost);
                Player.money -= cost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + ' ' + "left.");
                Inventory.AddIceCubesFromStore(numberOfIceCubesBought);
            }
            else if (Player.money < cost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of ice cubes. Please choose a lower amount, or come back with more money. If you want to buy ice cubes, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyIceCubes(Player);
                        break;
                    case "menu":
                        ExploreStore(Player);
                        break;
                    default:
                        ExploreStore(Player);
                        break;
                }
            }
            BuyIceCubes(Player);
        }

        public double PaperCupCost(int paperCupsBought)
        {
            if (paperCupsBought == 25)
            {
                paperCupCost = priceOfTwentyFivePaperCups;
                Console.WriteLine("Your total would be" + " " + "$" + paperCupCost);
                Console.ReadLine();
            }
            else if (paperCupsBought == 50)
            {
                paperCupCost = priceOfFiftyPaperCups;
                Console.WriteLine("Your total would be" + " " + "$" + paperCupCost);
                Console.ReadLine();
            }
            else if (paperCupsBought == 100)
            {
                paperCupCost = priceOfOneHundredPaperCups;
                Console.WriteLine("Your total would be" + " " + "$" + paperCupCost);
                Console.ReadLine();
            }

            return paperCupCost;
        }

        public double LemonCost(int lemonsBought)
        {
            if(lemonsBought == 10)
            {
                lemonCost = priceOfTenLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if (lemonsBought == 30)
            {
                lemonCost = priceOfThirtyLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if(lemonsBought == 75)
            {
                lemonCost = priceOfSeventyFiveLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }

            return lemonCost;
        }

        public double SugarCost(int sugarBought)
        {
            if (sugarBought == 8)
            {
                sugarCost = priceOfEightCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
            else if (sugarBought == 20)
            {
                sugarCost = priceOfTwentyCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
            else if (sugarBought == 48)
            {
                sugarCost = priceOfFortyEightCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
           return sugarCost;
        }

        public double IceCubeCost(int iceCubesBought)
        {
            if (iceCubesBought == 100)
            {
                iceCubesCost = priceOfOneHundredIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }
            else if (iceCubesBought == 250)
            {
                iceCubesCost = priceOfTwoHundredFiftyIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }
            else if (iceCubesBought == 500)
            {
                iceCubesCost = priceOfFiveHundredIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }

            return iceCubesCost;
        }
        }
    }

