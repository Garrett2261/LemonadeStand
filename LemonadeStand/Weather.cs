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
            

            List<string> Condition = new List<string>
            {
                "Sunny",
                "Rainy",
                "Partly Cloudy",
                "Overcast"
            };

            int Index = WeatherType.Next(Condition.Count);
            string Element = Condition.ElementAt(Index);





            for (int i = 0; i < 7; ++i)
            {
                WeatherType.Next(1, 4);
                
                if ((WeatherType.Next(1, 4)) == 1)
                {
                    Console.WriteLine("Sunny");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 2)
                {
                    Console.WriteLine("Rainy");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 3)
                {
                    Console.WriteLine("Partly Cloudy");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 4)
                {
                    Console.WriteLine("Overcast");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(Element);
                    Console.ReadLine();
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

