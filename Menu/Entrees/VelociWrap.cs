/* VelociWrap.cs
 * Author: Will Compton 
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds veloci wrap to menu as an entree
    /// </summary>
    public class VelociWrap : IMenuItem
    {
        /// <summary>
        /// private boolean values to hold if the customer wants to respective ingredients
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        public double Price { get; set; } = 6.86;
        public uint Calories { get; set; } = 356;

        /// <summary>
        /// Creates a list of ingredients to return to user
        /// </summary>
        public List<string> Ingredients
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
        public override string ToString()
        {
            return ("Veloci-Wrap");
        }
    }
}
