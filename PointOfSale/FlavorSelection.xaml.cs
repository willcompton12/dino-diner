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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        private Sodasaurus drink { get; set; }
        /// <summary>
        /// creates a page to allow the user to select a flavor for the soda
        /// </summary>
        public FlavorSelection(Sodasaurus input)
        {
            InitializeComponent();
            drink = input;
        }
        /// <summary>
        /// Event Handler to change the flavor to cherry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCherry(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event Handler to change the flavor to chocolate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChocolate(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.GoBack();
        }
        /// <summary>
        /// Event Handler to change the flavor to cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCola(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Cola;
            NavigationService.GoBack();
        }
        /// <summary>
        /// Event Handler to change the flavor to lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLime(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Lime;
            NavigationService.GoBack();
        }
        /// <summary>
        /// Event Handler to change the flavor to orange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnOrange(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Orange;
            NavigationService.GoBack();
        }
        /// <summary>
        /// Event Handler to change the flavor to rootbeer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRootbeer(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.GoBack();
        }
        /// <summary>
        /// Event Handler to change the flavor to vanilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVanilla(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.GoBack();
        }


    }
}
