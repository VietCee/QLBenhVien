using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Project_CK.Utilities;

namespace Project_CK.ViewModel
{
    public class NavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public ICommand BenhNhanCommand { get; set; }
        public ICommand BacSiCommand { get; set; }
        public ICommand BenhAnCommand { get; set; }
        public ICommand XuatVienCommand { get; set; }
        public ICommand CaiDatCommand { get; set; }

        private void BenhNhan(object obj) => CurrentView = new BenhNhanVM();
        private void BacSi(object obj) => CurrentView = new BacSiVM();
        private void BenhAn(object obj) => CurrentView = new BenhAnVM();
        private void XuatVien(object obj) => CurrentView = new XuatVienVM();
       


        public NavigationVM()
        {
            BenhNhanCommand = new RelayCommand(BenhNhan);
            BacSiCommand = new RelayCommand(BacSi);
            BenhAnCommand = new RelayCommand(BenhAn);
            XuatVienCommand = new RelayCommand(XuatVien);

            CurrentView = new BenhNhanVM();
        }
    }
}
