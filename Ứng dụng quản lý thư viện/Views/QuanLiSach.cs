using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ứng_dụng_quản_lý_thư_viện.Properties;
using Ứng_dụng_quản_lý_thư_viện.Source_Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class QuanLiSach : Form
    {
        public QuanLiSach()
        {
            InitializeComponent();
        }

        private void QuanLiSach_Load(object sender, EventArgs e)
        {

        }

        // -------------------------------------------------------------------------------------

        private void Hoverbutton(PictureBox pic)
        {
            pic.Location = new System.Drawing.Point(pic.Location.X, 20);
        }

        private void Leavebutton(PictureBox pic)
        {
            pic.Location = new System.Drawing.Point(pic.Location.X, 70);
        }

        private void btnCapNhatSach_Click(object sender, EventArgs e)
        {
            CapNhatSach capNhatSach = new CapNhatSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();

            m.OpenChildForm(capNhatSach);

        }

        private void btnPhanLoaiSach_Click(object sender, EventArgs e)
        {
            PhanLoaiSach phanLoaiSach = new PhanLoaiSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();

            m.OpenChildForm(phanLoaiSach);
        }

        private void btnCapNhatSach_MouseHover(object sender, EventArgs e)
        {
            Hoverbutton(picCapNhatSach);
        }

        private void btnCapNhatSach_MouseLeave(object sender, EventArgs e)
        {
            Leavebutton(picCapNhatSach);
        }

        private void btnPhanLoaiSach_MouseHover(object sender, EventArgs e)
        {
            Hoverbutton(picPhanLoaiSach);
        }

        private void btnPhanLoaiSach_MouseLeave(object sender, EventArgs e)
        {
            Leavebutton(picPhanLoaiSach);
        }

        private void btnTimKiemSach_MouseHover(object sender, EventArgs e)
        {
            Hoverbutton(picTimKiemSach);
        }

        private void btnTimKiemSach_MouseLeave(object sender, EventArgs e)
        {
            Leavebutton(picTimKiemSach);
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            TimKiemSach timKiemSach = new TimKiemSach();
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();

            m.OpenChildForm(timKiemSach);
        }

        // --------------------------------------------------------------------------------------------

    }
}
