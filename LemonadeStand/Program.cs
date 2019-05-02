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
            Console.WriteLine("Welcome to Lemondade Stand! The goal of the game is to make as much money as you can in one week selling lemonade. You start off with $20.00 and you will need ingredients for your lemonade. These ingredients can be found in the store where you can purchase them. After every day you will get a report on how much of a profit you made for that day. If you go bankrupt, you lose the game. Good luck!");
            Game NewGame = new Game();
            int counter = 1;
            int numberOfRounds = NewGame.numberOfDays;
            if (numberOfRounds == 7)
            {
                while(counter < (numberOfRounds + 1))
                {
                    NewGame.StartGame();
                    counter++;
                }
            }
            else if(numberOfRounds == 14)
            {
                while(counter < (numberOfRounds + 1))
                {
                    NewGame.StartGame();
                    counter++;
                }
            }
            else if(numberOfRounds == 21)
            {
                while(counter < (numberOfRounds + 1))
                {
                    NewGame.StartGame();
                    counter++;
                }
            }
        }
    }
}
