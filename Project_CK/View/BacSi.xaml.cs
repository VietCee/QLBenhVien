using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Project_CK.View
{
    /// <summary>
    /// Interaction logic for BacSi.xaml
    /// </summary>
    public partial class BacSi : UserControl
    {
        public BacSi()
        {
            InitializeComponent();
        }

        DataBase.DataProcess dtBase = new DataBase.DataProcess();

        void LoadData()
        {
            DataTable dt = dtBase.ReadData("Select * from tblBacSi");
            dtgBacSi.ItemsSource = dt.AsDataView();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbbGTinhBS.Items.Add("Nam");
            cbbGTinhBS.Items.Add("Nữ");

            cbbKhoa.Items.Add("Khoa Khám Bệnh");
            cbbKhoa.Items.Add("Khoa Da Liễu");
            cbbKhoa.Items.Add("Khoa Nội Soi");
            cbbKhoa.Items.Add("Khoa Răng - Hàm - Mặt");


            cbbTimKiemBS.Items.Add("Mã BS");
            cbbTimKiemBS.Items.Add("Tên BS");


            LoadData();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtBS = new DataTable();

            if (txtMaBS.Text == "" || txtTenBS.Text == "" || cbbGTinhBS.Text == "" || txtSDTBS.Text == "" || cbbKhoa.Text == "" || txtKinhNghiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaBS.Focus();
                return;
            }

            dtBS = dtBase.ReadData("Select * from tblBacSi where MaBS = '" + txtMaBS.Text + "'");

            if (dtBS.Rows.Count > 0)
            {
                MessageBox.Show("Mã bác sĩ đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaBS.Focus();
                return;
            }

            string gioiTinh = "";
            if (cbbGTinhBS.SelectedIndex == 0)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";

            dtBase.ChangeData("Insert into tblBacSi values('" + txtMaBS.Text + "','"+txtTenBS.Text+"','" + gioiTinh + "','" + txtSDTBS.Text + "','" + cbbKhoa.SelectedItem + "','" + txtKinhNghiem.Text + "','"+duongdanBS+"')");
            MessageBox.Show("Thêm bác sĩ thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadData();

            txtMaBS.Clear();
            txtTenBS.Clear();
            cbbGTinhBS.SelectedIndex = -1;
            txtSDTBS.Clear();         
            cbbKhoa.SelectedIndex = -1;
            txtKinhNghiem.Clear();
            imgBS.Source= null;
        }
        string duongdanBS;
        private void btnTaiAnhBS_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDiaLog = new OpenFileDialog();
            openDiaLog.Filter = "Image files | *.bmp;*.jpg; *.png;*.jpng";
            openDiaLog.FilterIndex = 1;
            if (openDiaLog.ShowDialog() == true)
            {
                duongdanBS = openDiaLog.FileName;
                imgBS.Source = new BitmapImage(new Uri(duongdanBS));
            }
        }

       

        private void Delete(string MaBS)
        {
            string strDelete = "DELETE FROM tblBacSi WHERE MaBS = ('" + MaBS + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dtgBacSi.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedMaBS = selectedRow["ID"].ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu có mã " + selectedMaBS + "?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Delete(selectedMaBS);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            dtBase.ChangeData("update tblBacSi set TenBS = '" + txtTenBS.Text + "',GioiTinh = '" + cbbGTinhBS.SelectedItem + "',SDT = '" + txtSDTBS.Text + "'," +
                "ChuyenKhoa = '" + cbbKhoa.SelectedItem + "',KinhNghiem = '"+txtKinhNghiem.Text+"',Anh = '"+duongdanBS+"' where MaBS = '" + txtMaBS.Text + "'");

            LoadData();
            txtMaBS.IsEnabled = true;
            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void dtgBacSi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dtr = (DataRowView)dtgBacSi.SelectedItem;
            if (dtr != null)
            {

                txtMaBS.Text = dtr[0].ToString();
                txtTenBS.Text = dtr[1].ToString();
                cbbGTinhBS.Text = dtr[2].ToString();
                txtSDTBS.Text = dtr[3].ToString();
                cbbKhoa.Text = dtr[4].ToString();
                txtKinhNghiem.Text = dtr[5].ToString();
                imgBS.Source = new BitmapImage(new Uri(dtr[6].ToString()));
                txtMaBS.IsEnabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";

            if(cbbTimKiemBS.SelectedIndex == 0)
            {
                sql = "Select * from tblBacSi where MaBS is not null";
                sql = sql + " and MaBS like '%" + txtTimKiem.Text + "%'";
                DataTable dtTimKiem = dtBase.ReadData(sql);
                dtgBacSi.ItemsSource = dtTimKiem.AsDataView();
            }
            else
            {
                sql = "Select * from tblBacSi where TenBS is not null";
                sql = sql + " and TenBS like '%" + txtTimKiem.Text + "%'";
                DataTable dtTimKiem = dtBase.ReadData(sql);
                dtgBacSi.ItemsSource = dtTimKiem.AsDataView();
            }

            
            
        }

        private void btnReLoad_Click(object sender, RoutedEventArgs e)
        {
            string sql = "Select * from tblBacSi";
            DataTable dtTimKiem = dtBase.ReadData(sql);
            dtgBacSi.ItemsSource = dtTimKiem.AsDataView();
        }
    }
}
