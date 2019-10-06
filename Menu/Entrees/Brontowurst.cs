/* Brontowurst.cs
 * Author: Will Compton 
 */

using System.Collections.Generic;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Defines a class to add a brontowurst as an entree to the menu
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Creates a list of ingredients to return to user
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets the price and Calorie fields in the base class
        /// </summary>
        public Brontowurst()
        {

            Price = 5.36;
            Calories = 498;
        }
        /// <summary>
        /// Removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }
        /// <summary>
        /// Removes peppers from ingredients
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// Removes onions from ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }

        public override string ToString()
        {
            return ("Brontowurst");
        }
    }
}
