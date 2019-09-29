using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Creates a Tyrannotea class to add tea to the menu
    /// </summary>
    public class JurrasicJava : Drink
    {
        public bool RoomForCream = false;
        public bool Decaf = false;

        public JurrasicJava()
        {
            Size = Size.Small;
            Price = 0.59;
            Calories = 2;
            Ice = false;
            Ingredients.Add("Water");
            Ingredients.Add("Coffee");
        }
        /// <summary>
        /// 
        /// </summary>
      public void LeaveRoomForCream()
        {
            RoomForCream = true;
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

        

        public void AddIce()
        {
            Ice = true;
            
        }

        
    }
}
