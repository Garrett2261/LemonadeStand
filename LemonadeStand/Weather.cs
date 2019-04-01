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

        public string WeatherCondition;
        public int Degrees;
        
        
        
        
        


        public Weather()
        {
            

        }

        public string GetWeatherCondition()
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

            



            for(int i = 0; i < 1; ++i)
            {
                
                if(WeatherType.Next(1, 4) == 1)
                {
                    
                    
                    WeatherCondition = "Sunny";
                    return WeatherCondition;
                    
                }

                else if(WeatherType.Next(1, 4) == 2)
                {
                    
                    
                    WeatherCondition = "Rainy";
                    return WeatherCondition;
                    
                }

                else if(WeatherType.Next(1, 4) == 3)
                {
                    
                    
                    WeatherCondition = "Partly Cloudy";
                    return WeatherCondition;
                    
                }

                else if(WeatherType.Next(1, 4) == 4)
                {
                    
                    
                    WeatherCondition = "Overcast";
                    return WeatherCondition;
                    
                }

                
            }

            
            WeatherCondition = Element;
            return Element;


            





            


                
            }

        public int GetTemperature()
        {
            Degrees = Temperature.Next(50, 100);
            
            return Degrees;
            
        }

            

            

           
            




            


            
                
                
               
            
            
        }

        



        

        

        

    }


