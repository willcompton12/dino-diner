/*PrehistoricPBJ.cs
 * Author: Will Compton
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds a PBJ sandwich to the menu as an entree
    /// </summary>
    public class PrehistoricPBJ : IMenuItem
    {
        private bool peanutButter = true;
        private bool jelly = true;
        public double Price { get; set; } = 6.52;

        public uint Calories { get; set; } = 483;
        /// <summary>
        /// Creates a list of ingredients to return to the user
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// condtructor to set price and calorie fields of base class
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }
        /// <summary>
        /// Removes Peanut butter from list of ingredients
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
        }
        /// <summary>
        /// removes jelly from list of ingredients
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
        }
    }
}
