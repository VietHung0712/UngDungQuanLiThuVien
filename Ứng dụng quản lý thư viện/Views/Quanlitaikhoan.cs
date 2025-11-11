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
    public partial class Quanlitaikhoan : Form
    {
        public Quanlitaikhoan()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void Quanlitaikhoan_Load(object sender, EventArgs e)
        {
            loadTaikhoan();
        }

        private void loadTaikhoan()
        {
            string sql = "select* from taikhoan";
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "ID Tài khoản";
            dGV.Columns[1].HeaderText = "Tên hiển thị";
            dGV.Columns[2].HeaderText = "Tài khoản";
            dGV.Columns[3].HeaderText = "Mật khẩu";
            dGV.Columns[4].HeaderText = "Quyền quản trị";
        }

        private void nhapLai()
        {
            txtID.Text = null;
            txtName.Text = null;
            txttaikhoan.Text = null;
            txtmatkhau.Text = null;
        }

        private void themTaikhoan()
        {
            string sql = "INSERT INTO TAIKHOAN values('" +
                txtID.Text + "' , '"+ txtName.Text +"', '" +
                txttaikhoan.Text + "', '" +
                provider.StringToBinary(txtmatkhau.Text) + "', 0)";
            try
            {
                provider.ExecuteNonQuery(sql);
                MessageBox.Show("Đã thêm thành công!");
                nhapLai();
                loadTaikhoan();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (provider.kiemtraID("taikhoan",txtID))
            {
                themTaikhoan();
            }
        }

        private void suaTaikhoan()
        {
            string sql = "update TAIKHOAN set displayname = '" +
                txtName.Text + "', username = '" +
                txttaikhoan.Text + "', userpass = '" +
                provider.StringToBinary(txtmatkhau.Text) + "' where id = '" +
                txtID.Text + "'";
            try
            {
                provider.ExecuteNonQuery(sql);
                MessageBox.Show("Đã sửa thành công!");
                nhapLai();
                loadTaikhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGV.CurrentRow != null)
            {
                txtID.Text = dGV.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dGV.CurrentRow.Cells[1].Value.ToString();
                txttaikhoan.Text = dGV.CurrentRow.Cells[2].Value.ToString();
                txtmatkhau.Text = provider.BinaryToString(dGV.CurrentRow.Cells[3].Value.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaTaikhoan();
        }

        private void MTItemLS_Click(object sender, EventArgs e)
        {
            (new LichSuDangNhap()).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            m.OpenChildForm(new Taikhoan());
        }

        private void xoaTaiKhoan()
        {
            string sql = "delete taikhoan where id = '" + txtID.Text + "'";
            try
            {
                provider.ExecuteNonquery(sql);
                MessageBox.Show("Đã xóa thành công!");
                nhapLai();
                loadTaikhoan();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length > 0)
            {
                xoaTaiKhoan();
            }
        }

        private void btnNhaplai_Click(object sender, EventArgs e)
        {
            nhapLai();
        }

        private void MTItemMK_Click(object sender, EventArgs e)
        {
            (new DoiMatKhauQuanTri()).ShowDialog();
        }
    }
}
