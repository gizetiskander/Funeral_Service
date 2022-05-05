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
using Funeral_Service_1.db;

namespace Funeral_Service_1.Views
{
    /// <summary>
    /// Логика взаимодействия для PayProductPage.xaml
    /// </summary>
    public partial class PayProductPage : Page
    {
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        public static C_User authUser;
        public PayProductPage()
        {
            InitializeComponent();
            foreach (var a in PayProductPage.dbEntities.Product)
            {
                ProductCB.ItemsSource = dbEntities.Product.Where(x => x.ID_Role == 1).ToList();
                PaymentCB.ItemsSource = dbEntities.PaymentType.Where(x => x.ID_Role == 1).ToList();
            }
        }

        private void PaymentCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var payName = ((PaymentType)PaymentCB.SelectedItem).Name_PaymentType;
            var payment = PayProductPage.dbEntities.PaymentType.Where(x => x.Name_PaymentType == payName).FirstOrDefault();
        }

        private void btn_Pay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void ProductCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var productName = ((Product)ProductCB.SelectedItem).Product_Name;
            var product = PayProductPage.dbEntities.Product.Where(x => x.Product_Name == productName).FirstOrDefault();
            Price.Text = product.Product_Price.ToString();
        }
    }
}
