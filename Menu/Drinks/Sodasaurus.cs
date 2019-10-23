using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a class to hold a generic soda for the menu
    /// </summary>
    public class Sodasaurus : Drink
    {

        
        /// <summary>
        /// constructor to set default values for the soda
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Price = 1.5;
            Calories = 112;
            
        }
        /// <summary>
        /// Creates list of immutable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();

                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// private variable to hold what flavor the soda is
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// constructor to get and set the flavor for sodasaurus
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }


        private Size size;
        /// <summary>
        /// sets the price to the size and returns the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set { size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
                }
                    if( size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
                }
                    if(size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
                }

            }
        }
        /// <summary>
        /// Overrides ToString to return the name of the drink as we want it
        /// </summary>
        /// <returns>Name of Drink</returns>
        public override string ToString()
        {
            return this.size + " " + this.Flavor.ToString() + " Sodasaurus";
        }
        /// <summary>
        /// Provides a description of the Drink
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// Returns special instructions for the drink
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }


    }
}
