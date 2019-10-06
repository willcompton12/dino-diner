using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that keeps track of available items on the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// All available items on the menu
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> available = new List<IMenuItem>();
                available.Add(new JurrasicJava());
                available.Add(new Sodasaurus());
                available.Add(new Tyrannotea());
                available.Add(new Water());
                available.Add(new Brontowurst());
                available.Add(new DinoNuggets());
                available.Add(new PrehistoricPBJ());
                available.Add(new PterodactylWings());
                available.Add(new SteakosaurusBurger());
                available.Add(new TRexKingBurger());
                available.Add(new VelociWrap());
                available.Add(new Fryceritops());
                available.Add(new MeteorMacAndCheese());
                available.Add(new MezzorellaSticks());
                available.Add(new Triceritots());
                return available;
            }
        }

        /// <summary>
        /// All available Entrees on the menu
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                entrees.Add(new Brontowurst());
                entrees.Add(new DinoNuggets());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new SteakosaurusBurger());
                entrees.Add(new TRexKingBurger());
                entrees.Add(new VelociWrap());
                return entrees;
            }
        }
        /// <summary>
        /// All available Sides on the menu
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                sides.Add(new Fryceritops());
                sides.Add(new MeteorMacAndCheese());
                sides.Add(new MezzorellaSticks());
                sides.Add(new Triceritots());
                return sides;
            }
        }
        /// <summary>
        /// All available Drinks on the menu
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                drinks.Add(new JurrasicJava());
                drinks.Add(new Sodasaurus());
                drinks.Add(new Tyrannotea());
                drinks.Add(new Water());
                return drinks;

            }
        }
        /// <summary>
        /// Overrides the ToString method and returns a string of 
        /// all available items seperated by a new line
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem m in AvailableMenuItems)
            {
                sb.Append(m + "\n");
            }
            return sb.ToString();
        }


    }
}
