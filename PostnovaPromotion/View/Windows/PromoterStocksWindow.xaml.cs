using PostnovaPromotion.View.Pages;
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
using System.Windows.Shapes;

namespace PostnovaPromotion.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для PromoterStocksWindow.xaml
    /// </summary>
    public partial class PromoterStocksWindow : Window
    {
        public PromoterStocksWindow()
        {
            InitializeComponent();
        }

        private void MyActionsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyStocksPage());
        }

        private void AvailableActionsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new availableStocksPage());
        }

        private void FinesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FinesPage());
        }
    }
}
