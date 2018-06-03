using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public double StartMoney = 20.00;
        public double RemainingMoney;
        public int LemonsBought;
        public int CupsOfSugarBought;
        public int NumberOfIceBought;
        public double PriceOfTenLemons = 0.50;
        public double PriceOfTwentyFiveLemons = 1.75;
        public double PriceOfFiftyLemons = 3.20;
        
        
        public Store()
        {

        }

        public void ExploreStore()
        {
            Console.WriteLine("Welcome to the store! Here you can buy all the ingredients you need for your lemonade such as lemons, sugar, and ice.");
            Console.WriteLine("Please choose lemons, sugar, or ice.");
        }

        public int BuyLemons()
        {
            
            
            Console.WriteLine("You can either buy '10' lemons for 0.50, '25' lemons for 1.75, or '50' lemons for 3.20");
            string AmountWanted = Console.ReadLine();
            
            
            

            switch (AmountWanted)
            {
                case "10":
                    return LemonsBought = 10;
                    

                case "25":
                    return LemonsBought = 25;
                    
                case "50":
                    return LemonsBought = 50;
                    
                default:
                    Console.WriteLine("You can only purchase '10', '25', or '50' lemons at a time. Please try again.");
                    return BuyLemons();
                    
            }
            

            
            }

        public double LemonCost()
        {
            double totalCost;
            BuyLemons();
            if(LemonsBought == 10)
            {
                totalCost = PriceOfTenLemons;
                Console.WriteLine("Your total is" + " " + "$" + totalCost);
                Console.ReadLine();
                RemainingMoney = StartMoney - totalCost;
                Console.WriteLine("You now have" + " " + "$" + RemainingMoney + " " + "left.");
                Console.ReadLine();
                return RemainingMoney;
            }
            else if (LemonsBought == 25)
            {
                totalCost = PriceOfTwentyFiveLemons;
                Console.WriteLine("Your total is" + " " + "$" + totalCost);
                Console.ReadLine();
                RemainingMoney = StartMoney - totalCost;
                Console.WriteLine("You now have" + " " + "$" + RemainingMoney + " " + "left.");
                Console.ReadLine();
                return totalCost;
            }
            else if(LemonsBought == 50)
            {
                totalCost = PriceOfFiftyLemons;
                Console.WriteLine("Your total is" + " " + "$" + totalCost);
                Console.ReadLine();
                RemainingMoney = StartMoney - totalCost;
                Console.WriteLine("You now have" + " " + "$" + RemainingMoney + " " + "left.");
                Console.ReadLine();
                return totalCost;
            }

            return LemonCost();

            

        
            


            
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

