using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();
        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            Load_Sach();
        }
        private void LoadData(String query)
        {
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
            dGV.Columns[6].HeaderText = "Sô lượng";
            dGV.Columns[7].HeaderText = "Ảnh";
        }

        private void Load_Sach()
        {
            string query = "select * from SACH";
            LoadData(query);
        }

        private void TimKiem()
        {
            string query = "select * from SACH where tenSach LIKE N'%" + txtTimKiem.Text + "%' or " +
                "tacGia LIKE N'%" + txtTimKiem.Text + "%' or theLoai LIKE N'%" + txtTimKiem.Text + "%' ";
            LoadData(query);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text.Length > 0)
            {
                TimKiem();
                if (dGV.RowCount > 1)
                {
                    ChangeCellClick(0);
                }
            }
            else
            {
                Load_Sach();
            }
        }

        private void dgvTimKiemSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGV.CurrentCell.RowIndex;
            if( i < dGV.RowCount - 1)
            {
                ChangeCellClick(i);
            }
        }

        private void ChangeCellClick(int i)
        {
            txtID.Text = dGV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text = dGV.Rows[i].Cells[2].Value.ToString();
            txtTheLoai.Text = dGV.Rows[i].Cells[3].Value.ToString();
            txtNamXB.Text = dGV.Rows[i].Cells[4].Value.ToString();
            txtGiaBan.Text = dGV.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text = dGV.Rows[i].Cells[6].Value.ToString();
            try
            {
                picImage.Image = provider.ByteArrayToImage((byte[])dGV.Rows[i].Cells[7].Value);
            }
            catch
            {
                picImage.Image = Properties.Resources.App;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiSach quanLiSach = new QuanLiSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();

            m.OpenChildForm(quanLiSach);
        }
    }
}
