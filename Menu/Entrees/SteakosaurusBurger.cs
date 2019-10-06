﻿/*SteakosaurusBurger.cs
 * Author: Will Compton
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds Steakosaurus Burger to the menu as an entree
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Private boolean values to hold if the customer wants the respective ingredients
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Creates a list of ingredients to return to the user
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// constructor to set price and calorie fields of base class
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
        }

        /// <summary>
        /// removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// removes pickle from ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// removes ketchup from ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// removes mustard from ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        public override string ToString()
        {
            return ("Steakosaurus Burger");
        }
    }
}
