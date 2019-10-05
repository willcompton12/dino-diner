/*DinoNuggets.cs
 * Author: Will Compton
 */
using System.Collections.Generic;


namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Adds Dino nuggets to the menu as an entree
    /// </summary>
    public class DinoNuggets : IMenuItem
    {
        
      /// <summary>
      /// keeps track of the total number of nuggets 
      /// </summary>
        private int total = 6;
        public double Price { get; set; } = 4.25;
        public uint Calories { get; set; } = 354;
        /// <summary>
        /// Creates a list of ingredients to return to the user
        /// </summary>
        public  List<string> Ingredients
        {
            get
            {
                 List<string> ingredients = new List<string>();
                
                    for (int i = 0; i < total; i++){
                        ingredients.Add("Chicken Nugget");
                    }
                
                return ingredients;
               
            }
        }
        /// <summary>
        /// Constructor to set price and calorie fields of base class
        /// </summary>
        public DinoNuggets()
        {
            
        }
        /// <summary>
        /// Method called to add a nugget to the order
        /// </summary>
        public void AddNugget()
        {
            this.total += 1;
            Calories += 59;
            Price += .25;

        }
       
    }
}
