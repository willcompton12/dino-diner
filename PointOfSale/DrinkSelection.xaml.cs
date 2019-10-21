﻿using System;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Sets up xaml file for the drink selection page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Soda button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodaClick(object sender, RoutedEventArgs e)
        {
            
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxFlavor.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the tea button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaClick(object sender, RoutedEventArgs e)
        {
            
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Sweet";
            chxHoldIce.IsEnabled = true;
            chxLemon.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the java button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jurrasicJavaClick(object sender, RoutedEventArgs e)
        {
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = false;
            chxSpecialty.IsEnabled = true;
            chxSpecialty.Content = "Decaf";
            chxHoldIce.IsEnabled = true;
            chxHoldIce.Content = "Add Ice";
        }
        /// <summary>
        /// Event handler for when the Water button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            chxFlavor.IsEnabled = false;
            chxSpecialty.IsEnabled = false;
            chxHoldIce.IsEnabled = false;
            chxLemon.IsEnabled = true;
            chxHoldIce.IsEnabled = true;
        }
        /// <summary>
        /// Event handler for when the Flavor button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlavorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
