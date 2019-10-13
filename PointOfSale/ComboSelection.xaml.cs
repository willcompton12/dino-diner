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
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void Bronto(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new CustomizeCombo());
        }

        private void Nugged(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

        private void Steako(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

        private void King(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

        private void PBJ(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

        private void Wings(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

        private void Wrapped(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new CustomizeCombo());
        }

    }
}
