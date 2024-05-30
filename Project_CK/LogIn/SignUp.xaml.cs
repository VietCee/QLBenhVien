using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

namespace Project_CK.LogIn
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        DataBase.DataProcess dtBase = new DataBase.DataProcess();
      

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtAD = new DataTable();
            if (txtName.Text == "" || txtEmail.Text == "" || txtMatKhau.Password == "" || txtXacNhanMK.Password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtName.Focus();
                return;
            }

            if(txtMatKhau.Password != txtXacNhanMK.Password)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMatKhau.Focus();
                return;
            }

            dtAD = dtBase.ReadData("Select * from tblAdmin where TaiKhoan = '" + txtEmail.Text + "'");

            if (dtAD.Rows.Count > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEmail.Focus();
                return;
            }

            dtBase.ChangeData("Insert into tblAdmin values('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtMatKhau.Password + "')");
            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            SignIn signin = new SignIn();
            signin.Show();
            this.Close();

        }
    }
}
