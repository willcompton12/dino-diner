/*DinoNuggets.cs
 * Author: Will Compton
 */
using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Adds Dino nuggets to the menu as an entree
    /// </summary>
    public class DinoNuggets : Entree
    {

        /// <summary>
        /// keeps track of the total number of nuggets 
        /// </summary>
        private int total = 6;

        
        /// <summary>
        /// Creates a list of ingredients to return to the user
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();

                for (int i = 0; i < total; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }

                return ingredients;

            }
        }
        /// <summary>
        /// Constructor to set price and calorie fields of base class
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
        }
        /// <summary>
        /// Method called to add a nugget to the order
        /// </summary>
        public void AddNugget()
        {
            this.total += 1;
            Calories += 59;
            Price += .25;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
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
            return ("Dino-Nuggets");
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// gets special instructions if extra nuggets are added
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (total>6) special.Add( total-6 + " Extra Nuggets");
                return special.ToArray();
            }
        }

    }
}
