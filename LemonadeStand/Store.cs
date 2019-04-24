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
        public double lemonCost;
        public double sugarCost;
        public double iceCubesCost;
        public int lemonsBought;
        public int cupsOfSugarBought;
        public int numberOfIceCubesBought;
        public double priceOfTenLemons;
        public double priceOfTwentyFiveLemons;
        public double priceOfFiftyLemons;
        public double priceOfFiveCupsOfSugar;
        public double priceOfFifteenCupsOfSugar;
        public double priceOfThirtyCupsOfSugar;
        public double priceOfFiftyIceCubes;
        public double priceOfOneHundredSeventyFiveIceCubes;
        public double priceOfThreeHundredFiftyIceCubes;
        public double totalCostSpentOnIngredients;
        Inventory Inventory = new Inventory();
        Player Player = new Player();
        public Store()
        {
            this.startMoney = 20.00;
            this.priceOfTenLemons = 0.50;
            this.priceOfTwentyFiveLemons = 1.30;
            this.priceOfFiftyLemons = 2.10;
            this.priceOfFiveCupsOfSugar = 0.90;
            this.priceOfFifteenCupsOfSugar = 2.00;
            this.priceOfThirtyCupsOfSugar = 4.75;
            this.priceOfFiftyIceCubes = 0.60;
            this.priceOfOneHundredSeventyFiveIceCubes = 2.05;
            this.priceOfThreeHundredFiftyIceCubes = 3.95;
        }

        public void ExploreStore()
        {
            Console.WriteLine("Welcome to the store! Here you can buy all the ingredients you need for your lemonade such as lemons, sugar, and ice.");
            Console.WriteLine("Please choose 'lemons', 'sugar', or 'ice'. Or if you don't need any ingredients and or are done shopping, enter 'exit'.");
            string ingredient = Console.ReadLine();
            switch (ingredient)
            {
                case "lemons":
                    BuyLemons();
                    break;
                case "sugar":
                    BuySugar();
                    break;
                case "ice":
                    BuyIceCubes();
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
            if(totalCostSpentOnIngredients > 0)
            {
                totalCostSpentOnIngredients += price;
            }
            else
            {
                totalCostSpentOnIngredients = price;
            }
            return totalCostSpentOnIngredients;
        }

        public double SeeNewMoneyLeft()
        {

        }

        //public double SeeTotalSugarCost(double price)

        public void BuyLemons()
        {
            //Inventory Inventory = new Inventory();
            Console.WriteLine("You can either buy '10' lemons for 0.50, '25' lemons for 1.30, or '50' lemons for 2.10. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "10":
                    lemonsBought = 10;
                    break;
                case "25":
                    lemonsBought = 25;
                    break;
                case "50":
                    lemonsBought = 50;
                    break;
                case "menu":
                    ExploreStore();
                    break;
                default:
                    Console.WriteLine("You can only purchase '10', '25', or '50' lemons at a time. Please try again.");
                    BuyLemons();
                    break;       
            }
            if(remainingMoney >= LemonCost(lemonsBought))
            {
                Console.WriteLine("You have successfully bought" + ' ' + lemonsBought + ' ' + "lemons.");
                SeeTotalCostForIngredients(LemonCost(lemonsBought));
                GetRemainingMoney(LemonCost(lemonsBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddLemonsFromStore(lemonsBought);
            }
            else if(remainingMoney < LemonCost(lemonsBought))
            {
                Console.WriteLine("You don't have enought money to buy that amount of lemons. Please choose a lower amount, or come back with more money. If you want to buy less lemons, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyLemons();
                        break;
                    case "menu":
                        ExploreStore();
                        break;
                    default:
                        ExploreStore();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have successfully bought" + ' ' + lemonsBought + ' ' + "lemons.");
                SeeTotalCostForIngredients(LemonCost(lemonsBought));
                GetRemainingMoney(LemonCost(lemonsBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddLemonsFromStore(lemonsBought);
            }
            BuyLemons();
            }
        public void BuySugar()
        {
            Console.WriteLine("You can either buy '5' cups of sugar for 0.90, '15' cups of sugar for 2.00, or '30' cups of sugar for 4.75. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "5":
                    cupsOfSugarBought = 5;
                    break;
                case "15":
                    cupsOfSugarBought = 15;
                    break;
                case "30":
                    cupsOfSugarBought = 30;
                    break;
                case "menu":
                    ExploreStore();
                    break;
                default:
                    Console.WriteLine("You can only purchase '5', '15', or '30' cups of sugar at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar();
                    break;
            }
            if(remainingMoney >= SugarCost(cupsOfSugarBought))
            {
                Console.WriteLine("You have successfully bought" + ' ' + cupsOfSugarBought + ' ' + "cups of sugar.");
                SeeTotalCostForIngredients(SugarCost(cupsOfSugarBought));
                GetRemainingMoney(SugarCost(cupsOfSugarBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddCupsOfSugarFromStore(cupsOfSugarBought);
            }
            else if(remainingMoney < SugarCost(cupsOfSugarBought))
            {
                Console.WriteLine("You don't have enought money to buy that amount of sugar. Please choose a lower amount, or come back with more money. If you want to buy less sugar, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuySugar();
                        break;
                    case "menu":
                        ExploreStore();
                        break;
                    default:
                        ExploreStore();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have successfully bought" + ' ' + cupsOfSugarBought + ' ' + "cups of sugar.");
                SeeTotalCostForIngredients(SugarCost(cupsOfSugarBought));
                GetRemainingMoney(SugarCost(cupsOfSugarBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddCupsOfSugarFromStore(cupsOfSugarBought);
            }
            BuySugar();
        }

        public void BuyIceCubes()
        {
            Console.WriteLine("You can either buy '50' ice cubes for 0.60, '175' ice cubes for 2.05, or '350' ice cubes for 3.95. Or if you don't need any and or already have enough, you can enter 'menu' to go back to the Main Menu.");
            string amountWanted = Console.ReadLine();
            switch (amountWanted)
            {
                case "50":
                    numberOfIceCubesBought = 50;
                    break;
                case "175":
                    numberOfIceCubesBought = 175;
                    break;
                case "350":
                    numberOfIceCubesBought = 350;
                    break;
                case "menu":
                    ExploreStore();
                    break;
                default:
                    Console.WriteLine("You can only purchase '50', '175', or '350' ice cubes at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar();
                    break;
            }
            if (remainingMoney >= IceCubeCost(numberOfIceCubesBought))
            {
                Console.WriteLine("You have successfully bought" + ' ' + numberOfIceCubesBought + ' ' + "ice cubes.");
                SeeTotalCostForIngredients(IceCubeCost(numberOfIceCubesBought));
                GetRemainingMoney(IceCubeCost(numberOfIceCubesBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddIceCubesFromStore(numberOfIceCubesBought);
            }
            else if (remainingMoney < IceCubeCost(numberOfIceCubesBought))
            {
                Console.WriteLine("You don't have enought money to buy that amount of ice cubes. Please choose a lower amount, or come back with more money. If you want to buy ice cubes, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyIceCubes();
                        break;
                    case "menu":
                        ExploreStore();
                        break;
                    default:
                        ExploreStore();
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have successfully bought" + ' ' + numberOfIceCubesBought + ' ' + "ice cubes.");
                SeeTotalCostForIngredients(IceCubeCost(numberOfIceCubesBought));
                GetRemainingMoney(IceCubeCost(numberOfIceCubesBought));
                Console.WriteLine("You have" + ' ' + "$" + remainingMoney + "left.");
                Inventory.AddIceCubesFromStore(numberOfIceCubesBought);
            }
            BuyIceCubes();
        }

        

        public double LemonCost(int lemonsBought)
        {
            if(lemonsBought == 10)
            {
                lemonCost = priceOfTenLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if (lemonsBought == 25)
            {
                lemonCost = priceOfTwentyFiveLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if(lemonsBought == 50)
            {
                lemonCost = priceOfFiftyLemons;
                Console.WriteLine("Your total would be" + " " + "$" + lemonCost);
                Console.ReadLine();
            }

            return lemonCost;
        }

        public double SugarCost(int sugarBought)
        {
            if (sugarBought == 5)
            {
                sugarCost = priceOfFiveCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
            else if (sugarBought == 15)
            {
                sugarCost = priceOfFifteenCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
            else if (sugarCost == 30)
            {
                sugarCost = priceOfThirtyCupsOfSugar;
                Console.WriteLine("Your total would be" + " " + "$" + sugarCost);
                Console.ReadLine();
            }
           return sugarCost;
        }

        public double IceCubeCost(int iceCubesBought)
        {
            if (iceCubesBought == 50)
            {
                iceCubesCost = priceOfFiftyIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }
            else if (iceCubesBought == 175)
            {
                iceCubesCost = priceOfOneHundredSeventyFiveIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }
            else if (iceCubesBought == 350)
            {
                iceCubesCost = priceOfThreeHundredFiftyIceCubes;
                Console.WriteLine("Your total would be" + " " + "$" + iceCubesCost);
                Console.ReadLine();
            }

            return iceCubesCost;
        }
        }
    }

