﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        
        public Recipe()
        {

        }

        public void MakeRecipe()
        {
            Console.WriteLine("The basic recipe amounts for 4 lemons, 4 cups of sugar, and 4 ice cubes. You can change this and set it to whatever you'd like.");
            Console.WriteLine("How many lemons would you like to use in your recipe?");
            Console.WriteLine("How many cups of sugar would you like to use in your recipe?");
            Console.WriteLine("How many ice cubes would you like to use in your recipe?");

        }
    }
}
