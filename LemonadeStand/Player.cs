using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public double startingMoney;
        public double moneyMade;
        public int numberOfDays;
        public int numberOfLemons;
        public int cupsOfSugar;
        public int numberOfIceCubes;
        public double costOfLemonade;
        public double totalCost;
        public int cups;
        Day Day = new Day();
        public Player ()
        {
            this.startingMoney = 20.00;
            
        }

        public double CalculateTotal()
        {
            cups = Day.cupsSold;
            moneyMade += cups * costOfLemonade;
            return moneyMade;
        }
        
        public double SetPrice()
        {
            Console.WriteLine("What would you like your price for a cup of lemonade to be? Please enter your price in total cents. For example if your price was $3.50, you would enter 350.");
            string price = Console.ReadLine();
            int cost = Int32.Parse(price);
            costOfLemonade = cost * .01;
            return costOfLemonade;
        }

        public double ChangePriceDuringDay()
        {
            Console.WriteLine("Your current price is" + ' ' + "$" + costOfLemonade + ". Would you like to keep your current price, or would you like to change it? Please enter 'yes', or 'no'.");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "yes":
                    double newPrice = SetPrice();
                    costOfLemonade = newPrice;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Please enter only 'yes' or 'no'.");
                    ChangePriceDuringDay();
                    break;
            }
            return costOfLemonade;
        }

        public int SetLength()
        {
            Console.WriteLine("How many days would you like to play for? Please enter '7', '14', or '21'.");
            string gameLength = Console.ReadLine();

            switch (gameLength)
            {
                case "7":
                    numberOfDays = 7;
                    return numberOfDays;
                case "14":
                    numberOfDays = 14;
                    return numberOfDays;
                case "21":
                    numberOfDays = 21;
                    return numberOfDays;
                default:
                    Console.WriteLine("You can only play for '7', '14', or '21' days. Please enter one of those and try again.");
                    return SetLength();

            }
        }
    }
}
