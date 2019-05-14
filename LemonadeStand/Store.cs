using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    //For this class, Store, I made it so that when the player is at the store, they can buy ingredients for their lemonade stand. They can only buy
    //ingredients, and they can't sell anything or change the price, etc.
    public class Store: IUserInterface
    {
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
        public Store()
        {
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

        public void ExploreStore(Player Player, Inventory Inventory)
        {
            Console.WriteLine("Welcome to the store! Here you can buy all the ingredients you need for your lemonade stand such as paper cups, lemons, sugar, and ice.");
            Console.WriteLine("Please choose 'paper cups', 'lemons', 'sugar', or 'ice'. Or if you don't need any ingredients and or are done shopping, enter 'exit'. If you need help, enter 'help");
            string ingredient = Console.ReadLine();
            switch (ingredient)
            {
                case "paper cups":
                    BuyPaperCups(Player, Inventory);
                    break;
                case "lemons":
                    BuyLemons(Player, Inventory);
                    break;
                case "sugar":
                    BuySugar(Player, Inventory);
                    break;
                case "ice":
                    BuyIceCubes(Player, Inventory);
                    break;
                case "exit":
                    break;
                case "help":
                    Help();
                    ExploreStore(Player, Inventory);
                    break;
                default:
                    Console.WriteLine("Not a valid ingredient. You can only buy lemons, sugar, or ice. Please try again.");
                    ExploreStore(Player, Inventory);
                    return;
            }
            return;
        }
        
        public void Help()
        {
            Console.WriteLine("Inventory/Purchasing Help");
            Console.WriteLine("Your inventory is really important-After all, without product, you have " +
                "nothing to sell, and can't make money!" +
                "" +
                "So, how much do you need? This depends on a few things. First, how " +
                "many customers do you expect? If the weather is bad, and your price is " +
                "high, don't expect too many (maybe 15-25). But if the weather is hot and " +
                "clear, and your prices are reasonable, you can expect about 50-75 " +
                "customers." +
                "" +
                "Once you've decided how many customers to expect, figure out what " +
                "you need. You need one paper cup per customer, plus however many " +
                "ice cubes you decide to put in each cup." +
                "" +
                "Sugar and lemons are a bit trickier. First, figure out how many pitchers " +
                "you'll need to serve the customers you expect. If you're not putting " +
                "much ice in the cups, a pitcher can fill about 12 cups. If you're giving " +
                "lots of ice, expect a pitcher to fill 20-25 cups. Then, figure out how many " +
                "lemons and cups of sugar you need to make that many pitchers!" +
                "" +
                "If you don't buy enough of an ingredient, you can't make lemonade! It's " +
                "better to buy a little extra than to not have enough." +
                "" +
                "Another few tips: Your paper cups will never go bad, so always have " +
                "plenty of those. Your ice will melt at the end of the day, so, don't buy " +
                "much more than you can sell. Lemons and sugar will usually be OK the " +
                "next day, but can sometimes spoil!");
        }

        public double SeeTotalCostForIngredients(double price)
        {
            totalCostSpentOnIngredients += price;
            return totalCostSpentOnIngredients;
        }

        

        public void BuyPaperCups(Player Player, Inventory Inventory)
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
                    ExploreStore(Player, Inventory);
                    return;
                default:
                    Console.WriteLine("You can only purchase '25', '50', or '100' paper cups at a time. Please try again.");
                    BuyPaperCups(Player, Inventory);
                    return;
            }
            if(paperCupsBought == 25)
            {
                paperCupCost = priceOfTwentyFivePaperCups;
            }
            else if(paperCupsBought == 50)
            {
                paperCupCost = priceOfFiftyPaperCups;
            }
            else if(paperCupsBought == 100)
            {
                paperCupCost = priceOfOneHundredPaperCups;
            }
            if (Player.money >= paperCupCost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + paperCupsBought + ' ' + "paper cups.");
                SeeTotalCostForIngredients(paperCupCost);
                Player.money -= paperCupCost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddPaperCupsFromStore(paperCupsBought);
            }
            else if (Player.money < paperCupCost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of paper cups. Please choose a lower amount, or come back with more money. If you want to buy less paper cups, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyPaperCups(Player, Inventory);
                        break;
                    case "menu":
                        ExploreStore(Player, Inventory);
                        break;
                    default:
                        ExploreStore(Player, Inventory);
                        break;
                }
            }

            BuyPaperCups(Player, Inventory);
        }

        public void BuyLemons(Player Player, Inventory Inventory)
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
                    ExploreStore(Player, Inventory);
                    return;
                default:
                    Console.WriteLine("You can only purchase '10', '30', or '75' lemons at a time. Please try again.");
                    BuyLemons(Player, Inventory);
                    return;       
            }
            if(lemonsBought == 10)
            {
                lemonCost = priceOfTenLemons;
            }
            else if(lemonsBought == 30)
            {
                lemonCost = priceOfThirtyLemons;
            }
            else if(lemonsBought == 75)
            {
                lemonCost = priceOfSeventyFiveLemons;
            }
            if(Player.money >= lemonCost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + lemonsBought + ' ' + "lemons.");
                SeeTotalCostForIngredients(lemonCost);
                Player.money -= lemonCost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddLemonsFromStore(lemonsBought);
            }
            else if(Player.money < lemonCost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of lemons. Please choose a lower amount, or come back with more money. If you want to buy less lemons, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyLemons(Player, Inventory);
                        break;
                    case "menu":
                        ExploreStore(Player, Inventory);
                        break;
                    default:
                        ExploreStore(Player, Inventory);
                        break;
                }
            }
            
            BuyLemons(Player, Inventory);
            }
        public void BuySugar(Player Player, Inventory Inventory)
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
                    ExploreStore(Player, Inventory);
                    return;
                default:
                    Console.WriteLine("You can only purchase '8', '20', or '48' cups of sugar at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar(Player, Inventory);
                    return;
            }
            if(cupsOfSugarBought == 8)
            {
                sugarCost = priceOfEightCupsOfSugar;
            }
            else if(cupsOfSugarBought == 20)
            {
                sugarCost = priceOfTwentyCupsOfSugar;
            }
            else if(cupsOfSugarBought == 48)
            {
                sugarCost = priceOfFortyEightCupsOfSugar;
            }
            if (Player.money >= sugarCost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + cupsOfSugarBought + ' ' + "cups of sugar.");
                SeeTotalCostForIngredients(sugarCost);
                Player.money -= sugarCost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + "left.");
                Inventory.AddCupsOfSugarFromStore(cupsOfSugarBought);
            }
            else if(Player.money < sugarCost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of sugar. Please choose a lower amount, or come back with more money. If you want to buy less sugar, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuySugar(Player, Inventory);
                        break;
                    case "menu":
                        ExploreStore(Player, Inventory);
                        break;
                    default:
                        ExploreStore(Player, Inventory);
                        break;
                }
            }
            
            BuySugar(Player, Inventory);
        }

        public void BuyIceCubes(Player Player, Inventory Inventory)
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
                    ExploreStore(Player, Inventory);
                    return;
                default:
                    Console.WriteLine("You can only purchase '100', '250', or '500' ice cubes at a time. Or if you are done, enter 'menu' to go back to the Main Menu.");
                    BuySugar(Player, Inventory);
                    break;
            }
            if(numberOfIceCubesBought == 100)
            {
                iceCubesCost = priceOfOneHundredIceCubes;
            }
            else if(numberOfIceCubesBought == 250)
            {
                iceCubesCost = priceOfTwoHundredFiftyIceCubes;
            }
            else if(numberOfIceCubesBought == 500)
            {
                iceCubesCost = priceOfFiveHundredIceCubes;
            }
            if (Player.money >= iceCubesCost)
            {
                Console.WriteLine("You have successfully bought" + ' ' + numberOfIceCubesBought + ' ' + "ice cubes.");
                SeeTotalCostForIngredients(iceCubesCost);
                Player.money -= iceCubesCost;
                Console.WriteLine("You have" + ' ' + "$" + Player.money + ' ' + "left.");
                Inventory.AddIceCubesFromStore(numberOfIceCubesBought);
            }
            else if (Player.money < iceCubesCost)
            {
                Console.WriteLine("You don't have enought money to buy that amount of ice cubes. Please choose a lower amount, or come back with more money. If you want to buy ice cubes, enter 'buy again' or if you don't have enough money and can't buy anymore and want to go back to the Main Menu, enter 'menu'.");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "buy again":
                        BuyIceCubes(Player, Inventory);
                        break;
                    case "menu":
                        ExploreStore(Player, Inventory);
                        return;
                    default:
                        ExploreStore(Player, Inventory);
                        return;
                }
            }
            BuyIceCubes(Player, Inventory);
        }

        
    }
    }

