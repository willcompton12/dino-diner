using System;
using System.Collections.Generic;
using System.Text;

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
        }

        /// <summary>
        /// Adds Lemon to the ingredients and sets lemon to true 
        /// if the customer wants lemon with their tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }

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

    }
}
