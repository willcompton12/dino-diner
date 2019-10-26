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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side { get; set; }
        /// <summary>
        /// Creates page to allow the user to select the side
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        private void FriesClicked(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }
        private void MacClicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }
        }

        private void MezzorellaClicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                order.Add(side);
            }
        }

        private void TotsClicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                order.Add(side);
            }
        }


        private void OnChangedSize(object sender, RoutedEventArgs args)
        {
            if(sender is FrameworkElement element)
            {
               side.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString()) ;
            }
        }

    }
}
