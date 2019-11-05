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
        private int from;
        public CretaceousCombo combo;
        private Side side { get; set; }
        /// <summary>
        /// Creates page to allow the user to select the side
        /// </summary>
        public SideSelection(int type)
        {
            InitializeComponent();
            from = type;
        }
        /// <summary>
        /// Allows to edit side for a combo
        /// </summary>
        /// <param name="input"></param>
        public SideSelection(CretaceousCombo input, int type)
        {
            InitializeComponent();
            combo = input;
            from = type;
        }

        private void FriesClicked(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if (from == 1)
                {
                    side = new Fryceritops();
                    order.Add(side);
                }
                if(from == 2)
                {
                    side = new Fryceritops();
                    combo.Side = new Fryceritops();
                }
            }
        }
        private void MacClicked(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (from == 1)
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                }
                if (from == 2)
                {
                    combo.Side = new MeteorMacAndCheese();
                }
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
                if (from == 1)
                {
                    side.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                }
                if(from == 2)
                {
                    combo.Side.Size = (DDSize)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                }
            }
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

    }
}
