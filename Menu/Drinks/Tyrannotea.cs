using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
            
        }
        /// <summary>
        /// Sets sweet to true, adds sugar to the ingredients list, and sets the default calories
        /// to 16 if the customer wants sweet tea
        /// </summary>
      public void MakeSweet()
        {
            Sweet = true;
            Ingredients.Add("Cane Sugar");
            Calories = 16;
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
                if (size == Size.Small)
                {
                    Price = .99;
                    Calories = 8;
                    
                }
                if (size == Size.Medium)
                {
                    Price = 1.49;
                    Calories = 16;
                }
                if (size == Size.Large)
                {
                    Price = 1.99;
                    Calories = 32;
                }
                if (Sweet)
                {
                    Calories *= 2;
                    
                }
            }
        }

        /// <summary>
        /// Adds Lemon to the ingredients and sets lemon to true 
        /// if the customer wants lemon with their tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }

        
    }
}
