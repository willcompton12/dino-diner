using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Allows us to easily access ordered items properties in the gui
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// price of the item
        /// </summary>
        double Price { get;}
        /// <summary>
        /// description of the item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// special instructions for the item
        /// </summary>
        string[] Special { get; }


    }
}
