﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

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
        public Size Size
        {
            get { return size; }
            set { size = value;
                if(size == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                }
                    if( size == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                }
                    if(size == Size.Large)
                {
                    Price = 2.50;
                    Calories = 208;
                }
            }
        }
        public override string ToString()
        {
            return this.size + " " + this.Flavor.ToString() + " Sodasaurus";
        }

    }
}