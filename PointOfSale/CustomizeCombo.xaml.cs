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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;
        /// <summary>
        /// Creates the page to allow user to customize the combo
        /// </summary>
        public CustomizeCombo(CretaceousCombo input)
        {
            InitializeComponent();
            combo = input;
            if (combo.Entree.ToString() == "Pterodactyl Wings")
            {
                uxEdit.IsEnabled = false;
            }

        }
        /// <summary>
        /// Event handler for when the Drink button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo, 2));
        }
        /// <summary>
        /// Event handler for when the side button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo , 2));
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
        
                NavigationService.Navigate(new MenuCategorySelection());
            
        }

        private void OnEdit(object sender, RoutedEventArgs args)
        {
            if(combo.Entree.ToString() == "Brontowurst")
            {
                NavigationService.Navigate(new CustomizeBrontowurst((Brontowurst)combo.Entree, 2));
            }
            if (combo.Entree.ToString() == "Dino-Nuggets")
            {
                NavigationService.Navigate(new CustomizeNuggets((DinoNuggets)combo.Entree, 2));
            }
            if (combo.Entree.ToString() == "Prehistoric PB&J")
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ((PrehistoricPBJ)combo.Entree, 2));
            }
            if (combo.Entree.ToString() == "Steakosaurus Burger")
            {
                NavigationService.Navigate(new CustomizeSteako((SteakosaurusBurger)combo.Entree, 2));
            }

        }
    }
}
