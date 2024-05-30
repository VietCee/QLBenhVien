using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Project_CK.View
{
    /// <summary>
    /// Interaction logic for BenhNhan.xaml
    /// </summary>
    public partial class BenhNhan : UserControl
    {

        DataBase.DataProcess dtBase = new DataBase.DataProcess();
        public BenhNhan()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            DataTable dt = dtBase.ReadData("Select * from tblBenhNhanCho");
            dtgBenhNhanCho.ItemsSource = dt.AsDataView();
            dtgBenhNhanCho_2.ItemsSource = dt.AsDataView();
        }


       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbbGTinhBN.Items.Add("Nam");
            cbbGTinhBN.Items.Add("Nữ");

            cbbChuyenKhoa.Items.Add("Khoa Khám Bệnh");
            cbbChuyenKhoa.Items.Add("Khoa Da Liễu");
            cbbChuyenKhoa.Items.Add("Khoa Nội Soi");
            cbbChuyenKhoa.Items.Add("Khoa Răng - Hàm - Mặt");

            cbbLoaiPhong.Items.Add("Vip");
            cbbLoaiPhong.Items.Add("Thường");

            cbbHuongDieuTri.Items.Add("Nhập Viện");
            cbbHuongDieuTri.Items.Add("Điều Trị Tại Nhà");

            cbbPhongKham.Items.Add("PK-01");
            cbbPhongKham.Items.Add("PK-02");
            cbbPhongKham.Items.Add("PK-03");

            LoadData();
            
        }
            

        void LamMoiBNDki()
        {
            txtMaBN.Clear();
            txtMaBN.IsEnabled = true;
            txtTenBN.Clear();
            txtDiaChiBN.Clear();
            txtNgSinh.Clear();
            txtNgSinh.Background = System.Windows.Media.Brushes.White;
            cbbGTinhBN.SelectedIndex = -1;
            txtBHYT.Clear();
            txtSDTBN.Clear();
            ImgBNDK.Source = null;

        }

        private bool IsNumber(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }
        public static bool IsAlphabetic(string input)
        {
 
            return Regex.IsMatch(input, @"^[a-zA-Z]+$");
        }
        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtBN = new DataTable();
            

            if(txtMaBN.Text == "" || txtTenBN.Text == "" || txtDiaChiBN.Text == "" ||txtNgSinh.Text == "" || cbbGTinhBN.Text == ""  || txtBHYT.Text == "" || txtSDTBN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaBN.Focus();
                return;
            }

            

            dtBN = dtBase.ReadData("Select * from tblBenhNhanCho where MaBN = '" + txtMaBN.Text + "'");

            if(dtBN.Rows.Count > 0 )
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaBN.Focus();
                return;
            }

            string gioiTinh = "";
            if (cbbGTinhBN.SelectedIndex == 0)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";

            if(!IsNumber(txtSDTBN.Text) || txtSDTBN.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtSDTBN.Focus();
                return;
            }
            
            dtBase.ChangeData("Insert into tblBenhNhanCho values('"+txtMaBN.Text+"','"+txtTenBN.Text+"','"+txtDiaChiBN.Text+"','"+gioiTinh+"','"+txtNgSinh.Text+ "','"+txtBHYT.Text+"','"+txtSDTBN.Text+"','"+imgBNDK+"')");
            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            LoadData();
            LamMoiBNDki();

        }
        string imgBNDK;
        string BHYTBN;
        string imgBNDK2;
        private void dtgBenhNhanCho_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dtr = (DataRowView)dtgBenhNhanCho_2.SelectedItem;

            if (dtr != null)
            {
                txtMaBNKham.Text = dtr[0].ToString();
                txtTenBN_Kham.Text = dtr[1].ToString();
                txtQueBN.Text = dtr[2].ToString();
                txtNgSinhBN.Text = dtr[4].ToString();
                if (dtr[3].ToString() == "Nam")
                    txtGTinhBN.Text = "Nam";
                else
                    txtGTinhBN.Text = "Nữ";
                
                txtSDTBNK.Text = dtr[6].ToString();
                BHYTBN = dtr[5].ToString();
                imgBNDK2 = dtr[7].ToString();
                ImgBNDK2.Source = new BitmapImage(new Uri(dtr[7].ToString()));

            }
        }


        void Clear_TT_DK()
        {
            txtMaBNKham.Clear();
            txtTenBN_Kham.Clear();
            txtGTinhBN.Clear();
            txtNgSinhBN.Clear();
            txtSDTBNK.Clear();
            txtQueBN.Clear();
            ImgBNDK2.Source = null;
            txtCanNang.Clear();
            txtHuyetAp.Clear();
            txtNhipTim.Clear();
            txtMach.Clear();
            txtLyDoKham.Clear();
            txtChuanDoan.Clear();
            cbbHuongDieuTri.SelectedIndex = -1;
            txtSoNgayNhapVien.Clear();
            cbbLoaiPhong.SelectedIndex = -1;
            cbbSoPhong.SelectedIndex = -1;
            cbbChuyenKhoa.SelectedIndex = -1;
            cbbMaBS.SelectedIndex = -1;
            cbbPhongKham.SelectedIndex = -1;
            dpNgayKham.Text = "";

        }

        private void cbbChuyenKhoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable dtBS = new DataTable();   
            dtBS = dtBase.ReadData("Select * from tblBacSi where ChuyenKhoa = '" + cbbChuyenKhoa.SelectedItem + "'");
            cbbMaBS.Items.Clear();
            foreach (DataRow row in dtBS.Rows)
            {
                string maBS = row["MaBS"].ToString();
                cbbMaBS.Items.Add(maBS);
            }
        }

        private void cbbLoaiPhong_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<String> vip = new List<String> {"R-Vip301","R-Vip302", "R-Vip303", "R-Vip304", "R-Vip305" };
            List<String> thuong = new List<String> { "R-Thuong201", "R-Thuong202", "R-Thuong203", "R-Thuong204", "R-Thuong205"};
           
            if(cbbLoaiPhong.SelectedIndex == 0)
            {
                cbbSoPhong.ItemsSource = vip;
            }else
                cbbSoPhong.ItemsSource= thuong;

        }

        private void btnLuuTT_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtBNDK = new DataTable();
            dtBNDK = dtBase.ReadData("Select * from tblBenhNhanDaKham where MaBN = '" + txtMaBNKham.Text + "'");

            if (!IsNumber(txtSoNgayNhapVien.Text))
            {
                MessageBox.Show("Số ngày nhập viện phải là số", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtSoNgayNhapVien.Focus();
                return;
            }

            if (dtBNDK.Rows.Count > 0)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if(cbbHuongDieuTri.SelectedIndex == 0)
            {
                dtBase.ChangeData("Insert into tblBenhNhanDaKham values('" + txtMaBNKham.Text + "','" + txtTenBN_Kham.Text + "','" + txtGTinhBN.Text + "','" + txtNgSinhBN.Text + "','" + txtSDTBNK.Text + "','"+BHYTBN+"','"+imgBNDK2+"'," +
                "'" + txtChuanDoan.Text + "','" + cbbHuongDieuTri.SelectedItem + "','" + txtSoNgayNhapVien.Text + "','" + cbbLoaiPhong.SelectedItem + "','" + cbbSoPhong.SelectedItem + "','" + cbbMaBS.SelectedItem + "','" + dpNgayKham.SelectedDate.ToString() + "')");
                dtBase.ChangeData("Insert into tblDuLieuBenhNhan values('" + txtMaBNKham.Text + "','" + txtTenBN_Kham.Text + "','" + txtGTinhBN.Text + "','" + txtNgSinhBN.Text + "','" + txtSDTBNK.Text + "','"+BHYTBN+"','" + imgBNDK2 + "'," +
                    "'" + txtChuanDoan.Text + "','" + cbbHuongDieuTri.SelectedItem + "','" + txtSoNgayNhapVien.Text + "','" + cbbLoaiPhong.SelectedItem + "','" + cbbSoPhong.SelectedItem + "','" + cbbMaBS.SelectedItem + "','" + dpNgayKham.SelectedDate.ToString() + "','" + "Đang Điều Trị" + "','"+"Chưa Thống Kê"+"')");
            }
            else
            {
              
                dtBase.ChangeData("Insert into tblDuLieuBenhNhan values('" + txtMaBNKham.Text + "','" + txtTenBN_Kham.Text + "','" + txtGTinhBN.Text + "','" + txtNgSinhBN.Text + "','" + txtSDTBNK.Text + "','"+BHYTBN+"','" + imgBNDK + "'," +
                    "'" + txtChuanDoan.Text + "','" + cbbHuongDieuTri.SelectedItem + "','" + "Không" + "','" + "Không" + "','" + "Không" + "','" + cbbMaBS.SelectedItem + "','" + dpNgayKham.SelectedDate.ToString() + "','" + "Khám Xong" + "','"+"500000"+"')");
            }

            
            MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            Delete(txtMaBNKham.Text);
            Clear_TT_DK();

        }

        private void Delete(string MaBN)
        {
            string strDelete = "DELETE FROM tblBenhNhanCho WHERE MaBN = ('" + MaBN + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dtgBenhNhanCho.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedMaBN = selectedRow["MaBN"].ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu có MaBN: " + selectedMaBN + "?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Delete(selectedMaBN);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            dtBase.ChangeData("update tblBenhNhanCho set Ten = '" + txtTenBN.Text + "',DiaChi = '" + txtDiaChiBN.Text + "',GioiTinh = '" + cbbGTinhBN.SelectedItem + "'," +
                "NgaySinh = '"+txtNgSinh.Text+"',BHYT = '"+txtBHYT.Text+"',SoDienThoai = '"+txtSDTBN.Text+"',AnhBN = '"+imgBNDK+"'  where MaBN = '" + txtMaBN.Text + "'");
            LoadData();
            txtMaBN.IsEnabled = true;
            MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void dtgBenhNhanCho_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dtr = (DataRowView)dtgBenhNhanCho.SelectedItem;
            if (dtr != null)
            {
                txtMaBN.Text = dtr[0].ToString();
                txtTenBN.Text = dtr[1].ToString();
                txtDiaChiBN.Text = dtr[2].ToString();
                cbbGTinhBN.Text = dtr[3].ToString();
                txtNgSinh.Text = dtr[4].ToString();
                txtBHYT.Text = dtr[5].ToString();
                txtSDTBN.Text = dtr[6].ToString();
                ImgBNDK.Source = new BitmapImage(new Uri(dtr[7].ToString()));
                txtMaBN.IsEnabled = false;
            }
        }

        private void btnLamMoiBNDki_Click(object sender, RoutedEventArgs e)
        {
            LamMoiBNDki();
        }

        private void btnTaiAnh_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDiaLog = new OpenFileDialog();
            openDiaLog.Filter = "Image files | *.bmp;*.jpg; *.png;*.jpng";
            openDiaLog.FilterIndex = 1;
            if (openDiaLog.ShowDialog() == true)
            {
                imgBNDK = openDiaLog.FileName;
                ImgBNDK.Source = new BitmapImage(new Uri(imgBNDK));
            }
        }

        private void txtNgSinh_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string input = textBox.Text;
            // tách chuỗi theo format dd/MM/yyyy
            string pattern = @"^(\d{1,2})/(\d{1,2})/(\d{4})$";

            if (Regex.IsMatch(input, pattern))
            {
                // Nếu đúng thì nền trắng
                textBox.Background = System.Windows.Media.Brushes.White; 
                string[] parts = input.Split('/');
                int day = int.Parse(parts[0]);
                int month = int.Parse(parts[1]);
                int year = int.Parse(parts[2]);

                if (day < 0 || day > 31 || month < 0 || month > 12)
                {
                    textBox.Background = System.Windows.Media.Brushes.LightPink;
                    
                }
               
            }
            else
            {
                
                textBox.Background = System.Windows.Media.Brushes.LightPink;
            }
        }
    }
}
