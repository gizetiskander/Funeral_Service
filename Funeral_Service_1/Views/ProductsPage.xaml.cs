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

namespace Funeral_Service_1.Views
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void btn_Pamatnik_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PayProductPage());
        }

        private void btn_Grob1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PayProductPage());
        }

        private void btn_Venok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PayProductPage());
        }
    }
}
