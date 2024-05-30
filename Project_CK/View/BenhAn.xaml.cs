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
    /// Interaction logic for BenhAn.xaml
    /// </summary>
    public partial class BenhAn : UserControl
    {
        public BenhAn()
        {
            InitializeComponent();
        }

        DataBase.DataProcess dtBase = new DataBase.DataProcess();

        void LoadData()
        {
            cbbTim.Items.Add("Mã BN");
            cbbTim.Items.Add("Tên BN");


            DataTable dt = dtBase.ReadData("Select * from tblBenhNhanDaKham");
            dtgHoSo.ItemsSource = dt.AsDataView();

            DataTable dtDL = dtBase.ReadData("Select * from tblDuLieuBenhNhan");
            dtgDuLieuBenhNhan.ItemsSource = dtDL.AsDataView();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void dtgHoSo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dtr = (DataRowView)dtgHoSo.SelectedItem;

            if (dtr != null)
            {

                ImgBN.Source = new BitmapImage(new Uri(dtr[6].ToString()));

            }
        }


        private void Delete(string MaBN)
        {
            string strDelete = "DELETE FROM tblDuLieuBenhNhan WHERE MaBN = ('" + MaBN + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";

            if (cbbTim.SelectedIndex == 0)
            {
                sql = "Select * from tblDuLieuBenhNhan where MaBN is not null";
                sql = sql + " and MaBN like '%" + txtTim.Text + "%'";
                DataTable dtTimKiem = dtBase.ReadData(sql);
                dtgDuLieuBenhNhan.ItemsSource = dtTimKiem.AsDataView();

            }
            else
            {
                sql = "Select * from tblDuLieuBenhNhan where TenBN is not null";
                sql = sql + " and TenBN like '%" + txtTim.Text + "%'";
                DataTable dtTimKiem = dtBase.ReadData(sql);
                dtgDuLieuBenhNhan.ItemsSource = dtTimKiem.AsDataView();
            }
        }

        private void dtgDuLieuBenhNhan_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dtr = (DataRowView)dtgDuLieuBenhNhan.SelectedItem;

            if (dtr != null)
            {

                ImgDLBN.Source = new BitmapImage(new Uri(dtr[6].ToString()));

            }
        }

        private void btnTaiLai_Click(object sender, RoutedEventArgs e)
        {
            string sql = "Select * from tblDuLieuBenhNhan";
            DataTable dtTimKiem = dtBase.ReadData(sql);
            dtgDuLieuBenhNhan.ItemsSource = dtTimKiem.AsDataView();
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";

            
                sql = "Select * from tblBenhNhanDaKham where MaBN is not null";
                sql = sql + " and MaBN like '%" + txtTimKiem.Text + "%'";
                DataTable dtTimKiem = dtBase.ReadData(sql);
                dtgHoSo.ItemsSource = dtTimKiem.AsDataView();
           

        }

        private void btnRL_Click(object sender, RoutedEventArgs e)
        {
            string sql = "Select * from tblBenhNhanDaKham";
            DataTable dtTimKiem = dtBase.ReadData(sql);
            dtgHoSo.ItemsSource = dtTimKiem.AsDataView();
        }

      

        

      

        private void btnDeleted_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dtgDuLieuBenhNhan.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedMaBN = selectedRow["MaBN"].ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu có mã " + selectedMaBN + "?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Delete(selectedMaBN);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnFixBA_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dtgDuLieuBenhNhan.SelectedItem as DataRowView;
            if (selectedRow != null)
            {


                dtBase.ChangeData("update tblDuLieuBenhNhan set TenBN = '" + selectedRow["TenBN"].ToString() + "',NgaySinh = '"+ selectedRow["NgaySinh"].ToString() + "',SoDienThoai = '"+ selectedRow["SoDienThoai"].ToString() + "'," +
                    " ChuanDoan = '"+ selectedRow["ChuanDoan"].ToString() + "'  where MaBN = '" + selectedRow["MaBN"].ToString() + "' ");
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
