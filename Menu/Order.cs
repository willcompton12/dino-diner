using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to keep track of order
    /// </summary>
    public class Order 
    {
        /// <summary>
        /// List of items ordered
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// Cost of the items without tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0.00;
                foreach (IOrderItem orderItem in Items)
                {
                    total += orderItem.Price;
                }
                return total;
            }
        }
        /// <summary>
        /// going tax rate for city 
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// The amount of tax for the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                double cost = 0.00;
                return cost += (SalesTaxRate * SubtotalCost);
            }
        }
        /// <summary>
        /// Cost of the ordered items plus the tax
        /// </summary>
        public double TotalCost
        {
            get
            {
                double final = 0.00;
                return final + SubtotalCost + SalesTaxCost;
            }
        }
    }
}
