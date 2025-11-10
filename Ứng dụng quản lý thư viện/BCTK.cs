using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class BCTK : Form
    {
        public BCTK()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void BCTK_Load(object sender, EventArgs e)
        {
            hienthibieudo();
            load_SachDocNhieuAlltime();
            load_SachDoanhThuAll();
        }

        private void hienthibieudo()
        {
            if (doanhthuthangcaonhat() != 0) // Đảm bảo không chia cho 0
            {
                try
                {
                    lblT1.Height = (int)Math.Round((doanhthutrong1thang(1) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT2.Height = (int)Math.Round((doanhthutrong1thang(2) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT3.Height = (int)Math.Round((doanhthutrong1thang(3) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT4.Height = (int)Math.Round((doanhthutrong1thang(4) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT5.Height = (int)Math.Round((doanhthutrong1thang(5) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT6.Height = (int)Math.Round((doanhthutrong1thang(6) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT7.Height = (int)Math.Round((doanhthutrong1thang(7) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT8.Height = (int)Math.Round((doanhthutrong1thang(8) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT9.Height = (int)Math.Round((doanhthutrong1thang(9) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT10.Height = (int)Math.Round((doanhthutrong1thang(10) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT11.Height = (int)Math.Round((doanhthutrong1thang(11) / doanhthuthangcaonhat()) * tLPDTNAM.Height);
                    lblT12.Height = (int)Math.Round((doanhthutrong1thang(12) / doanhthuthangcaonhat()) * tLPDTNAM.Height);

                    lblTongDoanhThu.Text = tongDoanhThuCaNam().ToString();

                    lblT1.Text = doanhthutrong1thang(1).ToString();
                    lblT2.Text = doanhthutrong1thang(2).ToString();
                    lblT3.Text = doanhthutrong1thang(3).ToString();
                    lblT4.Text = doanhthutrong1thang(4).ToString();
                    lblT5.Text = doanhthutrong1thang(5).ToString();
                    lblT6.Text = doanhthutrong1thang(6).ToString();
                    lblT7.Text = doanhthutrong1thang(7).ToString();
                    lblT8.Text = doanhthutrong1thang(8).ToString();
                    lblT9.Text = doanhthutrong1thang(9).ToString();
                    lblT10.Text = doanhthutrong1thang(10).ToString();
                    lblT11.Text = doanhthutrong1thang(11).ToString();
                    lblT12.Text = doanhthutrong1thang(12).ToString();
                }
                catch {
                    lblT1.Height = 1;
                    lblT2.Height = 1;
                    lblT3.Height = 1;
                    lblT4.Height = 1;
                    lblT5.Height = 1;
                    lblT6.Height = 1;
                    lblT7.Height = 1;
                    lblT8.Height = 1;
                    lblT9.Height = 1;
                    lblT10.Height = 1;
                    lblT11.Height = 1;
                    lblT12.Height = 1;
                }
            }
            else
            {
                lblT1.Height = 1;
                lblT2.Height = 1;
                lblT3.Height = 1;
                lblT4.Height = 1;
                lblT5.Height = 1;
                lblT6.Height = 1;
                lblT7.Height = 1;
                lblT8.Height = 1;
                lblT9.Height = 1;
                lblT10.Height = 1;
                lblT11.Height = 1;
                lblT12.Height = 1;
            }
        }


        private Double doanhthuthangcaonhat()
        {
            double i = 0;
            string sql = "SELECT MONTH(thoigian) AS Thang, SUM(loinhuan) AS DoanhThu " +
                                 "FROM HoaDon " +
                                 "WHERE YEAR(thoigian) = YEAR(GETDATE()) " +
                                 "GROUP BY MONTH(thoigian) " +
                                 "HAVING SUM(loinhuan) >= ALL ( " +
                                 "    SELECT SUM(loinhuan) " +
                                 "    FROM HoaDon " +
                                 "    WHERE YEAR(thoigian) = YEAR(GETDATE()) " +
                                 "    GROUP BY MONTH(thoigian) " +
                                 ")";
            try
            {
                DataTable result = provider.Executequery(sql);
                if (result.Rows.Count > 0)
                {
                    i = Convert.ToDouble(result.Rows[0]["DoanhThu"]);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error!" + ex.ToString());
            }
            return i;
        }

        private Double doanhthutrong1thang(int i)
        {
            double S = 0;
            string sql = "select sum(loinhuan) as Sloinhuan from HoaDon where month(thoigian) = '" + i + "'";
            try
            {
                DataTable result = provider.Executequery(sql);

                if (result.Rows.Count > 0)
                {
                    S = Convert.ToDouble(result.Rows[0]["Sloinhuan"]);
                }
            }
            catch (Exception ex)
            {
                S = 1;
            }
            return S;
        }

        private Double tongDoanhThuCaNam()
        {
            double S = 0;
            string sql = "select sum(loinhuan) as Sloinhuan from HoaDon where DATEDIFF(year,thoigian,getdate())=0";
            try
            {
                DataTable result = provider.Executequery(sql);

                if (result.Rows.Count > 0)
                {
                    S = Convert.ToDouble(result.Rows[0]["Sloinhuan"]);
                }
            }
            catch (Exception ex)
            {
                S = 1;
            }
            return S;
        }

        private void load_SachDocNhieu(String query)
        {
            dGVDocnhieu.DataSource = provider.Executequery(query);

            dGVDocnhieu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVDocnhieu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVDocnhieu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dGVDocnhieu.Columns[0].HeaderText = "ID Sách";
            dGVDocnhieu.Columns[1].HeaderText = "Tên sách";
            dGVDocnhieu.Columns[2].HeaderText = "Tổng số lượng";
        }

        private void load_SachDocNhieuAlltime()
        {
            string query = "SELECT top 5 s.id, tensach, SUM(h.soluong) AS TongSoLuongMuon FROM hoadon h JOIN sach s ON h.idsach = s.id GROUP BY s.id, tensach ORDER BY SUM(h.soluong) DESC";
            load_SachDocNhieu(query);
        }

        private void load_SachDocNhieuHomNay()
        {
            string query = "SELECT top 5 s.id, tensach, SUM(h.soluong) AS TongSoLuongMuon FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(Day,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.soluong) DESC";
            load_SachDocNhieu(query);
        }
        private void load_SachDocNhieutrongThang()
        {
            string query = "SELECT top 5 s.id, tensach, SUM(h.soluong) AS TongSoLuongMuon FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(MONTH,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.soluong) DESC";
            load_SachDocNhieu(query);
        }

        private void load_SachDocNhieuintrongNam()
        {
            string query = "SELECT top 5 s.id, tensach, SUM(h.soluong) AS TongSoLuongMuon FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(Year,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.soluong) DESC";
            load_SachDocNhieu(query);
        }

        private void cBDocnhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBDocnhieu.SelectedIndex == 0)
            {
                load_SachDocNhieuHomNay();
                dGVDocnhieu.BackgroundColor = Color.Blue;
            }
            else if (cBDocnhieu.SelectedIndex == 1)
            {
                load_SachDocNhieutrongThang();
                dGVDocnhieu.BackgroundColor = Color.Red;
            }
            else if (cBDocnhieu.SelectedIndex == 2)
            {
                load_SachDocNhieuintrongNam();
                dGVDocnhieu.BackgroundColor = Color.Green;
            }
            else if (cBDocnhieu.SelectedIndex == 3)
            {
                load_SachDocNhieuAlltime();
                dGVDocnhieu.BackgroundColor = Color.Black;
            }
        }

        private void load_SachDoanhThu(String query)
        {
            dGVDoanhThu.DataSource = provider.Executequery(query);

            dGVDoanhThu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGVDoanhThu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVDoanhThu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dGVDoanhThu.Columns[0].HeaderText = "ID Sách";
            dGVDoanhThu.Columns[1].HeaderText = "Tên sách";
            dGVDoanhThu.Columns[2].HeaderText = "Tổng doanh thu";
        }

        private void load_SachDoanhThuNgay()
        {
            String sql = "SELECT top 5 s.id, tensach, SUM(h.loinhuan) AS Tongloinhuan FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(day,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.loinhuan) DESC";
            load_SachDoanhThu(sql);
        }
        private void load_SachDoanhThuThang()
        {
            String sql = "SELECT top 5 s.id, tensach, SUM(h.loinhuan) AS Tongloinhuan FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(month,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.loinhuan) DESC";
            load_SachDoanhThu(sql);
        }
        private void load_SachDoanhThuNam()
        {
            String sql = "SELECT top 5 s.id, tensach, SUM(h.loinhuan) AS Tongloinhuan FROM hoadon h JOIN sach s ON h.idsach = s.id where DATEDIFF(year,thoigian,getdate())=0 GROUP BY s.id, tensach ORDER BY SUM(h.loinhuan) DESC";
            load_SachDoanhThu(sql);
        }
        private void load_SachDoanhThuAll()
        {
            String sql = "SELECT top 5 s.id, tensach, SUM(h.loinhuan) AS Tongloinhuan FROM hoadon h JOIN sach s ON h.idsach = s.id GROUP BY s.id, tensach ORDER BY SUM(h.loinhuan) DESC";
            load_SachDoanhThu(sql);
        }

        private void CbDoanhthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbDoanhthu.SelectedIndex == 0)
            {
                load_SachDoanhThuNgay();
                dGVDoanhThu.BackgroundColor = Color.Blue;
            }
            else if (CbDoanhthu.SelectedIndex == 1)
            {
                load_SachDoanhThuThang();
                dGVDoanhThu.BackgroundColor = Color.Red;
            }
            else if (CbDoanhthu.SelectedIndex == 2)
            {
                load_SachDoanhThuNam();
                dGVDoanhThu.BackgroundColor = Color.Green;
            }
            else if (CbDoanhthu.SelectedIndex == 3)
            {
                load_SachDoanhThuAll();
                dGVDoanhThu.BackgroundColor = Color.Black;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            (new XuatDuLieu()).ShowDialog();
        }
    }
}
