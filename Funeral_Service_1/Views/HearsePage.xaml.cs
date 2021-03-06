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
    /// Логика взаимодействия для HearsePage.xaml
    /// </summary>
    public partial class HearsePage : Page
    {
        public HearsePage()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentPage());
        }
    }
}
