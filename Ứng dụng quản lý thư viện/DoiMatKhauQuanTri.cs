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
    public partial class DoiMatKhauQuanTri : Form
    {
        public DoiMatKhauQuanTri()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void DoiMatKhauQuanTri_Load(object sender, EventArgs e)
        {
        }

        private String getMatKhauCu()
        {
            string sql = "select userpass from taikhoanquantri";
            try
            {
                DataTable table = new DataTable();
                table = provider.Executequery(sql);
                return provider.BinaryToString(table.Rows[0]["userpass"].ToString());
            }
            catch
            {
                return null;
            }
        }

        private bool KiemtraSosanhMatkhau()
        {
            if(txtmatkhaumoi.Text.Length>8 && txtnhaplaimatkhau.Text.Length > 8)
            {
                if (txtmatkhaumoi.Text.Equals(txtnhaplaimatkhau.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không tương thích!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu phải dài hơn 8 kí tự!");
            }
            return false;
        }

        private void doiMatKhau()
        {
            string sql = "update taikhoanquantri set userpass = '"+ provider.StringToBinary(txtnhaplaimatkhau.Text) +"'";
            provider.ExecuteNonquery(sql);
        }
        
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text.Equals(getMatKhauCu()))
            {
                if(KiemtraSosanhMatkhau())
                {
                    doiMatKhau();
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác!");
            }
        }
    }
}
