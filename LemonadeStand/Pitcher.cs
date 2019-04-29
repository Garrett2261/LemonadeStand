using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        public int cupsForPitcher;
        public int cupsInPitcher;
        public Random Random = new Random();
        public Pitcher()
        {
            this.cupsForPitcher = cupsInPitcher;
        }

        public int GetCupsInPitcher(Recipe Recipe)
        {
            if(Recipe.iceCubesPerCup > 10)
            {
                cupsInPitcher = Random.Next(20, 25);
            }
            else if(Recipe.iceCubesPerCup < 10)
            {
                cupsInPitcher = 12;
            }
            return cupsInPitcher;
        }
    }
}
