using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    class Weather
    {
        Random Temperature = new Random();
        



        public Weather()
        {
            

        }

        public void WeatherCondition()
        {
            List<string> Condition = new List<string>();
            Condition.Add("Sunny");
            Condition.Add("Rainy");
            Condition.Add("Cloudy");
            Condition.Add("Overcast");

            Random WeatherType = new Random();
            int element = WeatherType.Next(Condition.Count);
            string WeatherForDay = Condition[element];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(WeatherForDay);
                Console.ReadLine();
            }

            

           
            




            


            
                
                
               
            
            
        }

        public void GetTemperature()
        {
            Random Degrees = new Random();
            

            for (int i = 0; i < 7; ++i)
            {
                Console.WriteLine(Degrees.Next(50, 100));
                Console.ReadLine();
            }
        }



        public void GetWeeklyForecast()
        {
            
            
            
            

           

            
            

                
            



        }

        public void Days()
        {

        }


    }
}

