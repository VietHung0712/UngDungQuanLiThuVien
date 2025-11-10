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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Length == 0 && txtUserPass.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tài khoản và mật khẩu!");
            }
            else if(txtUserPass.Text.Length == 0) {
                MessageBox.Show("Chưa nhập mật khẩu!");
            }
            else if(txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Chưa nhập tài khoản!");
            }
            else
            {
                XacThucDangNhap();
            }
        }

        private void XacThucDangNhap()
        {
            DataProvider provider = new DataProvider();

            string idtaikhoan;
            string sql = "select*from TAIKHOAN where userName = '" + txtUserName.Text + "' and userPass = '" + provider.StringToBinary(txtUserPass.Text) + "'";

            SqlDataReader rd = provider.ExecuteReader(sql);
            DataTable table = provider.Executequery(sql);
            if (rd.Read())
            {
                idtaikhoan = table.Rows[0]["id"].ToString();

                string insert_lichsu = "insert into lichsudangnhap(idtaikhoan, thoigian) values " +
                    "('" + idtaikhoan + "', '" + (DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "')";

                provider.ExecuteNonQuery(insert_lichsu);

                Manager m = new Manager();
                this.Hide();
                m.ShowDialog();
                this.nhapLai();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        private void nhapLai()
        {
            txtUserName.Text = null;
            txtUserPass.Text = null;
        }

    }
}
