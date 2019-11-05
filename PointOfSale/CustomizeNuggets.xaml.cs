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
    /// Interaction logic for CustomizeNuggets.xaml
    /// </summary>
    public partial class CustomizeNuggets : Page
    {
        private DinoNuggets entree;
        private int type;
        public CustomizeNuggets(DinoNuggets nuggs, int from)
        {
            InitializeComponent();
            type = from;
            entree = nuggs;
        }

        private void OnAdd(object sender, RoutedEventArgs args)
        {
            entree.AddNugget();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (type == 1)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            if (type == 2)
            {
                NavigationService.Navigate(new CustomizeCombo(new CretaceousCombo(entree)));
            }
        }
    }
}
