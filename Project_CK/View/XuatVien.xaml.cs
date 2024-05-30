using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for XuatVien.xaml
    /// </summary>
    public partial class XuatVien : UserControl
    {
        public XuatVien()
        {
            InitializeComponent();
        }
        DataBase.DataProcess dtBase = new DataBase.DataProcess();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dtBN = new DataTable();
            dtBN = dtBase.ReadData("Select * from tblBenhNhanDaKham");
            cbbXVien.Items.Clear();
            foreach (DataRow row in dtBN.Rows)
            {
                string maBN = row["MaBN"].ToString();
                cbbXVien.Items.Add(maBN);
            }



        }

        void cleardt()
        {
            cbbXVien.SelectedIndex = -1;
            txtTenXV.Text = "";
            txtChuanDoanXV.Text = "";
            txtGTXV.Text = "";
            txtSDTXV.Text = "";
            ImgBN.Source = null;
            txtTongChiPhi.Text = "";
            txtTienPhong.Text = "";
            txtTienThuoc.Text = "";
            txtTienKham.Text = "";
        }
        private void cbbXVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LoadData();
            DataTable dtBN = new DataTable();
            dtBN = dtBase.ReadData("Select * from tblBenhNhanDaKham where MaBN = '" + cbbXVien.SelectedItem + "'");
            foreach (DataRow row in dtBN.Rows)
            {
                txtTenXV.Text = row["TenBN"].ToString();
                txtGTXV.Text = row["GioiTinh"].ToString();
                txtChuanDoanXV.Text = row["ChuanDoan"].ToString();
                txtSDTXV.Text = row["SoDienThoai"].ToString();
                ImgBN.Source = new BitmapImage(new Uri(row["AnhBN"].ToString()));

                if (row["BHYT"].ToString() != null)
                {
                    txtTienKham.Text = "500000";
                    if (row["LoaiPhong"].ToString() == "Vip")
                    {
                        txtTienPhong.Text = (Convert.ToInt32(row["SoNgayNhapVien"]) * 500000).ToString();
                    }
                    else
                    {
                        txtTienPhong.Text = (Convert.ToInt32(row["SoNgayNhapVien"]) * 200000).ToString();
                    }

                    int tienthuoc = Convert.ToInt32(row["SoNgayNhapVien"]) * 100000;
                    txtTienThuoc.Text = tienthuoc.ToString();
                    txtTongChiPhi.Text = (((Convert.ToInt32(row["SoNgayNhapVien"]) * 500000 + tienthuoc + 500000))/2) .ToString();
                }
                else
                {
                    txtTienKham.Text = "500000";
                    if (row["LoaiPhong"].ToString() == "Vip")
                    {
                        txtTienPhong.Text = (Convert.ToInt32(row["SoNgayNhapVien"]) * 500000).ToString();
                    }
                    else
                    {
                        txtTienPhong.Text = (Convert.ToInt32(row["SoNgayNhapVien"]) * 200000).ToString();
                    }

                    int tienthuoc = Convert.ToInt32(row["SoNgayNhapVien"]) * 100000;
                    txtTienThuoc.Text = tienthuoc.ToString();
                    txtTongChiPhi.Text = (Convert.ToInt32(row["SoNgayNhapVien"]) * 500000 + tienthuoc + 500000).ToString();
                }

                
               


            }
        }

        void LoadData()
        {
            DataTable dt = dtBase.ReadData("Select * from tblBenhNhanDaKham");
            DataTable dt2 = dtBase.ReadData("Select * from tblDuLieuBenhNhan");
        }

        private void Delete(string MaBN)
        {
            string strDelete = "DELETE FROM tblBenhNhanDaKham WHERE MaBN = ('" + MaBN + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void btnXuatVien_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Xuất Viện Thành Công !!!" +
                            "\n"+
                            "\n"+
                            "\n- Họ Tên: "+ txtTenXV.Text +
                            "\n- Chuẩn đoán: "+ txtChuanDoanXV.Text +
                            "\n- Tổng chi phí: "+ txtTongChiPhi.Text +
                            "\n- Ngày xuất viện:  " + DateTime.Now,
                            "Thông Báo"


                            );

            dtBase.ChangeData("update tblDuLieuBenhNhan set TrangThai = '" + "Đã Xuất Viện" + "',TongVienPhi = '"+txtTongChiPhi.Text+"' where MaBN = '" + cbbXVien.Text + "'");
            LoadData();

            Delete(cbbXVien.Text);
            cleardt();
        }
    }
}
