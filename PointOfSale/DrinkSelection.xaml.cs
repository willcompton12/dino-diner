using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public CretaceousCombo combo;
        private int type;
        private Drink drink { get; set; }
        /// <summary>
        /// Sets up xaml file for the drink selection page
        /// </summary>
        public DrinkSelection(int from)
        {
            InitializeComponent();
            type = from;
        }

        public DrinkSelection(CretaceousCombo input, int from)
        {
            InitializeComponent();
            type = from;
            combo = input;
        }

        /// <summary>
        /// Event handler for when the Soda button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (type == 1)
                {
                    drink = new Sodasaurus();
                    order.Add(drink);
                }
                if (type == 2)
                {

                    combo.Drink = new Sodasaurus();
                }
            }
            chxHoldIce.Content = "Hold Ice";
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxFlavor.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
            chxDone.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the tea button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (type == 1)
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                }
                if (type == 2)
                {
                    
                    combo.Drink = new Tyrannotea();
                }
            }
            chxHoldIce.Content = "Hold Ice";
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Sweet";
            chxHoldIce.IsEnabled = true;
            chxLemon.IsEnabled = true;
            chxDone.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the java button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jurrasicJavaClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (type == 1)
                {
                    drink = new JurrasicJava();
                    order.Add(drink);
                }
                if (type == 2)
                {

                    combo.Drink = new JurrasicJava();
                }
            }
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Decaf";
            chxHoldIce.IsEnabled = true;
            chxHoldIce.Content = "Add Ice";
            chxDone.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the Water button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (type == 1)
                {
                    drink = new Water();
                    order.Add(drink);
                }
                if (type == 2)
                {

                    combo.Drink = new Water();
                }
            }
            chxHoldIce.Content = "Hold Ice";
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
            chxDone.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the Flavor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            if (type == 1)
            {
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)drink));
            }
            if(type == 2)
            {
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)combo.Drink));

            }
        }
        /// <summary>
        /// Event handler for when the size is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangedSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if (type == 1)
                {
                    drink.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                }
                if(type == 2)
                {
                   combo.Drink.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                }
            }
        }
     /// <summary>
     /// Event handler to add lemon to the order
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="args"></param>
        private void OnLemon(object sender, RoutedEventArgs args)
        {
            if (type == 1)
            {
                if (drink is Water water)
                {
                    water.AddLemon();
                }
                if (drink is Tyrannotea tea)
                {

                    tea.AddLemon();
                }
            }
            if (type == 2)
            {
                if (combo.Drink is Water water)
                {
                    water.AddLemon();
                }
                if (combo.Drink is Tyrannotea tea)
                {

                    tea.AddLemon();
                }
            }
        }
        /// <summary>
        /// event handler to hold ice for drinks or add ice for java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldIce(object sender, RoutedEventArgs args)
        {
            if (type == 1)
            {
                drink.HoldIce();
                if (drink is JurrasicJava java)
                {
                    java.AddIce();
                }
            }
            if (type == 2)
            {
                combo.Drink.HoldIce();
                if (combo.Drink is JurrasicJava java)
                {
                    java.AddIce();
                }

            }
        }
        /// <summary>
        /// Event handler to make the tea sweet or make the coffee decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSpecial(object sender, RoutedEventArgs args)
        {
            if (type == 1)
            {
                if (drink is Tyrannotea tea)
                {
                    tea.MakeSweet();
                }

                if (drink is JurrasicJava java)
                {
                    java.MakeDecaf();
                }
            }
            if (type == 2)
            {
                if (combo.Drink is Tyrannotea tea)
                {
                    tea.MakeSweet();
                }

                if (combo.Drink is JurrasicJava java)
                {
                    java.MakeDecaf();
                }
            }
        }
        /// <summary>
        /// Event handler to finish the drink selection and return to the start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (type == 1)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            if (type == 2)
            {
                NavigationService.GoBack();
            }
        }


    }
}
