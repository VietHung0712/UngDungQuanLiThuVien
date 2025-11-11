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
    public partial class LichSuDangNhap : Form
    {
        public LichSuDangNhap()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();
        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {
            lichsudangnhap();
        }

        private void lichsudangnhap()
        {
            string sql = "select*from lichsudangnhap order by id desc";
            dGV.DataSource = provider.Executequery(sql);

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGV.Columns[0].HeaderText = "Số thứ tự";
            dGV.Columns[1].HeaderText = "Mã tài khoản";
            dGV.Columns[2].HeaderText = "Thời gian";
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dGV.CurrentRow != null)
            {
                getTaikhoan();
            }
        }

        private void getTaikhoan()
        {
            string sql = "select id, displayname, username from taikhoan where id = '" +
                dGV.CurrentRow.Cells[1].Value.ToString() + "'";
            DataTable table = provider.Executequery(sql);
            if(table.Rows.Count > 0) {
                txtID.Text = table.Rows[0]["id"].ToString();
                txtName.Text = table.Rows[0]["displayname"].ToString();
                txttaikhoan.Text = table.Rows[0]["username"].ToString();
            }
        }
    }
}
