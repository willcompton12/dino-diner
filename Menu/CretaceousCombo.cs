using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;



namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to allow customers to get a combo meal at a slightly cheaper price
    /// </summary>
    public class CretaceousCombo : INotifyPropertyChanged , IOrderItem , IMenuItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Entree entree;
        /// <summary>
        /// Sets the entree of the combo
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }

        private Side side;
        /// <summary>
        /// The side of the combo
        /// </summary>
        public Side Side
        {
            get {return side; }
            set
            {
                side = value;
                side.Size = this.size;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Side");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                side.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                    NotifyOfPropertyChanged("Special");
                };
            }
        }

        private Drink drink;
        /// <summary>
        /// The drink of the combo
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                drink.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                    NotifyOfPropertyChanged("Special");
                };

            }
        }

        
        /// <summary>
        /// sets how much the combo price is.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }

            set
            {
                return;
            }

            
        }
        /// <summary>
        /// Returns the total calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
            set
            {
                return;
            }
        }
        private Size size = Size.Small;

        

        /// <summary>
        /// Sets the size for the drink and side in the combo
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Size");
            }
        }
        /// <summary>
        /// Creates a list of all of the ingredients in the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor to create a Cretaceous combo
        /// </summary>
        /// <param name="entree">Entree of choice by customer</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();

        }
        /// <summary>
        /// Overrides the ToString method and allows us to return 
        /// the name of the Combo with proper formatting
        /// </summary>
        /// <returns>Name of Combo as type string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Entree.ToString());
            sb.Append(" Combo");
            return sb.ToString() ;
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(Entree.Description);
                
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                
                return special.ToArray();
            }
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

     
    }
}
