﻿using System;
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

        public void GetWeeklyForecast()
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

            List<string> DayOfTheWeek = new List<string>();





            for (int i = 0; i < 7; ++i)
            {
                WeatherType.Next(1, 4);
                
                if ((WeatherType.Next(1, 4)) == 1)
                {
                    Console.WriteLine("Sunny");
                    Console.Write(Temperature.Next(50, 100));
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 2)
                {
                    Console.WriteLine("Rainy");
                    Console.Write(Temperature.Next(50, 100));
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 3)
                {
                    Console.WriteLine("Partly Cloudy");
                    Console.Write(Temperature.Next(50, 100));
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 4)
                {
                    Console.WriteLine("Overcast");
                    Console.Write(Temperature.Next(50, 100));
                    Console.ReadLine();
                    
                }

                else
                {
                    Console.WriteLine(Element);
                    Console.Write(Temperature.Next(50, 100));
                    Console.ReadLine();
                }



                
            }

            

            

           
            




            


            
                
                
               
            
            
        }

        



        

        public void GetDailyForecast()
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

            for (int i = 0; i < 1; ++i)
            {
                if ((WeatherType.Next(1, 4)) == 1)
                {
                    Console.WriteLine("Sunny");
                    Console.Write(Temperature.Next(50, 100) + " " + "degrees");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 2)
                {
                    Console.WriteLine("Rainy");
                    Console.Write(Temperature.Next(50, 100) + " " + "degrees");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 3)
                {
                    Console.WriteLine("Partly Cloudy");
                    Console.Write(Temperature.Next(50, 100) + " " + "degrees");
                    Console.ReadLine();
                }

                else if ((WeatherType.Next(1, 4)) == 4)
                {
                    Console.WriteLine("Overcast");
                    Console.Write(Temperature.Next(50, 100) + " " + "degrees");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(Element);
                    Console.Write(Temperature.Next(50, 100) + " " + "degrees");
                    Console.ReadLine();
                }
            }
        }

        public void DetermineWhichForecastYouWant()
        {
            Console.WriteLine("Would you like to check the weather for the week? Or the weather for the current day?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "week":
                    GetWeeklyForecast();
                    break;
                case "day":
                    GetDailyForecast();
                    break;
                default:
                    Console.WriteLine("You can only check the weather forecast for the 'week' or for they 'day'. Please try again.");
                    Console.ReadLine();
                    DetermineWhichForecastYouWant();
                    break;
                    
                
            }
            

            
        }


    }
}

