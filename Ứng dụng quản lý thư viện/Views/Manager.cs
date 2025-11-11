using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Body.Controls.Add(childForm);
            pnl_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Button selectedButton = null;
        private void ChangeButtonColor(Button button)
        {
            if (selectedButton != null && selectedButton != button)
            {
                selectedButton.BackColor = Color.Transparent;
            }

            button.BackColor = Color.DarkTurquoise;
            selectedButton = button;
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu());
            ChangeButtonColor(btnTrangChu);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnTrangChu);
            OpenChildForm(new TrangChu());
            lbl_Title.Text = "Trang Chủ";
        }

        private void btnQuanLiSach_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnQuanLiSach);
            OpenChildForm(new QuanLiSach());
            lbl_Title.Text = "Quản Lí Sách";
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnDocGia);
            OpenChildForm(new DocGia());
            lbl_Title.Text = "Độc Giả";
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnMuonTra);
            OpenChildForm(new MuonSach());
            lbl_Title.Text = "Mượn - Trả";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnNhanVien);
            OpenChildForm(new NhanVien());
            lbl_Title.Text = "Nhân Viên";
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnBCTK);
            OpenChildForm(new BCTK());
            lbl_Title.Text = "Báo cáo - Thống kê";
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(btnTaikhoan);
            OpenChildForm(new Taikhoan());
            lbl_Title.Text = "Tài khoản";
        }

        private void Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
