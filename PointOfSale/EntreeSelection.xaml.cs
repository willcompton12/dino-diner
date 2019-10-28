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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree { get; set; }
        /// <summary>
        /// Creates a page to allow the user to select an entree
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler to add Brontowurst to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        /// <summary>
        /// Event handler to add Dino-Nuggets to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        /// <summary>
        /// Event handler to add Steakosaurus Burger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSteakosaurus(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        /// <summary>
        /// Event handler to add Trex King burger to menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnTRex(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        /// <summary>
        /// Event Handler to add Prehistoric PBJ to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
                NavigationService.Navigate(new CustomizePrehistoricPBJ(((PrehistoricPBJ)entree), 1));
            }

        }
        /// <summary>
        /// Event Handler to add Pterodactyl Wings to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
        /// <summary>
        /// Event handler to add Veloci-Wrap to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnWrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }

        }
    }
}
