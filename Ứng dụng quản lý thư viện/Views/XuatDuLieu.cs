using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Ứng_dụng_quản_lý_thư_viện
{
    public partial class XuatDuLieu : Form
    {
        public XuatDuLieu()
        {
            InitializeComponent();
            richTextBox.Text = textAuto();
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savedata = false;
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "txt|*.txt|All|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader f = new StreamReader(open.FileName);
                    richTextBox.Text = f.ReadToEnd();
                    f.Close();
                }
            }
            catch
            {

            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Text = null;
        }

        private bool savedata = false;
        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                
                
                if (save.ShowDialog() == DialogResult.OK)
                {
                    String fileName = save.FileName;
                    if (Path.GetExtension(fileName).ToLower() != ".txt" && string.IsNullOrEmpty(Path.GetExtension(fileName)))
                    {
                        fileName += ".txt";
                    }
                    using (StreamWriter f = new StreamWriter(fileName))
                    {
                        f.Write(richTextBox.Text);
                        f.Close();
                        savedata = true;
                    }

                }
            }
            catch
            {

            }
        }

        private String textAuto()
        {
            String text = "- - - BẢN BÁO CÁO - - -\n";
            
            return text;
        }

        private void Thoat()
        {
            
        }

        private void XuatDuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!savedata)
            {
                DialogResult rs = MessageBox.Show("Bạn chưa lưu dữ liệu vào tệp.\nBạn có muốn lưu lại không?", "Thông báo",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    saveData();
                }
            }
        }
    }
}
