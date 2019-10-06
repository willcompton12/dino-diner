using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class to add drinks to the menu that uses the interface IMenuItem
    /// </summary>
    public abstract class Drink : IMenuItem
    {
        /// <summary>
        /// variable to hold ingredients in
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Holds the price of the drink
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// holds the calories of the drink
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Returns the list of ingredients
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }
        /// <summary>
        /// holds if the customer wants ice in their drink or not
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// removes ice from drink
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
        /// <summary>
        /// Holds the size of the drink
        /// </summary>
        public virtual Size Size {get;set;}
    }
}
