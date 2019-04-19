using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double startMoney = 20.00;
        public double remainingMoney;
        public double lemonCost;
        public double sugarCost;
        public double iceCubesCost;
        public int lemonsBought;
        public int cupsOfSugarBought;
        public int numberOfIceBought;
        public double priceOfTenLemons;
        public double priceOfTwentyFiveLemons;
        public double priceOfFiftyLemons;
        public double priceOfFiveCupsOfSugar;
        public double priceOfFifteenCupsOfSugar;
        public double priceOfThirtyCupsOfSugar;
        public double priceOfFiftyIceCubes;
        public double priceOfOneHundredSeventyFiveIceCubes;
        public double priceOfThreeHundredFiftyIceCubes;
        Inventory Inventory = new Inventory();
        
        public Store()
        {
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
            Console.WriteLine("Please choose lemons, sugar, or ice.");
        }

        public int BuyLemons()
        {
            
            
            Console.WriteLine("You can either buy '10' lemons for 0.50, '25' lemons for 1.30, or '50' lemons for 2.10.");
            string amountWanted = Console.ReadLine();
            
            
            

            switch (amountWanted)
            {
                case "10":
                    lemonsBought = 10;
                    
                    return lemonsBought;
                    

                case "25":
                    lemonsBought = 25;
                    return lemonsBought;
                    
                case "50":
                    lemonsBought = 50;
                    return lemonsBought;
                    
                default:
                    Console.WriteLine("You can only purchase '10', '25', or '50' lemons at a time. Please try again.");
                    return BuyLemons();
                    
            }
            

            
            }

        public double LemonCost()
        {
            if(lemonsBought == 10)
            {
                lemonCost = priceOfTenLemons;
                Console.WriteLine("Your total is" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if (lemonsBought == 25)
            {
                lemonCost = priceOfTwentyFiveLemons;
                Console.WriteLine("Your total is" + " " + "$" + lemonCost);
                Console.ReadLine();
            }
            else if(lemonsBought == 50)
            {
                lemonCost = priceOfFiftyLemons;
                Console.WriteLine("Your total is" + " " + "$" + lemonCost);
                Console.ReadLine();
            }

            return lemonCost;

            

        
            


            
        }

        public void GettingMoreLemons()
        {
            Console.WriteLine("Would you like to purchase more lemons?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                


            }
        }



        

        

        
        }
    }

