using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        public static Service service = new Service();
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        

        public PaymentPage()
        {
            InitializeComponent();
            foreach (var serv in PaymentPage.dbEntities.Service)
            {
                ServiceCB.ItemsSource = dbEntities.Service.Where(x => x.ID_Role == 1).ToList();
                GraveCB.ItemsSource = dbEntities.Graveyard.Where(x => x.ID_Role == 1).ToList();
                PaymentCB.ItemsSource = dbEntities.PaymentType.Where(x => x.ID_Role == 1).ToList();
            }
        }

        private void btn_Pay_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "" || Card.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                Basket basket = new Basket();
                basket.ID_User = AuthWindow.authUser.ID_User;
                basket.Count = 1;
                basket.Done = false;
                Payment payment = new Payment();
                PaymentType paymentType = new PaymentType();
                payment.Card = Card.Text;
                payment.Name_Payment = UserName.Text;
                payment.ID_User = AuthWindow.authUser.ID_User;
                payment.Paid = true;
                PaymentPage.dbEntities.Payment.Add(payment);
                PaymentPage.dbEntities.SaveChanges();
                MessageBox.Show("Успешно!");
                NavigationService.Navigate(new BucketPage());
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void ServiceCB_Selected(object sender, RoutedEventArgs e)
        {
            var serName = ((Service)ServiceCB.SelectedItem).Service_Name;
            var service = PaymentPage.dbEntities.Service.Where(x => x.Service_Name == serName).FirstOrDefault();
            Price.Text = service.Service_Price.ToString();
        }

        private void PaymentCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var payName = ((PaymentType)PaymentCB.SelectedItem).Name_PaymentType;
            var payment = PaymentPage.dbEntities.PaymentType.Where(x => x.Name_PaymentType == payName).FirstOrDefault();
        }

        private void GraveCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var graveName = ((Graveyard)GraveCB.SelectedItem).Graveyard_Name;
            var graveyard = PaymentPage.dbEntities.Graveyard.Where(x => x.Graveyard_Name == graveName).FirstOrDefault();
        }

        private void ServiceCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var serName = ((Service)ServiceCB.SelectedItem).Service_Name;
            var service = PaymentPage.dbEntities.Service.Where(x => x.Service_Name == serName).FirstOrDefault();
            Price.Text = service.Service_Price.ToString();
        }
    }
}
