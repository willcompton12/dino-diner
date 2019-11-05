/* Triceritots.cs
 * Author: Will Compton 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to add Triceritots to the menu
    /// </summary>
    public class Triceritots : Side
    {
       
        /// <summary>
        /// Variable to hold the size ordered
        /// </summary>
        private Size size;
        /// <summary>
        /// method to set the price and calories for the tots to the size ordered
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
                

            }
            get { return size; }

        }
        /// <summary>
        /// method to add the ingredients to the ingredients list 
        /// as well as default price and calories
        /// </summary>
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
        }
        /// <summary>
        /// Creates list of immutable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;
            }
        }
        /// <summary>
        /// Overrides the ToString method and allows us to return 
        /// the name of the side item with proper formatting
        /// </summary>
        /// <returns>Name of side item as type string</returns>
        public override string ToString()
        {
            return (this.size + " Triceritots");
        }
        /// <summary>
        /// Provides a description of the Side
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// gets special instructions 
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

    }
}
