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
        private Drink drink { get; set; }
        /// <summary>
        /// Sets up xaml file for the drink selection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
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
                drink = new Sodasaurus();
                order.Add(drink);
            }
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxFlavor.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
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
                drink = new Tyrannotea();
                order.Add(drink);
            }
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Sweet";
            chxHoldIce.IsEnabled = true;
            chxLemon.IsEnabled = true;
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
                drink = new JurrasicJava();
                order.Add(drink);
            }
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Decaf";
            chxHoldIce.IsEnabled = true;
            chxHoldIce.Content = "Add Ice";
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
                drink = new Water();
                order.Add(drink);
            }
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the Flavor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void OnChangedSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
            }
        }
     


    }
}
