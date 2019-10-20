using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a Water class to add water to the menu
    /// </summary>
    public class Water : Drink
    {

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Holds if the customer wants lemon with their tea or not
        /// </summary>
        public bool Lemon = false;
        
     
        /// <summary>
        /// constructor to set default values for water
        /// </summary> 
        /// 
        public Water()
        {
            Size = Size.Small;
            Price = 0.10;
            Calories = 0;
           
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
                return ingredients;
            }
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

        /// <summary>
        /// Adds lemon to the ingredients and sets lemon to true
        /// if the customer wants lemon with their water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Description");
        }


        /// <summary>
        /// Overrides ToString to return the name of the drink as we want it
        /// </summary>
        /// <returns>Name of Drink</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size);
            sb.Append(" Water");
            return sb.ToString();
        }
        /// <summary>
        /// Provides a description of the Drink
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// gets special instructions 
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }


    }
}
