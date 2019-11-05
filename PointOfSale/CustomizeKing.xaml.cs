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
    /// Interaction logic for CustomizeKing.xaml
    /// </summary>
    public partial class CustomizeKing : Page
    {
        private TRexKingBurger burger;
        private int from;
        public CustomizeKing(TRexKingBurger input, int type)
        {
            InitializeComponent();
            burger = input;
            from = type;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }
        private void OnHoldOnions(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
        }
        /// <summary>
        /// Leaves the cutomization page and returns to categorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (from == 1)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            if (from == 2)
            {
                NavigationService.GoBack();
            }
        }
    }
}

    

