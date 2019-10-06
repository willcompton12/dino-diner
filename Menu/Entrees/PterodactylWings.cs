/*PterodactylWings.cs
 * Author: Will Compton
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds Pterodactyl wings and an entree
    /// </summary>
    public class PterodactylWings : IMenuItem

    {

        public double Price { get; set; } = 7.21;
        public uint Calories { get; set; } = 318;

        public List<string> Ingredients
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
            
           
        }

        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }

    }
}
