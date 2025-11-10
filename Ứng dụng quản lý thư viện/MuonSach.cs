using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;
using static System.Net.WebRequestMethods;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class MuonSach : Form
    {
        public MuonSach()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        int maximum = 100;

        private void MuonSach_Load(object sender, EventArgs e)
        {
            FomatDateTimePicker(dTPNgayMuon);
            loadPHIEUMUON();
            FomatDateTimePicker(dTPHanTra);
            loadDataTocomboBox(cBidsach, "sach");
            loadDataTocomboBox(cBiddocgia, "docgia");
            loadDataTocomboBox(cBidNhanvien, "nhanvien");
            trangthaiAdmin();

        }

        private void FomatDateTimePicker(DateTimePicker dTP)
        {
            dTP.Format = DateTimePickerFormat.Custom;
            dTP.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void trangthaiAdmin()
        {
            if (provider.kiemtraTaikhoanAdmin())
            {
                btnMuon.Visible = true;
                btnSua.Visible = true;
                btnSua.Visible = true;
                btnTra.Visible = true;
            }
        }

        private void loadData(string sql, DataGridView dGV)
        {
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "ID Phiếu mượn";
            dGV.Columns[1].HeaderText = "ID Sách";
            dGV.Columns[2].HeaderText = "ID Độc giả";
            dGV.Columns[3].HeaderText = "ID Nhân viên";
            dGV.Columns[4].HeaderText = "Số lượng";
            dGV.Columns[5].HeaderText = "Ngày mượn";
            dGV.Columns[6].HeaderText = "Hạn trả";
            dGV.Columns[7].HeaderText = "Ngày trả";
        }
        //------------------------------------------------------------------------------------

        private void nhapLaiMuon()
        {
            txtIDMuon.Text = null;
            cBiddocgia.SelectedIndex = 0;
            cBidNhanvien.SelectedIndex = 0;
            txtTenDG.Text = null;
            txtDiaChiDG.Text = null;
            txtSDTDG.Text = null;
            nUDMuon.Value = 0;
            cBidsach.SelectedIndex = 0;
            txtTenSach.Text = null;
            txtSoLuong.Text = null;
            txtGiaBan.Text = null;
            dTPNgayMuon.Value = DateTime.Now;
            dTPHanTra.Value = DateTime.Now;

            txtTimKiem.Text = null;
        }

        private void loadPHIEUMUON()
        {
            string sql = "select*from PHIEUMUON";
            loadData(sql, dGVMuon);
        }


        private void ThemPHIEUMUON()
        {

            try
            {
                string sqlMUONSACH = "UPDATE SACH SET soLuong -= @SoLuong WHERE id = @ID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@SoLuong", nUDMuon.Value },
                    { "@ID", cBidsach.Text }
                };
                provider.ExecuteNonQuery(sqlMUONSACH, parameters);

                string sql = "insert into PHIEUMUON values" +
                    "('" + txtIDMuon.Text + "', " +
                    "'" + cBidsach.Text + "', " + "'" + cBiddocgia.Text + "', " +
                    "'" + cBidNhanvien.Text + "', " + "'" + nUDMuon.Value + "', " +
                    "'" + dTPNgayMuon.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "'" + dTPHanTra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    "null)";


                provider.ExecuteNonQuery(sql);
                MessageBox.Show("Đã thêm thành công!");
                loadPHIEUMUON();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLaiMuon();
        }

        private void SuaPHIEUMUON()
        {
            try
            {
                string sql = "update PHIEUMUON set " +
                "idSACH = N'" + cBidsach.Text + "', " +
                "idDOCGIA = N'" + cBiddocgia.Text + "', " +
                "idNHANVIEN = N'" + cBidNhanvien.Text + "', " +
                "ngayMuon = '" + dTPNgayMuon.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                "hanTra = '" + dTPHanTra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                "where id = '" + txtIDMuon.Text + "'";

                provider.ExecuteNonQuery(sql);

                MessageBox.Show("Đã sửa thành công!");
                loadPHIEUMUON();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLaiMuon();
        }

        private bool kiemtraIDPHIEUMUON()
        {
            return provider.kiemtraID("PHIEUMUON", txtIDMuon);
        }
        private bool kiemtraSoluongMuon()
        {
            if (maximum == 0)
            {
                MessageBox.Show("Sách này đã hết!");
            }
            if (nUDMuon.Value > 0 && nUDMuon.Value <= maximum)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hãy chọn số lượng sách cần mượn hợp lệ!");
            }
            return false;
        }

        private bool kiemtraIDsach()
        {
            if (cBidsach.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sách");
                return false;
            }
            return true;
        }

        private bool kiemtraIDdocgia()
        {
            if (cBiddocgia.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn độc giả");
                return false;
            }
            return true;
        }

        private bool kiemtraIDnhanvien()
        {
            if (cBidNhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return false;
            }
            return true;
        }



        private void KiemTra_HienThi(String id, String table, String col1, String col2, String col3, TextBox txt1, TextBox txt2, TextBox txt3)
        {
            string sql = "SELECT " + col1 + ", " + col2 + ", " + col3 + " FROM " + table + " WHERE id = '" + id + "'";
            try
            {
                DataTable result = provider.Executequery(sql);

                if (result.Rows.Count > 0)
                {
                    txt1.Text = result.Rows[0][col1].ToString();
                    txt2.Text = result.Rows[0][col2].ToString();
                    txt3.Text = result.Rows[0][col3].ToString();
                }
                result.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
                nhapLaiMuon();
            }
        }

        private void KiemTrasoluongsach(ComboBox cb)
        {
            string sql = "SELECT soluong from sach where id = " + cb.Text;
            try
            {
                DataTable result = provider.Executequery(sql);

                if (result.Rows.Count > 0)
                {
                    maximum = (int)result.Rows[0]["soluong"];
                }
                result.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
                nhapLaiMuon();
            }
        }

        private void KiemTra_HienSach(String id)
        {
            KiemTra_HienThi(id, "SACH", "tenSach", "giaBan", "soLuong", txtTenSach, txtGiaBan, txtSoLuong);
        }

        private void KiemTra_HienDocGia(String id)
        {
            KiemTra_HienThi(id, "DOCGIA", "tenDG", "diaChi", "sdt", txtTenDG, txtDiaChiDG, txtSDTDG);
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtraIDPHIEUMUON() && kiemtraIDsach()
                && kiemtraIDdocgia() && kiemtraIDnhanvien()
                 && kiemtraSoluongMuon())
                {
                    ThemPHIEUMUON();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi nhập dữ liệu!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaPHIEUMUON();
        }

        private void btnHuyMuon_Click(object sender, EventArgs e)
        {
            nhapLaiMuon();
        }

        private void dGVMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVMuon.CurrentCell.RowIndex < dGVMuon.RowCount - 1)
            {
                txtIDMuon.Text = dGVMuon.CurrentRow.Cells[0].Value.ToString();
                cBidsach.Text = dGVMuon.CurrentRow.Cells[1].Value.ToString();
                KiemTra_HienSach(dGVMuon.CurrentRow.Cells[1].Value.ToString());
                cBiddocgia.Text = dGVMuon.CurrentRow.Cells[2].Value.ToString();
                KiemTra_HienDocGia(dGVMuon.CurrentRow.Cells[2].Value.ToString());
                cBidNhanvien.Text = dGVMuon.CurrentRow.Cells[3].Value.ToString();
                nUDMuon.Value = (int)dGVMuon.CurrentRow.Cells[4].Value;
                dTPNgayMuon.Value = (DateTime)dGVMuon.CurrentRow.Cells[5].Value;
                dTPHanTra.Value = (DateTime)dGVMuon.CurrentRow.Cells[6].Value;
            }
            else
            {
                nhapLaiMuon();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                string sql = "select*from PHIEUMUON where IDSACH LIKE '%" + txtTimKiem.Text + "%' " +
                "or IDDOCGIA LIKE '%" + txtTimKiem.Text + "%' " +
                "or IDNHANVIEN LIKE '%" + txtTimKiem.Text + "%' " +
                "or ngayMuon LIKE '%" + txtTimKiem.Text + "%' " +
                "or hanTra LIKE '%" + txtTimKiem.Text + "%'";
                loadData(sql, dGVMuon);
            }
            else
            {
                loadPHIEUMUON();
            }
        }

        public void loadDataTocomboBox(ComboBox cb, String table)
        {
            string sql = "SELECT id from " + table;
            try
            {
                DataTable result = provider.Executequery(sql);

                if (result.Rows.Count > 0)
                {
                    for (int i = 0; i < result.Rows.Count; i++)
                    {
                        String value = result.Rows[i]["id"].ToString();
                        cb.Items.Add(value);
                    }

                }
                result.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
        }

        private void cBidsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTra_HienSach(cBidsach.Text);
            KiemTrasoluongsach(cBidsach);
        }

        private void cBiddocgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            KiemTra_HienDocGia(cBiddocgia.Text);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            m.OpenChildForm(new MuonTra());
        }
    }
}
