using Funeral_Service_1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Funeral_Service_1.ViewModel
{
    internal class MainViewFoundation : ModelFoundation
    {
        private Page MainPage = new MainPage();
        private Page ServPage = new ServPage();
        private Page InfoPage = new InfoPage();
        private Page ProductsPage = new ProductsPage();
        private Page _CurPage = new MainPage();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenMPage
        {
            get
            {
                return new RelayCommand(() => CurPage = MainPage);
            }
        }

        public ICommand OpenSPage
        {
            get
            {
                return new RelayCommand(() => CurPage = ServPage);
            }
        }

        public ICommand OpenIPage
        {
            get
            {
                return new RelayCommand(() => CurPage = InfoPage);
            }
        }

        public ICommand OpenPPage
        {
            get
            {
                return new RelayCommand(() => CurPage = ProductsPage);
            }
        }

     
    }
}
