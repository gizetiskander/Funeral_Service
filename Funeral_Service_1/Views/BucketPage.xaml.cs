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
        public static C_User authUser;
        public BucketPage()
        {
            dbEntities = new Funeral_Service_dbEntities();
            InitializeComponent();

            BasketLB.ItemsSource = BucketPage.dbEntities.Basket.Where(x => x.ID_User == AuthWindow.authUser.ID_User).ToList();
        }
    }
}
