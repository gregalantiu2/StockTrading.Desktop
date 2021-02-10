using StockTrading.Desktop.ApiKeys;
using StockTrading.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StockTrading.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Account account;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Loaded(object sender,RoutedEventArgs e)
        {
            contentFrame.NavigationService.Navigate(new HomeWindow());
            account = new Account(APIKeys.ApiKey,APIKeys.SecretKey);

            var test = account.Run();
            var test2 = account.buyingPower;

        }

        private void AlgoLink_Clicked(object sender, RoutedEventArgs e)
        {
            contentFrame.NavigationService.Navigate(new AlgoWindow());
        }
        private void HomeLink_Clicked(object sender, RoutedEventArgs e)
        {
            contentFrame.NavigationService.Navigate(new HomeWindow());
        }
    }
}
