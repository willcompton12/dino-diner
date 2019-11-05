using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a Tyrannotea class to add tea to the menu
    /// </summary>
    public class Tyrannotea : Drink
    {
        
        /// <summary>
        /// Holds if the customer wants sweet tea or not
        /// </summary>
        public bool Sweet = false;
        /// <summary>
        /// holds if the customer wants lemon with their tea
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// constructor to set the default values of the tea
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 8;
            
        }

        /// <summary>
        /// Sets sweet to true, adds sugar to the ingredients list, and sets the default calories
        /// to 16 if the customer wants sweet tea
        /// </summary>
        public void MakeSweet()
        {
            Sweet = true;
            Calories = 16;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Calories");
        }

        /// <summary>
        /// Adds Lemon to the ingredients and sets lemon to true 
        /// if the customer wants lemon with their tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Creates list of immutable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                ingredients.Add("Water");
                ingredients.Add("Tea");
                return ingredients;
            }
        }
      
        private Size size;
        /// <summary>
        /// sets the price to the size and returns the size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (size == Size.Small)
                {
                    Price = .99;
                    Calories = 8;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");

                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                    NotifyOfPropertyChanged("Price");
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");
                }
                if (Sweet)
                {
                    Calories *= 2;
                    NotifyOfPropertyChanged("Calories");
                    NotifyOfPropertyChanged("Description");

                }
            }
        }


        /// <summary>
        /// Overrides ToString to return the name of the drink as we want it
        /// </summary>
        /// <returns>Name of Drink</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.size);
            sb.Append(" ");
            if (Sweet)
            {
                sb.Append("Sweet ");
            }
            sb.Append("Tyranno-Tea");
            return sb.ToString();
        }

        /// <summary>
        /// Provides a description of the Drink
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// gets special instructions 
        /// </summary>
        public override string[] Special
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
