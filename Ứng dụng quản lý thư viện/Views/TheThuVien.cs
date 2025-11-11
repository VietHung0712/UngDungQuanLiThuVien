using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class TheThuVien : Form
    {
        public TheThuVien()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private bool setting = false;

        private void trangthaiAdmin()
        {
            if (provider.kiemtraTaikhoanAdmin())
            {
                btnUpdate.Visible = true;
            }
        }

        private void TheThuVien_Load(object sender, EventArgs e)
        {
            loadData();
            trangthaiAdmin();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!setting)
            {
                openSetting();
            }
            else
            {
                closeSetting();
            }
            setting = !setting;
        }

        private void openSetting()
        {
            tbpBtn.Visible = true;
            tbpWrite.Visible = true;
            btnUpdate.Text = "Hoàn tất";
            btnUpdate.Image = Properties.Resources.okay;
        }

        private void closeSetting()
        {
            tbpWrite.Visible = false;
            tbpBtn.Visible = false;
            btnUpdate.Text = "Thay đổi";
            btnUpdate.Image = Properties.Resources.Update;
        }

        private void loadData()
        {
            string sql = "select*from THEMUON Order by id";
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "Mã";
            dGV.Columns[1].HeaderText = "Tên độc giả";
            dGV.Columns[2].HeaderText = "Ngày cấp";
            dGV.Columns[3].HeaderText = "Ngày hết hạn";

        }

        private void nhapLai()
        {
            txtIDSet.Text = null;
            txtTenSet.Text = null;
            dTPNgayCap.Value = DateTime.Today;
            dTPNgayHetHan.Value = DateTime.Today;
            txtID.Text = null;
            txtTen.Text = null;
            txtNgayCap.Text = null;
            txtNgayHetHan.Text = null;
        }

        private bool kiemtraID_DOCGIA()
        {
            return provider.kiemtraIDsanco("DOCGIA", txtIDSet, "Độc giả");
        }

        private bool kiemtraID_THEMUON()
        {
            return provider.kiemtraID("THEMUON", txtIDSet);
        }


        private void ThemTHEMUON()
        {
            try
            {
                string sql = "insert into THEMUON values('" + txtIDSet.Text + "', " +
                    "N'" + txtTenSet.Text + "', " +
                    "'" + dTPNgayCap.Value.ToString("yyyy-MM-dd") + "', " +
                    "'" + dTPNgayHetHan.Value.ToString("yyyy-MM-dd") + "')";

                provider.ExecuteNonQuery(sql);

                MessageBox.Show("Đã thêm thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLai();
        }

        private void XoaTHEMUON()
        {

            try
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa Thẻ thư viện có ID: " + txtIDSet.Text + " ?",
                " Thông báo!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    //string query = @"delete SACH";
                    string query = @"delete THEMUON where id = '" + txtIDSet.Text + "'";
                    provider.ExecuteNonquery(query);
                    MessageBox.Show("Đã xóa thành công!                       ", "Thông báo!");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLai();
        }

        private void SuaTHEMUON()
        {
            try
            {
                string sql = "update THEMUON set " +
                "tenDG = N'" + txtTenSet.Text + "', " +
                "ngayCap = '" + dTPNgayCap.Value.ToString("yyyy-MM-dd") + "', " +
                "ngayHetHan = '" + dTPNgayHetHan.Value.ToString("yyyy-MM-dd") + "' " +
                "where id = '" + txtIDSet.Text + "'";

                provider.ExecuteNonQuery(sql);

                MessageBox.Show("Đã sửa thành công!");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhapLai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtraID_DOCGIA()&&kiemtraID_THEMUON())
            {
                ThemTHEMUON();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaTHEMUON();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaTHEMUON();
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGV.CurrentCell.RowIndex;
            if (i < dGV.RowCount - 1)
            {
                txtID.Text = dGV.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();


                txtIDSet.Text = dGV.Rows[i].Cells[0].Value.ToString();
                txtTenSet.Text = dGV.Rows[i].Cells[1].Value.ToString();

                try
                {
                    txtNgayCap.Text = ((DateTime)dGV.Rows[i].Cells[2].Value).ToString("dd/MM/yyyy");
                    txtNgayHetHan.Text = ((DateTime)dGV.Rows[i].Cells[3].Value).ToString("dd/MM/yyyy");
                    dTPNgayCap.Value = (DateTime)dGV.Rows[i].Cells[2].Value;
                    dTPNgayHetHan.Value = (DateTime)dGV.Rows[i].Cells[3].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + ex.ToString());
                }
            }
            else
            {
                nhapLai();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager mn = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            DocGia docGia = new DocGia();
            mn.OpenChildForm(docGia);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            nhapLai();
        }
    }
}
