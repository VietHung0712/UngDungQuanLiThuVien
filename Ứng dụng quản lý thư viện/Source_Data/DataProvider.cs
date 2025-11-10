using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Documents;

namespace Ứng_dụng_quản_lý_thư_viện.Source_Data
{
    public class DataProvider
    {
        private string str = @"Data Source=LAPTOP-C2HEVKMU\SQLEXPRESS;Initial Catalog=bookstore_db;Integrated Security=True;";

        public DataTable Executequery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                dataTable.Clear();
                adapter.Fill(dataTable);
                conn.Close();
                adapter.Dispose();
            }
            return dataTable;
        }

        public void ExecuteNonquery(string query)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
            }
        }

        public void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
            }
        }
        public SqlDataReader ExecuteReader(string query)
        {
            SqlDataReader reader = null;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            cmd.Dispose();
            return reader;
        }

        public Image ByteArrayToImage(byte[] b)
        {
            MemoryStream memoryStream = new MemoryStream(b);
            return Image.FromStream(memoryStream);
        }

        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public bool kiemtraID(String table, TextBox txt)
        {
            try
            {
                string sql = "SELECT * FROM "+table+" WHERE id = '" + txt.Text + "'";
                using (SqlDataReader reader = ExecuteReader(sql))
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("ID: " + txt.Text + " đã tồn tại! Hãy thử ID khác!");
                        txt.Text = null;
                        txt.Focus();
                    }
                    else
                    {
                        return true;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            return false;
        }

        public bool kiemtraIDsanco(String table, TextBox txt, String doituong)
        {
            string sql = "SELECT * FROM "+table+" WHERE id = '" + txt.Text + "'";
            try
            {
                using (SqlDataReader reader = ExecuteReader(sql))
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại " + doituong + " có ID này!");
                        txt.Text = null;
                        txt.Focus();
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
            return false;
        }

        public String SetGender(TextBox textBox)
        {
            if (textBox.Text.Equals("Nam", StringComparison.OrdinalIgnoreCase) || textBox.Text.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
            {
                return textBox.Text;
            }
            else
            {
                return "Khác";
            }
        }

        public void ClickOpenImage(PictureBox picImage, Form from)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = ".jpg|*.jpg";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(open.FileName);
                    from.Text = open.FileName;
                }
            }
            catch
            {
                picImage.Image = Properties.Resources.App;
            }
        }

        public string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in data)
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public string BinaryToString(string binary)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                try
                {
                    string byteString = binary.Substring(i, 8);
                    byteList.Add(Convert.ToByte(byteString, 2));
                }
                catch
                {
                    return binary;
                }
            }

            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public string idtaikhoan()
        {
            string sql = "select  top 1 * from LichsuDangnhap order by id desc";
            DataTable table = Executequery(sql);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["idtaikhoan"].ToString();
            }
            else
            {
                return "";
            }
        }
        public bool kiemtraTaikhoanAdmin()
        {
            string sql = "select * from taikhoan where administrator = 1 and id = " + idtaikhoan();
            DataTable table = Executequery(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
