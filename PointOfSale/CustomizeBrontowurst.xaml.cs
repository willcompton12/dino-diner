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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private int type;
        private Brontowurst bronto;
        public CustomizeBrontowurst(Brontowurst entree, int from)
        {
            InitializeComponent();
            bronto = entree;
            type = from;
        }

        private void OnHoldBun(Object sender, RoutedEventArgs args)
        {
            bronto.HoldBun();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            bronto.HoldPeppers();
        }

        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            bronto.HoldOnion();
        }

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
