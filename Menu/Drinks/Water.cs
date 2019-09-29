using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Creates a Tyrannotea class to add tea to the menu
    /// </summary>
    public class Water : Drink
    {
        public bool Lemon = false;

        public Water()
        {
            Size = Size.Small;
            Price = 0.10;
            Calories = 0;
            Ingredients.Add("Water");
        }
        private Size size;
        /// <summary>
        /// sets the price to the size and returns the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }
        public void HoldIce()
        {
            Ice = false ;
            
        }

        
    }
}
