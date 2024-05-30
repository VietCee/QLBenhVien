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

namespace Project_CK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, RoutedEventArgs e)
        {
            LogIn.SignIn signin = new LogIn.SignIn();
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình không ?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                signin.Show();
                this.Close();
            }
            
        }
    }
}
