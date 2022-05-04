using Microsoft.Win32;
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
using System.IO;

namespace Funeral_Service_1.Views
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void Sign_In_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "" || Email.Text == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                C_User user = new C_User();
                user.User_Name = UserName.Text;
                user.Telephone = Phone.Text;
                user.Email = Email.Text;
                user.Password = Password.Text;
                user.ID_Role = 1;
                MessageBox.Show("Подтвердите фото");
                OpenFileDialog ofdImage = new OpenFileDialog();
                ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
                ofdImage.FilterIndex = 1;
                if (ofdImage.ShowDialog() == true)
                {
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.UriSource = new Uri(ofdImage.FileName);
                    image.EndInit();
                    playim.Source = image;
                    user.User_Image = File.ReadAllBytes(ofdImage.FileName);
                }
                AuthWindow.dbEntities.C_User.Add(user);
                try
                {
                    AuthWindow.dbEntities.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Такой пользователь уже зарегестрирован!");
                }
                finally
                {
                    MessageBox.Show("Успешно!");
                    AuthWindow auth = new AuthWindow();
                    this.Close();
                    auth.Show();
                }
            }
        }

        private void Sign_Up_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            this.Close();
            auth.Show();
        }

        private void btn_Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdImage = new OpenFileDialog();
            ofdImage.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            ofdImage.FilterIndex = 1;
            if (ofdImage.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(ofdImage.FileName);
                image.EndInit();
                playim.Source = image;
            }
        }
        private void btn_ImageDel_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage image = new BitmapImage();
            image.Freeze();
            playim.Source = image;
        }
    }
}
