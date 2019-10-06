using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface to allow the Entrees, Sides, and Drinks
    /// be added to the "menu"
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price of the item
        /// </summary>
         double Price { get; set; }
        /// <summary>
        /// Calories of the item
        /// </summary>
         uint Calories { get; set; }
        /// <summary>
        /// ingredients of the item
        /// </summary>
        List<string> Ingredients { get; }

    }
}
