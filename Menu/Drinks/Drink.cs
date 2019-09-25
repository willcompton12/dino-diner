using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
   public abstract class Drink
    {
        protected List<string> ingredients = new List<string>();
        public double Price { get; set; } 

        public uint Calories { get; set; }

        public List<string> Ingredients { get { return ingredients; } }

        public bool Ice { get; set; } = true;

        public void HoldIce()
        {
            Ice = false;
        }
    }
}
