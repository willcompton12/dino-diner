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
        public bool Sweet = false;
        public bool Lemon = false;
        public Tyrannotea()
        {
            Size = Size.Small;
            Price = 0.99;
            Calories = 8;
            Ingredients.Add("Water");
            Ingredients.Add("Tea");
        }
        /// <summary>
        /// 
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

        

        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }

        
    }
}
