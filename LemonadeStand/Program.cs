using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player Player1 = new Player(7, .25, 4, 4, 4);
            //Player1.GetRecipe();

            Weather Day = new Weather();
            Day.GetWeeklyForecast();

            Game NewGame = new Game();
            NewGame.DetermineSales();

            Player NewPlayer = new Player(7, .25, 4, 4, 4);
            NewPlayer.GetRecipe();








        }
    }
}
