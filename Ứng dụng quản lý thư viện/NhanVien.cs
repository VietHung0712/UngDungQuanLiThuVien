using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadNHANVIEN();
            trangthaiAdmin();
        }

        private void trangthaiAdmin()
        {
            if (provider.kiemtraTaikhoanAdmin())
            {
                tlpControl.Visible = true;
            }
        }

        private void LoadData(string sql)
        {
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "ID Nhân viên";
            dGV.Columns[1].HeaderText = "Họ tên";
            dGV.Columns[2].HeaderText = "Giới tính";
            dGV.Columns[3].HeaderText = "Địa chỉ";
            dGV.Columns[4].HeaderText = "Điện thoại";
            dGV.Columns[5].HeaderText = "Chức vụ";
            dGV.Columns[6].HeaderText = "Ảnh";
        }

        private void loadNHANVIEN()
        {
            string sql = "select*from NHANVIEN";
            LoadData(sql);
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentCell.RowIndex;
            if (i < dGV.RowCount - 1)
            {
                txtID.Text = dGV.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
                txtGioiTinh.Text = dGV.Rows[i].Cells[2].Value.ToString();
                txtDiaChi.Text = dGV.Rows[i].Cells[3].Value.ToString();
                txtDienThoai.Text = dGV.Rows[i].Cells[4].Value.ToString();
                txtChucVu.Text = dGV.Rows[i].Cells[5].Value.ToString();
                try
                {
                    picImage.Image = provider.ByteArrayToImage((byte[])dGV.Rows[i].Cells[6].Value);
                }
                catch
                {
                    picImage.Image = Properties.Resources.App;
                }
            }
        }

        private void nhapLai()
        {
            txtID.Text = null; txtTen.Text = null;
            txtDiaChi.Text = null; txtDienThoai.Text = null;
            txtChucVu.Text = null; txtGioiTinh.Text = null;
            picImage.Image = Properties.Resources.App;
        }

        private void ThemNHANVIEN()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", txtID.Text },
                    { "@tenNV", txtTen.Text },
                    { "@gioiTinh", provider.SetGender(txtGioiTinh) },
                    { "@diaChi", txtDiaChi.Text },
                    { "@sdt", txtDienThoai.Text },
                    { "@chucVu", txtChucVu.Text },
                    { "@anh", provider.ImageToByteArray(picImage.Image) }
                };
                string sql = "insert into NHANVIEN values(@id, @tenNV, @gioiTinh, @diaChi, @sdt, @chucVu, @anh)";


                provider.ExecuteNonQuery(sql, parameters);

                MessageBox.Show("Đã thêm thành công!");
                loadNHANVIEN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLai();
        }

        private void Xoa1NHANVIEN()
        {

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa ?",
                " Thông báo!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string query = @"delete NHANVIEN where id = '" + txtID.Text + "'";
                provider.ExecuteNonquery(query);
                MessageBox.Show("Đã xóa thành công!                       ", "Thông báo!");
                loadNHANVIEN();
            }
            nhapLai();
        }

        private void SuaNHANVIEN()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {

                    { "@tenNV", txtTen.Text },
                    { "@gioiTinh", provider.SetGender(txtGioiTinh) },
                    { "@diaChi", txtDiaChi.Text },
                    { "@sdt", txtDienThoai.Text },
                    { "@chucVu", txtChucVu.Text },
                    { "@anh", provider.ImageToByteArray(picImage.Image) },
                    { "@id", txtID.Text }
                };
                string sql = "update NHANVIEN set " +
                    "tenNV = @tenNV, " +
                    "gioiTinh = @gioiTinh, " +
                    "diaChi = @diaChi, " +
                    "sdt = @sdt, " +
                    "chucVu = @chucVu, " +
                    "anh = @anh " +
                    "where id = @id";

                provider.ExecuteNonQuery(sql, parameters);

                MessageBox.Show("Đã sửa thành công!");
                loadNHANVIEN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (provider.kiemtraID("NHANVIEN", txtID))
            {
                ThemNHANVIEN();
            }
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            provider.ClickOpenImage(picImage, this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaNHANVIEN();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa1NHANVIEN();
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            nhapLai();
        }
    }
}
