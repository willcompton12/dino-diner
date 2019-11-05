/*PrehistoricPBJ.cs
 * Author: Will Compton
 */

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds a PBJ sandwich to the menu as an entree
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;
        
        
        /// <summary>
        /// Creates a list of ingredients to return to the user
        /// </summary>
        public override List<string> Ingredients
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
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// removes jelly from list of ingredients
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Overrides the ToString method and allows us to return 
        /// the name of the entree item with proper formatting
        /// </summary>
        /// <returns>Name of entree item as type string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// gets special instructions for making the sandwich
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
