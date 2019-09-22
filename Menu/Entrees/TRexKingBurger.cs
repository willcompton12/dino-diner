/*TRexKingBurger.cs
 * Author: Will Compton
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds TRex King Burger to menu as an entree
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// private boolean values to hold if the customer wants the respective ingredients
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        /// <summary>
        /// creates a list of ingredients to return to the user
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor to set price and calorie fields of base class
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
        }
        /// <summary>
        /// removes bun from ingredients
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// removes lettuce from ingredients
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// removes tomato from ingredients
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

         /// <summary>
         /// removes onion from ingredients
         /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// removes pickle from ingredients
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// removes ketchup from ingredients
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// removes mustard from ingredients
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// removes mayo from ingredients
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
