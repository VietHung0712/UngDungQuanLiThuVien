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
    public partial class MuonTra : Form
    {
        public MuonTra()
        {
            InitializeComponent();
        }

        private DataProvider provider = new DataProvider();

        private void MuonTra_Load(object sender, EventArgs e)
        {
            loadTra();
            FomatDateTimePicker(dTPNgayTra);
            if (dGVTra.RowCount == 1)
            {
                MessageBox.Show("Không có sách chưa trả!\nHãy quay lại sau!", "Thông báo");
            }
        }

        private void FomatDateTimePicker(DateTimePicker dTP)
        {
            dTP.Format = DateTimePickerFormat.Custom;
            dTP.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private bool kiemtraTra = false;

        //-----------------------------------------------------------------------------------

        private void loadTra()
        {
            String sql = "select*from PHIEUMUON where ngayTra is null";
            dGVTra.DataSource = provider.Executequery(sql);

            dGVTra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVTra.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dGVTra.Columns[0].HeaderText = "ID Phiếu mượn";
            dGVTra.Columns[1].HeaderText = "ID Sách";
            dGVTra.Columns[2].HeaderText = "ID Độc giả";
            dGVTra.Columns[3].HeaderText = "ID Nhân viên";
            dGVTra.Columns[4].HeaderText = "Số lượng";
            dGVTra.Columns[5].HeaderText = "Ngày mượn";
            dGVTra.Columns[6].HeaderText = "Hạn trả";
            dGVTra.Columns[7].HeaderText = "Ngày trả";
        }

        private void nhaplaitra()
        {
            txtIDTra.Text = null;
            lblChiPhi.Text = "0";
            lblTrangThai.Text = "___";
            lblQuaHan.Visible = false;
            dTPNgayTra.Value = DateTime.Now;
        }

        private void XacNhanTraPHIEUMUON()
        {
            try
            {
                string sql = "update PHIEUMUON set " +
                "ngayTra = '" + dTPNgayTra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                "where id = '" + txtIDTra.Text + "'";

                string sqlTRASACH = "update SACH set soLuong = soLuong +" + dGVTra.CurrentRow.Cells[4].Value.ToString() + " where id = '" + dGVTra.CurrentRow.Cells[1].Value.ToString() + "'";

                string sqlHOADON = "insert into HoaDon(idsach, iddocgia, thoigian, soluong, loinhuan) values('" + dGVTra.CurrentRow.Cells[1].Value + "', '" + dGVTra.CurrentRow.Cells[2].Value + "', '" +
                    dTPNgayTra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '"+ dGVTra.CurrentRow.Cells[4].Value.ToString() +"', '"+
                    ChiPhiThanhToan(dGVTra.CurrentRow.Cells[0].Value.ToString(), dGVTra.CurrentRow.Cells[1].Value.ToString()).ToString() + "')";

                provider.ExecuteNonQuery(sql);
                provider.ExecuteNonQuery(sqlTRASACH);
                provider.ExecuteNonQuery(sqlHOADON);

                MessageBox.Show("Đã trả thành công!");
                loadTra();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
            }
            nhaplaitra();
        }

        private bool kiemtraQuaHan(String id)
        {
            string sql = "SELECT * from PHIEUMUON where id = '" + id + "' and '" + dTPNgayTra.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' between ngayMuon and hanTra";
            try
            {
                DataTable result = provider.Executequery(sql);
                if (result.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
                nhaplaitra();
                return false;
            }
        }

        private double getSoLuongMuon()
        {
            if(dGVTra.CurrentRow != null)
            {
                return Convert.ToDouble(dGVTra.CurrentRow.Cells[4].Value);
            }
            return 0;
        }

        private float getGiaBanSach(String id)
        {
            float gia = 0;
            string sql = "SELECT giaBan FROM SACH WHERE id = '" + id + "'";
            try
            {
                DataTable result = provider.Executequery(sql);
                if (result.Rows.Count > 0)
                {
                    gia = Convert.ToSingle(result.Rows[0]["giaBan"]);
                }
                result.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.ToString());
                nhaplaitra();
            }
            return gia;
        }

        private float ChiPhiThanhToan(string id, string idSach)
        {
            if (kiemtraQuaHan(id))
            {
                return (float)(getGiaBanSach(idSach) * 0.07 * getSoLuongMuon());
            }
            else
            {
                return (float)(getGiaBanSach(idSach) * 0.05 * getSoLuongMuon());
            }
        }

        private void dGVTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVTra.CurrentCell.RowIndex;
            if (i < dGVTra.RowCount - 1)
            {
                txtIDTra.Text = dGVTra.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                nhaplaitra();
            }
        }

        

        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIDTra.Text.Length > 0)
                {
                    kiemtraTra = true;
                    lblChiPhi.Text = ChiPhiThanhToan(dGVTra.CurrentRow.Cells[0].Value.ToString(), dGVTra.CurrentRow.Cells[1].Value.ToString()).ToString();
                    if (kiemtraQuaHan(dGVTra.CurrentRow.Cells[0].Value.ToString()))
                    {
                        lblQuaHan.Visible = true;
                        lblTrangThai.Text = "Quá hạn";
                    }
                    else
                    {
                        lblQuaHan.Visible = false;
                        lblTrangThai.Text = "Đúng hạn";
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn phiếu mượn trước!", "Thông báo");
                }
            }
            catch {
                
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemtraTra)
            {
                XacNhanTraPHIEUMUON();
                kiemtraTra = false;
            }
            else
            {
                MessageBox.Show("Hãy chọn `Trả` trước để kiểm tra!", "Thông báo");
            }
        }

        private void btnHuyTra_Click(object sender, EventArgs e)
        {
            nhaplaitra();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Manager m = Application.OpenForms.OfType<Manager>().FirstOrDefault();
            m.OpenChildForm(new MuonSach());
        }

        private void txtIDTra_TextChanged(object sender, EventArgs e)
        {
            kiemtraTra = false;
        }

        private void dTPNgayTra_ValueChanged(object sender, EventArgs e)
        {
            kiemtraTra = false;
        }
    }
}
