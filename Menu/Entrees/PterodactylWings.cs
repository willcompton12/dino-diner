/*PterodactylWings.cs
 * Author: Will Compton
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds Pterodactyl wings and an entree
    /// </summary>
    public class PterodactylWings : Entree

    {

       

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;
            }
        }
        /// <summary>
        /// constructor to add ingredients, price and calories to variables created in
        /// the base class
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
           
        }

        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }

    }
}
