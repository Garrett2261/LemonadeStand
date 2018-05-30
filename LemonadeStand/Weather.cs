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
        
        
        
        
        


        public Weather()
        {
            

        }

        public void GetWeatherCondition()
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
                    
                    Console.Write("Sunny");
                    Console.ReadLine();
                    
                }

                else if(WeatherType.Next(1, 4) == 2)
                {
                    
                    Console.Write("Rainy");
                    Console.ReadLine();
                    
                }

                else if(WeatherType.Next(1, 4) == 3)
                {
                    
                    Console.Write("Partly Cloudy");
                    Console.ReadLine();
                    
                }

                else if(WeatherType.Next(1, 4) == 4)
                {
                    
                    Console.Write("Overcast");
                    Console.ReadLine();
                    
                }

                else
                {
                    
                    Console.Write(Element);
                    Console.ReadLine();
                    
                }
            }


            





            


                
            }

        public void GetTemperature()
        {
             Console.Write(Temperature.Next(50, 100));
            Console.ReadLine();
            
        }

            

            

           
            




            


            
                
                
               
            
            
        }

        



        

        

        

    }


