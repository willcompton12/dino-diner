﻿/*PterodactylWings.cs
 * Author: Will Compton
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds Pterodactyl wings and an entree
    /// </summary>
    public class PterodactylWings : Entree

    {

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Creates list of immutable ingredients
        /// </summary>
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
        /// <summary>
        /// Overrides the ToString method and allows us to return 
        /// the name of the entree item with proper formatting
        /// </summary>
        /// <returns>Name of entree item as type string</returns>
        public override string ToString()
        {
            return ("Pterodactyl Wings");
        }
        /// <summary>
        /// returns a description of the entree
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }

        }
      
      
    }
}
