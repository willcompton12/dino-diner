using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a Water class to add water to the menu
    /// </summary>
    public class Water : Drink
    {
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
        }


        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(size);
            sb.Append(" Water");
            return sb.ToString();
        }


    }
}
