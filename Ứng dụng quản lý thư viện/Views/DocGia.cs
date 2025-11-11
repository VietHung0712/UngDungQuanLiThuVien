using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void DocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
            trangthaiAdmin();
        }

        private void trangthaiAdmin()
        {
            if (provider.kiemtraTaikhoanAdmin())
            {
                tlpControl.Visible = true;
            }
        }

        private void loadData(String sql)
        {
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "ID";
            dGV.Columns[1].HeaderText = "Họ và tên";
            dGV.Columns[2].HeaderText = "Giới tính";
            dGV.Columns[3].HeaderText = "Địa chỉ";
            dGV.Columns[4].HeaderText = "Số điện thoại";
            dGV.Columns[5].HeaderText = "Năm sinh";
            dGV.Columns[6].HeaderText = "Ảnh";
        }

        private void loadDocGia()
        {
            String sql = "select * from DocGia";
            loadData(sql);
        }

        private void pic_Click(object sender, EventArgs e)
        {
            provider.ClickOpenImage(pic, this);
        }


        private void ThemDOCGIA()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", txtID.Text },
                    { "@tenDG", txtTen.Text},
                    { "@gioiTinh", provider.SetGender(txtGioiTinh) },
                    { "@diaChi", txtDiaChi.Text },
                    { "@sdt", txtSDT.Text },
                    { "@namSinh", txtNamSinh.Text },
                    { "@anhDOCGIA", provider.ImageToByteArray(pic.Image) }
                };
                string insertQuery = "insert into DOCGIA values(@id, @tenDG, @gioiTinh, @diaChi, @sdt, @namSinh, @anhDOCGIA)";

                provider.ExecuteNonQuery(insertQuery, parameters);

                MessageBox.Show("Đã thêm thành công!");
                loadDocGia();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            NhapLai();
        }

        private void XoaDOCGIA()
        {

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa Độc Giả có ID: " + txtID.Text + " ?",
                " Thông báo!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //string query = @"delete SACH";
                string query = @"delete DOCGiA where id = '" + txtID.Text + "'";
                DataProvider provider = new DataProvider();
                provider.ExecuteNonquery(query);
                MessageBox.Show("Đã xóa thành công!                       ", "Thông báo!");
                loadDocGia();
            }
            NhapLai();
        }

        private void SuaDOCGIA()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@tenDG", txtTen.Text },
                    { "@gioiTinh", txtGioiTinh.Text },
                    { "@diaChi", txtDiaChi.Text },
                    { "@sdt", txtSDT.Text },
                    { "@namSinh", txtNamSinh.Text },
                    { "@anhDOCGIA", provider.ImageToByteArray(pic.Image) },
                    { "@id", txtID.Text }
                };
                string sql = "update DOCGIA set " +
                    "tenDG = @tenDG, " +
                    "gioiTinh = @gioiTinh, " +
                    "diaChi = @diaChi, " +
                    "sdt = @sdt, " +
                    "namSinh = @namSinh, " +
                    "anhDOCGIA = @anhDOCGIA " +
                    "where id = @id";

                provider.ExecuteNonQuery(sql, parameters);

                MessageBox.Show("Đã sửa thành công!");
                loadDocGia();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            NhapLai();
        }


        private void NhapLai()
        {
            txtID.Text = null;
            txtTen.Text = null;
            txtGioiTinh.Text = null;
            txtDiaChi.Text = null;
            txtDiaChi.Text = null;
            txtSDT.Text = null;
            txtNamSinh.Text = null;
            pic.Image = Properties.Resources.App;

            txtID.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (provider.kiemtraID("DOCGIA", txtID))
            {
                ThemDOCGIA();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaDOCGIA();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaDOCGIA();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            String sql = "select*from DOCGIA where tenDG LIKE N'%" + txtTimKiem.Text + "%' or diaChi LIKE N'%" + txtTimKiem.Text + "%' or sdt LIKE N'%" + txtTimKiem.Text + "%'";
            loadData(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String sql = "select*from DOCGIA where tenDG LIKE N'%" + txtTimKiem.Text + "%' or diaChi LIKE N'%" + txtTimKiem.Text + "%' or sdt LIKE N'%" + txtTimKiem.Text + "%'";
            loadData(sql);
        }

        private void btnSoThe_Click(object sender, EventArgs e)
        {
            TheThuVien ttv = new TheThuVien();
            Manager mn = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            mn.OpenChildForm(ttv);
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGV.CurrentCell.RowIndex;
            txtID.Text = dGV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = dGV.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dGV.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dGV.Rows[i].Cells[4].Value.ToString();
            txtNamSinh.Text = dGV.Rows[i].Cells[5].Value.ToString();
            try
            {
                pic.Image = provider.ByteArrayToImage((byte[])dGV.Rows[i].Cells[6].Value);
            }
            catch
            {
                pic.Image = Properties.Resources.App;
            }
        }
    }
}
