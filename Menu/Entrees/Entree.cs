using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// Base class that Entree items derive from.
    /// uses interface IMenuItem to make entrees part 
    /// of the menu
    /// </summary>
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// instance to build the ingredients with. This is ultimately overwritten.
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }
        /// <summary>
        /// Desription of the entree
        /// </summary>
        public string Description { get;}
        /// <summary>
        /// special instructions for the item
        /// </summary>
        public string[] Special { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
