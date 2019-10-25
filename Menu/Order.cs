using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to keep track of order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        
        /// <summary>
        /// List of items ordered
        /// </summary>
        private List<IOrderItem> items;
        /// <summary>
        /// Cost of the items without tax
        /// </summary>
        public IOrderItem[] Items
        {
            get { return items.ToArray(); }
        }
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }


        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public  Order()
        {
            items = new List<IOrderItem>();
        }
    }
}
