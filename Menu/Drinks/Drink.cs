using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class to add drinks to the menu that uses the interface IMenuItem
    /// </summary>
    public abstract class Drink : IMenuItem , INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Event Hnadler for when a property is changed
        /// to update the gui
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
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
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Holds the size of the drink
        /// </summary>
        public virtual Size Size {get;set;}

        /// <summary>
        /// Desription of the Drink
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// special instructions for the item
        /// </summary>
        public abstract string[] Special { get; }

    }
}
