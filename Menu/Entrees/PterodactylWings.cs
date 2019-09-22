/*PterodactylWings.cs
 * Author: Will Compton
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds Pterodactyl wings and an entree
    /// </summary>
    public class PterodactylWings : Entree

    {
        /// <summary>
        /// constructor to add ingredients, price and calories to variables created in
        /// the base class
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

      
    }
}
