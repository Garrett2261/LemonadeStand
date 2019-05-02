using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int cupsOfLemonade;
        public double spendingLimit;
        public double costLimit;
        public Random Random = new Random();
        public Customer()
        {
            this.spendingLimit = Random.Next(0, 150)/100;
            //this.costLimit = Random.NextDouble();
        }
        //Think about doing an average cost for a customer. Let's say a customer on average would only want to spend $1.50 on lemonade. 
        //If the price was 0.50 then they would purchase 3 cups of lemonade. 
        //If the weather got hotter then that customer would be willing to pay more
        public int BuyLemonade(double price)
        {
            
            if(price > spendingLimit)
            {
                cupsOfLemonade = 0;
                Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
            }
            else if(price <= spendingLimit)
            {
                cupsOfLemonade = Convert.ToInt32(Math.Floor(spendingLimit / price));
                Console.WriteLine("The customer bought" + ' ' + cupsOfLemonade + ' ' + "cups of lemonade.");
            }
            return cupsOfLemonade;
        }
    }
}
