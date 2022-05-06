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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        public static Payment payment = new Payment();
        public AdminPage()
        {
            InitializeComponent();

            var product = dbEntities.Payment.Count();
            Card.Text = Convert.ToString(dbEntities.Payment.Count());
            Card1.Text = Convert.ToString(dbEntities.Product.Count());
            Card2.Text = Convert.ToString(dbEntities.C_User.Count());

            AdminList.ItemsSource = dbEntities.C_User.ToList();
        }


        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            var q = AdminList.SelectedItem as C_User;
            if (q == null)
            {
                MessageBox.Show("Эта строка пуста.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите сохранить?", "Сохранить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    dbEntities.C_User.Add(q);
                    dbEntities.SaveChanges();
                    AdminList.ItemsSource = dbEntities.C_User.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным или таких данных нет");
                }

            }
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var q = AdminList.SelectedItem as C_User;
            if (q == null)
            {
                MessageBox.Show("Эта строка и так пустая.");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить строку?", "Удалить?", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    dbEntities.C_User.Remove(q);
                    dbEntities.SaveChanges();
                    AdminList.ItemsSource = dbEntities.C_User.ToList();
                }
                catch
                {
                    MessageBox.Show("Удалите соединения связанные с этим данным");
                }

            }
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AdminList.ItemsSource = dbEntities.Service.ToList();
            ID.DisplayMemberBinding = new Binding("ID_Service");
            ID.Header = "ID_Service";
            ID.Width = 100;
            Name.DisplayMemberBinding = new Binding("Service_Name");
            Name.Header = "Service_Name";
            Name.Width = 100;
            Image.DisplayMemberBinding = new Binding("Service_Price");
            Image.Header = "Service_Price";
            Image.Width = 100;
            table_Name.Text = "Услуги";
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AdminList.ItemsSource = dbEntities.C_User.ToList();
            ID.DisplayMemberBinding = new Binding("ID_User");
            ID.Header = "ID_User";
            ID.Width = 100;
            Name.DisplayMemberBinding = new Binding("User_Name");
            Name.Header = "User_Name";
            Name.Width = 100;
            Image.DisplayMemberBinding = new Binding("User_Image");
            Image.Header = "User_Image";
            Image.Width = 100;
            table_Name.Text = "Пользователи";
        }
    }
}
