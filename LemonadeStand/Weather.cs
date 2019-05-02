using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class Weather
    {
        public Random Temperature = new Random();
        public Random WeatherType = new Random();
        public string weatherCondition;
        public int degrees;
        public Weather()
        {
            
        }

        public string GetWeatherCondition()
        {
            List<string> Condition = new List<string>
            {
                "Clear Skies",
                "Rainy",
                "Partly Cloudy",
                "Overcast"
            };
            int Index = WeatherType.Next(Condition.Count);
            string Element = Condition.ElementAt(Index);
            for(int i = 0; i < 1; ++i)
            {
                if(WeatherType.Next(1, 4) == 1)
                {
                    weatherCondition = "Clear Skies";
                    return weatherCondition;    
                }
                else if(WeatherType.Next(1, 4) == 2)
                {
                    weatherCondition = "Rainy";
                    return weatherCondition;    
                }
                else if(WeatherType.Next(1, 4) == 3)
                {
                    weatherCondition = "Partly Cloudy";
                    return weatherCondition;    
                }
                else if(WeatherType.Next(1, 4) == 4)
                {
                    weatherCondition = "Overcast";
                    return weatherCondition;    
                }    
            }
            weatherCondition = Element;
            return Element;    
        }

        public int GetTemperature()
        {
            degrees = Temperature.Next(50, 100);
            return degrees;    
        }

            

            

           
            




            


            
                
                
               
            
            
        }

        



        

        

        

    }


