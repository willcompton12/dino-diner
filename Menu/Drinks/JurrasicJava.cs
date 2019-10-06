using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a Jurrasic class to add tea to the menu
    /// </summary>
    public class JurrasicJava : Drink
    {
        /// <summary>
        /// Holds if the customer wants room for cream
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// Holds if the customer wants decaf coffee or not
        /// </summary>
        public bool Decaf = false;

        /// <summary>
        /// Constructor to set default values for JurrasicJava
        /// </summary>
        public JurrasicJava()
        {
            Size = Size.Small;
            Price = 0.59;
            Calories = 2;
            Ice = false;
        }
        /// <summary>
        /// Create a list of immutable ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }
        /// <summary>
        /// Sets RoomForCream value to true 
        /// </summary>
      public void LeaveRoomForCream()
        {
            RoomForCream = true;
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
                    Price = .59;
                    Calories = 2;
                    
                }
                if (size == Size.Medium)
                {
                    Price = .99;
                    Calories = 4;
                }
                if (size == Size.Large)
                {
                    Price = 1.49;
                    Calories = 8;
                }
               
            }
        }

        
        /// <summary>
        /// Adds ice to ingredients making iced coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            Ingredients.Add("Ice");
        }
        /// <summary>
        /// Allows the Customer to make the coffee Decaf
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
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
            if (Decaf)
            {
                sb.Append("Decaf ");
            }
            sb.Append("Jurrasic Java");
            return sb.ToString();
        }


    }
}
