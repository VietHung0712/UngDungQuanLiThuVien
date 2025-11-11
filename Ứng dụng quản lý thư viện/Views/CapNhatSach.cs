using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class CapNhatSach : Form
    {
        public CapNhatSach()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void CapNhatSach_Load(object sender, EventArgs e)
        {
            Load_Sach();
            TrangThaiAdmin();
        }

        private void Load_Sach()
        {
            string query = "select*from SACH";
            dGV.DataSource = provider.Executequery(query);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dGV.Columns[0].HeaderText = "ID Sách";
            dGV.Columns[1].HeaderText = "Tên sách";
            dGV.Columns[2].HeaderText = "Tác giả";
            dGV.Columns[3].HeaderText = "Thể loại";
            dGV.Columns[4].HeaderText = "Năm xuất bản";
            dGV.Columns[5].HeaderText = "Giá bán";
            dGV.Columns[6].HeaderText = "Số lượng";
            dGV.Columns[7].HeaderText = "Ảnh";

        }

        private void TrangThaiAdmin()
        {
            if(provider.kiemtraTaikhoanAdmin())
            {
                btnThem.Visible = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;
                btnNhapLai.Visible = true;
            }
        }

        // --------------------------------------------------------------------
        private string AddStringTextBox(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.TextLength > 0)
            {
                return textBox.Text;
            }
            else
            {
                return "Chưa xác định";
            }
        }
        private void ThemSach()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@id", txtID.Text },
                    { "@tenSach", AddStringTextBox(txtTen) },
                    { "@tacGia", AddStringTextBox(txtTacGia) },
                    { "@theLoai", AddStringTextBox(txtTheLoai) },
                    { "@namXB", txtNamXB.Text },
                    { "@giaBan", txtGiaBan.Text },
                    { "@soLuong", nudSoLuong.Value },
                    { "@anhSach", provider.ImageToByteArray(picImage.Image) }
                };
                string sql = "insert into SACH values(@id, @tenSach, @tacGia, @theLoai, @namXB, @giaBan, @soLuong, @anhSach)";
                provider.ExecuteNonQuery(sql, parameters);

                MessageBox.Show("Đã thêm thành công!");
                Load_Sach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            NhapLai();
        }

        private void XoaSach()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa sách có ID: " + txtID.Text + " ?",
                " Thông báo!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                //string query = @"delete SACH";
                string query = @"delete SACH where id = '" + txtID.Text + "'";
                DataProvider provider = new DataProvider();
                provider.ExecuteNonquery(query);
                MessageBox.Show("Đã xóa thành công!                       ", "Thông báo!");
                Load_Sach() ;
            }
            NhapLai();
        }

        private void SuaSach()
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@tenSach", txtTen.Text },
                    { "@tacGia", txtTacGia.Text },
                    { "@theLoai", txtTheLoai.Text },
                    { "@namXB", txtNamXB.Text },
                    { "@giaBan", txtGiaBan.Text },
                    { "@soLuong", nudSoLuong.Value },
                    { "@anhSach", provider.ImageToByteArray(picImage.Image) },
                    { "@id", txtID.Text }
                };
                string sql = "update SACH set " +
                    "tenSach = @tenSach, " +
                    "tacGia = @tacGia, " +
                    "theLoai = @theLoai, " +
                    "namXB = @namXB, " +
                    "giaBan = @giaBan, " +
                    "soLuong = @soLuong, " +
                    "anhSach = @anhSach " +
                    "where id = @id";

                provider.ExecuteNonQuery(sql, parameters);

                MessageBox.Show("Đã sửa thành công!");
                Load_Sach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            NhapLai();
        }


        private void NhapLai()
        {
            txtID.Text = null;
            txtTen.Text = null;
            txtTacGia.Text = null;
            txtTheLoai.Text = null;
            txtNamXB.Text = null;
            txtGiaBan.Text = null;
            nudSoLuong.Value = 0;
            picImage.Image = Properties.Resources.App;

            txtID.Focus();
        }

        

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (provider.kiemtraID("SACH", txtID))
            {
                ThemSach();
            }
        }

        private void btnNhapLaiSach_Click(object sender, EventArgs e)
        {
            NhapLai();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            SuaSach();
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            XoaSach();
        }

        private void dGVCapNhatSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentCell.RowIndex;
            if (i < dGV.RowCount - 1)
            {
                txtID.Text = dGV.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
                txtTacGia.Text = dGV.Rows[i].Cells[2].Value.ToString();
                txtTheLoai.Text = dGV.Rows[i].Cells[3].Value.ToString();
                txtNamXB.Text = dGV.Rows[i].Cells[4].Value.ToString();
                txtGiaBan.Text = dGV.Rows[i].Cells[5].Value.ToString();
                nudSoLuong.Value = (int)dGV.Rows[i].Cells[6].Value;
                try
                {
                    picImage.Image = provider.ByteArrayToImage((byte[])dGV.Rows[i].Cells[7].Value);
                }
                catch
                {
                    picImage.Image = Properties.Resources.App;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiSach quanLiSach = new QuanLiSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            m.OpenChildForm(quanLiSach);
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            provider.ClickOpenImage(picImage, this);
        }
        
        
    }
}
