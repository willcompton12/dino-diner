using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        
      
        private int total = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
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

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.total += 1;
            this.Calories += 59;
            this.Price += .25;

        }
       
    }
}
