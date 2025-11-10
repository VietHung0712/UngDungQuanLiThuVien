namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class Taikhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDN = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtxacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.lblmatkhau1 = new System.Windows.Forms.Label();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btnHuyDoimatkhau = new System.Windows.Forms.Button();
            this.tLPdoimatkhau = new System.Windows.Forms.TableLayoutPanel();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tLPdoimatkhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDN
            // 
            this.lblDN.BackColor = System.Drawing.Color.Teal;
            this.lblDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDN.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.ForeColor = System.Drawing.Color.White;
            this.lblDN.Location = new System.Drawing.Point(0, 72);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(1130, 143);
            this.lblDN.TabIndex = 0;
            this.lblDN.Text = "DISPLAY NAME";
            this.lblDN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txttaikhoan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtmatkhau, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btndoimatkhau, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 215);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 488);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 97);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttaikhoan.Location = new System.Drawing.Point(252, 130);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.ReadOnly = true;
            this.txttaikhoan.Size = new System.Drawing.Size(335, 30);
            this.txttaikhoan.TabIndex = 2;
            this.txttaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 97);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtmatkhau.Location = new System.Drawing.Point(252, 227);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.ReadOnly = true;
            this.txtmatkhau.Size = new System.Drawing.Size(335, 30);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btndoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btndoimatkhau.Location = new System.Drawing.Point(252, 294);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(180, 46);
            this.btndoimatkhau.TabIndex = 5;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = false;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQLTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 72);
            this.panel1.TabIndex = 2;
            // 
            // btnQLTK
            // 
            this.btnQLTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLTK.BackColor = System.Drawing.Color.Yellow;
            this.btnQLTK.FlatAppearance.BorderSize = 0;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.Location = new System.Drawing.Point(911, 12);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(216, 50);
            this.btnQLTK.TabIndex = 0;
            this.btnQLTK.Text = "Quản lí tài khoản";
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Visible = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtmatkhaumoi.Location = new System.Drawing.Point(218, 130);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(230, 30);
            this.txtmatkhaumoi.TabIndex = 6;
            this.txtmatkhaumoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtxacnhanmatkhau
            // 
            this.txtxacnhanmatkhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtxacnhanmatkhau.Location = new System.Drawing.Point(218, 227);
            this.txtxacnhanmatkhau.Name = "txtxacnhanmatkhau";
            this.txtxacnhanmatkhau.Size = new System.Drawing.Size(230, 30);
            this.txtxacnhanmatkhau.TabIndex = 7;
            this.txtxacnhanmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblmatkhau1
            // 
            this.lblmatkhau1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmatkhau1.ForeColor = System.Drawing.Color.Black;
            this.lblmatkhau1.Location = new System.Drawing.Point(3, 194);
            this.lblmatkhau1.Name = "lblmatkhau1";
            this.lblmatkhau1.Size = new System.Drawing.Size(209, 97);
            this.lblmatkhau1.TabIndex = 9;
            this.lblmatkhau1.Text = "Xác nhận mật khẩu";
            this.lblmatkhau1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnxacnhan.ForeColor = System.Drawing.Color.White;
            this.btnxacnhan.Location = new System.Drawing.Point(218, 294);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(180, 46);
            this.btnxacnhan.TabIndex = 10;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = false;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // btnHuyDoimatkhau
            // 
            this.btnHuyDoimatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuyDoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btnHuyDoimatkhau.Location = new System.Drawing.Point(218, 391);
            this.btnHuyDoimatkhau.Name = "btnHuyDoimatkhau";
            this.btnHuyDoimatkhau.Size = new System.Drawing.Size(180, 46);
            this.btnHuyDoimatkhau.TabIndex = 11;
            this.btnHuyDoimatkhau.Text = "Hủy";
            this.btnHuyDoimatkhau.UseVisualStyleBackColor = false;
            this.btnHuyDoimatkhau.Click += new System.EventHandler(this.btnHuyDoimatkhau_Click);
            // 
            // tLPdoimatkhau
            // 
            this.tLPdoimatkhau.ColumnCount = 2;
            this.tLPdoimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.49012F));
            this.tLPdoimatkhau.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.50988F));
            this.tLPdoimatkhau.Controls.Add(this.lblmatkhau, 0, 1);
            this.tLPdoimatkhau.Controls.Add(this.txtmatkhaumoi, 1, 1);
            this.tLPdoimatkhau.Controls.Add(this.txtxacnhanmatkhau, 1, 2);
            this.tLPdoimatkhau.Controls.Add(this.lblmatkhau1, 0, 2);
            this.tLPdoimatkhau.Controls.Add(this.btnHuyDoimatkhau, 1, 4);
            this.tLPdoimatkhau.Controls.Add(this.btnxacnhan, 1, 3);
            this.tLPdoimatkhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.tLPdoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLPdoimatkhau.Location = new System.Drawing.Point(624, 215);
            this.tLPdoimatkhau.Name = "tLPdoimatkhau";
            this.tLPdoimatkhau.RowCount = 5;
            this.tLPdoimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPdoimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPdoimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPdoimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPdoimatkhau.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPdoimatkhau.Size = new System.Drawing.Size(506, 488);
            this.tLPdoimatkhau.TabIndex = 3;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmatkhau.ForeColor = System.Drawing.Color.Black;
            this.lblmatkhau.Location = new System.Drawing.Point(3, 97);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(209, 97);
            this.lblmatkhau.TabIndex = 9;
            this.lblmatkhau.Text = "Mật khẩu mới";
            this.lblmatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tLPdoimatkhau);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.panel1);
            this.Name = "Taikhoan";
            this.Text = "Taikhoan";
            this.Load += new System.EventHandler(this.Taikhoan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tLPdoimatkhau.ResumeLayout(false);
            this.tLPdoimatkhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.TextBox txtxacnhanmatkhau;
        private System.Windows.Forms.Label lblmatkhau1;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnHuyDoimatkhau;
        private System.Windows.Forms.TableLayoutPanel tLPdoimatkhau;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Button btnQLTK;
    }
}