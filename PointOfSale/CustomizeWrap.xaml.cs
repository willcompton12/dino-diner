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
    /// Interaction logic for CustomizeWrap.xaml
    /// </summary>
    public partial class CustomizeWrap : Page
    {
        private int type;
        private VelociWrap wrap;
            public CustomizeWrap(VelociWrap input, int from)
        {
            InitializeComponent();
            wrap = input;
            type = from;
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }

        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }
        /// <summary>
        /// Leaves the cutomization page and returns to categorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
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
