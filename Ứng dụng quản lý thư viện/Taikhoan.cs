using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            loadtaikhoan();
            hideDoiMatkhau();
            trangthaiAdmin();
        }

        private void trangthaiAdmin()
        {
            if (provider.kiemtraTaikhoanAdmin())
            {
                btnQLTK.Visible = true;
            }
        }

        private string idtaikhoan()
        {
            string sql = "select  top 1 * from LichsuDangnhap order by id desc";
            DataTable table = provider.Executequery(sql);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["idtaikhoan"].ToString();
            }
            else
            {
                return "";
            }
        }

        //String matkhau = null;
        private void loadtaikhoan()
        {
            string sql = "select displayname, username, userpass from taikhoan where id = '"+ idtaikhoan() +"'";
            DataTable table = provider.Executequery(sql);
            if(table.Rows.Count > 0)
            {
                lblDN.Text = table.Rows[0]["displayname"].ToString();
                txttaikhoan.Text = table.Rows[0]["username"].ToString();
                txtmatkhau.Text = provider.BinaryToString(table.Rows[0]["userpass"].ToString());
            }
        }
        
        private void hideDoiMatkhau()
        {
            tLPdoimatkhau.Width = 1;
        }

        private void visibleDoiMatkhau()
        {
            tLPdoimatkhau.Width = 580;
        }

        private void nhaplaiDoiMatkhau()
        {
            txtmatkhaumoi.Text = null;
            txtxacnhanmatkhau.Text = null;
        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            visibleDoiMatkhau();
        }

        private bool sosanhmatkhau()
        {
            if(txtmatkhaumoi.Text.Length > 0 && txtxacnhanmatkhau.Text.Length > 0
                && txtmatkhaumoi.Text.Equals(txtxacnhanmatkhau.Text)){
                return true;
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không tương thích!");
                return false;
            }
        }

        private void doiMatkhau()
        {
            string sql = "update taikhoan set userpass = '"+ provider.StringToBinary(txtxacnhanmatkhau.Text) +"' where id = '"+ idtaikhoan() +"'";
            provider.ExecuteNonquery(sql);
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (sosanhmatkhau())
            {
                txtmatkhau.Text = txtxacnhanmatkhau.Text;
                doiMatkhau();
                hideDoiMatkhau();
                nhaplaiDoiMatkhau();
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
        }

        private void btnHuyDoimatkhau_Click(object sender, EventArgs e)
        {
            nhaplaiDoiMatkhau();
            hideDoiMatkhau();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            m.OpenChildForm(new Quanlitaikhoan());
        }
    }
}
