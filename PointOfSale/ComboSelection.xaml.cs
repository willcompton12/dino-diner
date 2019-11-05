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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        

        private Entree entree;
        private CretaceousCombo combo;
        /// <summary>
        /// Creates the combo selection page for the GUI
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();

            
        }
        /// <summary>
        /// Event handler for when the Brontowurst button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bronto(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        /// <summary>
        /// Event handler for when the Nugget button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nugged(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        /// <summary>
        /// Event handler for when the Steakosaurus Burger button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Steako(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        /// <summary>
        /// Event handler for when the King burger button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void King(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        /// <summary>
        /// Event handler for when the PB&amp;J button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                
                entree = new PrehistoricPBJ();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            
        }
        /// <summary>
        /// Event handler for when the pterodactyl wings button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
        /// <summary>
        /// Event handler for when the veloci-wrap button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wrapped(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                combo = new CretaceousCombo(entree);
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

    }
}
