using Funeral_Service_1.db;
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
    /// Логика взаимодействия для BucketPage.xaml
    /// </summary>
    public partial class BucketPage : Page
    {
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        public BucketPage()
        {
            dbEntities = new Funeral_Service_dbEntities();
            InitializeComponent();
            foreach(var basket in BucketPage.dbEntities.Basket)
            {
                if (AuthWindow.authUser.ID_User == 4)
                {
                    Basket.ItemsSource = dbEntities.Basket.Where(x => x.ID_User == 4).ToList();

                }
            }   
        }

        private void btn_Pay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentPage());
        }
    }
}
