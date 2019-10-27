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

        private void OnCherry(object sender, RoutedEventArgs args)
        {
            drink.Flavor = SodasaurusFlavor.Cherry;
        }

       
    }
}
