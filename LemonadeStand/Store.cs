using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public double StartMoney = 20.00;
        public double RemainingMoney;
        public int LemonsBought;
        public int CupsOfSugarBought;
        public int NumberOfIceBought;
        public Store()
        {

        }

        public void ExploreStore()
        {
            Console.WriteLine("Welcome to the store! Here you can buy all the ingredients you need for your lemonade such as lemons, sugar, and ice.");
            Console.WriteLine("Please choose lemons, sugar, or ice.");
        }

        public void BuyLemons()
        {
            
            Console.WriteLine("You can either buy '10' lemons for 0.50, '25' lemons for 1.75, or '50' lemons for 3.20");
            string AmountWanted = Console.ReadLine();
            
            
            

            switch (AmountWanted)
            {
                case "10":
                    LemonsBought = 10;
                    break;

                case "25":
                    LemonsBought = 25;
                    break;
                case "50":
                    LemonsBought = 50;
                    break;
                default:
                    Console.WriteLine("You can only purchase '10', '25', or '50' lemons at a time. Please try again.");
                    break;
                    
            }
            

            
            }

        public void LemonCost()
        {
            
        }
        }
    }

