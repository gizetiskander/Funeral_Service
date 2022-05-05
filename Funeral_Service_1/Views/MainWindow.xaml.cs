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
using Funeral_Service_1.db;

namespace Funeral_Service_1.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Funeral_Service_dbEntities dbEntities = new Funeral_Service_dbEntities();
        public static C_User authUser;
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Admin_Initialized(object sender, EventArgs e)
        {
            if (AuthWindow.authUser.ID_Role == 1)
            {
                btn_Admin.Visibility = Visibility.Hidden;
            }
            else if (AuthWindow.authUser.ID_Role == 2)
            {
                btn_Admin.Visibility = Visibility.Visible;
            }
        }
    }
}
