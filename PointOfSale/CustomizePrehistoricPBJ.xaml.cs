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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        private int type;
        private PrehistoricPBJ pbj;
        /// <summary>
        /// Allows user to customize their entree
        /// </summary>
        /// <param name="input"></param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ input, int from)
        {
            InitializeComponent();
            pbj = input;
            type = from;
        }
        /// <summary>
        /// holds Peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPB(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }
        /// <summary>
        /// holds jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// Leaves the cutomization page and returns to categorySelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if(type == 1)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            if(type == 2)
            {
                NavigationService.GoBack();
            }
        }
    }
}
