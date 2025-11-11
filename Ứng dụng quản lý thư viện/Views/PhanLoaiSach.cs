using System;
using System.Collections;
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
    public partial class PhanLoaiSach : Form
    {
        public PhanLoaiSach()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void PhanLoaiSach_Load(object sender, EventArgs e)
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

        private String phanLoai;

        private void cbPhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhanLoai.SelectedIndex == 0)
            {
                lbl_PhanLoai.Text = "Tác Giả";
                phanLoai = "tacGia";
            }
            else if (cbPhanLoai.SelectedIndex == 1)
            {
                lbl_PhanLoai.Text = "Thể Loại";
                phanLoai = "theLoai";
            }
            else if (cbPhanLoai.SelectedIndex == 2)
            {
                phanLoai = "namXB";
                lbl_PhanLoai.Text = "Năm Xuất Bản";
            }
            else if (cbPhanLoai.SelectedIndex == 3)
            {
                phanLoai = "giaBan";
                lbl_PhanLoai.Text = "Giá Bán";
            }
        }

        


        private void phanLoaiSach()
        {
            if(cbPhanLoai.SelectedIndex >= 0)
            {
                string query = "select * from SACH where " + phanLoai + " LIKE N'%" + txtPhanLoai.Text + "%' ";
                LoadData(query);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLiSach quanLiSach = new QuanLiSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();

            m.OpenChildForm(quanLiSach);
        }

        private void btnhanLoai_Click(object sender, EventArgs e)
        {
            phanLoaiSach();
        }

        private void txtPhanLoai_TextChanged(object sender, EventArgs e)
        {
            if(txtPhanLoai.Text.Length > 0)
            {
                phanLoaiSach();
            }
            else
            {
                Load_Sach();
            }
        }
    }
}
