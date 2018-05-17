using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public int NumberOfDays;
        public int NumberOfLemons;
        public int CupsOfSugar;
        public int NumberOfIceCubes;
        public Player (int NumberOfDays, double Price, int NumberOfLemons, int CupsOfSugar, int NumberOfIceCubes)
        {
            this.NumberOfDays = NumberOfDays;
            this.NumberOfLemons = NumberOfLemons;
            this.CupsOfSugar = CupsOfSugar;
            this.NumberOfIceCubes = NumberOfIceCubes;


        }

        public void GetRecipe()
        {
            Console.Write("How many lemons do you want to use in your recipe?");
            Console.ReadLine();

        }
        
    }
}
