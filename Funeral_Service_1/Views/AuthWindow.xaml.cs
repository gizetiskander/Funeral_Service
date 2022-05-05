using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Funeral_Service_1.db;

namespace Funeral_Service_1.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        public static C_User authUser;
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AuthWindow.dbEntities.C_User)
            {
                if (user.Email == Email.Text.Trim())
                {
                    if (user.Password == Password.Text.Trim() && user.ID_Role == 2)
                    {
                        MessageBox.Show($"Привет, админ: {user.User_Name}");
                        AuthWindow.authUser = user;
                        MainWindow main = new MainWindow();
                        this.Close();
                        main.Show();
                    }
                    if (user.Password == Password.Text.Trim() && user.ID_Role == 1)
                    {
                        MessageBox.Show($"Привет, пользователь: {user.User_Name}");
                        AuthWindow.authUser = user;
                        MainWindow main = new MainWindow();
                        this.Close();
                        main.Show();
                    }
                }
            }
        }
    }
}
