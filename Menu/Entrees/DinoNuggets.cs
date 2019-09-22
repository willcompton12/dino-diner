using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        
      
        private int total = 6;

        public override List<string> Ingredients
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
            Price = 4.25;
            Calories = 354;
        }

        public void AddNugget()
        {
            this.total += 1;
            Calories += 59;
            Price += .25;

        }
       
    }
}
