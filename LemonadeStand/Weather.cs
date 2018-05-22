using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    class Weather
    {
        public Random Temperature = new Random();
        public Random WeatherType = new Random();
        
        


        public Weather()
        {
            

        }

        public void WeatherCondition()
        {
            List<string> Condition = new List<string>();
            Condition.Add("Sunny");
            Condition.Add("Rainy");
            Condition.Add("Partly Cloudy");
            Condition.Add("Overcast");

            
            
            

            for (int i = 0; i < 7; ++i)
            {
                
                if ((WeatherType.Next(Condition.Count)) == 0)
                {
                    Console.WriteLine("Sunny");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(Condition.Count)) == 1)
                {
                    Console.WriteLine("Rainy");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(Condition.Count)) == 2)
                {
                    Console.WriteLine("Partly Cloudy");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(Condition.Count)) == 3)
                {
                    Console.WriteLine("Overcast");
                    Console.ReadLine();
                }

                else
                {
                    
                }



                
            }

            

           
            




            


            
                
                
               
            
            
        }

        public void GetTemperature()
        {
            for (int i = 0; i < 7; ++i)
            {
                Console.Write(Temperature.Next(50, 100));
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

