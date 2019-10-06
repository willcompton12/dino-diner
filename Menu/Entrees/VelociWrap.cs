/* VelociWrap.cs
 * Author: Will Compton 
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds veloci wrap to menu as an entree
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// private boolean values to hold if the customer wants to respective ingredients
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// Creates a list of ingredients to return to user
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor to set price and calorie fields of base class
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
        /// <summary>
        /// removes dressing from ingredients
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// removes cheese from ingredients
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
        /// <summary>
        /// Overrides the ToString method and allows us to return 
        /// the name of the entree item with proper formatting
        /// </summary>
        /// <returns>Name of entree item as type string</returns>
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
}
