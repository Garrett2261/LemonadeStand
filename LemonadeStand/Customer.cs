using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        
        public double customerTotal;
        public int maxMoneyToPay;
        public Random Random = new Random();
        public Customer(int maxMoneyToPay)
        {
            Random Rand = new Random();
            maxMoneyToPay = Rand.Next(0,5);
        }

        public double BuyLemonade(double price)
        {
            maxMoneyToPay = Random.Next(0, 5);
            if(price > maxMoneyToPay)
            {
                Console.WriteLine("The customer didn't buy any lemonade.");
                customerTotal = 0;
                return customerTotal;
            }
            else if(price <= maxMoneyToPay)
            {
                Console.WriteLine("The customer bought some lemonade");
                customerTotal = Math.Floor(maxMoneyToPay / price) * price;
                return customerTotal;
            }
            else
            {
                return 0;
            }
        }


    }
}
