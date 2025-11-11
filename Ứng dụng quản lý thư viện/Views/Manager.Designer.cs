namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class Manager
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuanLiSach = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnBCTK = new System.Windows.Forms.Button();
            this.btnTaikhoan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "MyLibrary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book - Document";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(645, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lí Thư Viện";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1408, 5);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1408, 80);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.App;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuanLiSach, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTrangChu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDocGia, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMuonTra, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNhanVien, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnBCTK, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnTaikhoan, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 723);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnQuanLiSach
            // 
            this.btnQuanLiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLiSach.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLiSach.FlatAppearance.BorderSize = 0;
            this.btnQuanLiSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnQuanLiSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuanLiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiSach.ForeColor = System.Drawing.Color.White;
            this.btnQuanLiSach.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.book_icon;
            this.btnQuanLiSach.Location = new System.Drawing.Point(3, 163);
            this.btnQuanLiSach.Name = "btnQuanLiSach";
            this.btnQuanLiSach.Size = new System.Drawing.Size(254, 74);
            this.btnQuanLiSach.TabIndex = 4;
            this.btnQuanLiSach.Text = "Quản Lí Sách";
            this.btnQuanLiSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLiSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLiSach.UseVisualStyleBackColor = false;
            this.btnQuanLiSach.Click += new System.EventHandler(this.btnQuanLiSach_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTrangChu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.home_icon;
            this.btnTrangChu.Location = new System.Drawing.Point(3, 83);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(254, 74);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDocGia.BackColor = System.Drawing.Color.Transparent;
            this.btnDocGia.FlatAppearance.BorderSize = 0;
            this.btnDocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.White;
            this.btnDocGia.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Reader;
            this.btnDocGia.Location = new System.Drawing.Point(3, 243);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(254, 74);
            this.btnDocGia.TabIndex = 5;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuonTra.BackColor = System.Drawing.Color.Transparent;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMuonTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.ForeColor = System.Drawing.Color.White;
            this.btnMuonTra.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.search_document;
            this.btnMuonTra.Location = new System.Drawing.Point(3, 323);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(254, 74);
            this.btnMuonTra.TabIndex = 6;
            this.btnMuonTra.Text = "Mượn - Trả";
            this.btnMuonTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuonTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMuonTra.UseVisualStyleBackColor = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Employee;
            this.btnNhanVien.Location = new System.Drawing.Point(3, 403);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(254, 74);
            this.btnNhanVien.TabIndex = 7;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnBCTK
            // 
            this.btnBCTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBCTK.BackColor = System.Drawing.Color.Transparent;
            this.btnBCTK.FlatAppearance.BorderSize = 0;
            this.btnBCTK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBCTK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBCTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBCTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCTK.ForeColor = System.Drawing.Color.White;
            this.btnBCTK.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.iconfinder_documents;
            this.btnBCTK.Location = new System.Drawing.Point(3, 483);
            this.btnBCTK.Name = "btnBCTK";
            this.btnBCTK.Size = new System.Drawing.Size(254, 74);
            this.btnBCTK.TabIndex = 8;
            this.btnBCTK.Text = "Báo cáo - Thống kê";
            this.btnBCTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBCTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBCTK.UseVisualStyleBackColor = false;
            this.btnBCTK.Click += new System.EventHandler(this.btnBCTK_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnTaikhoan.FlatAppearance.BorderSize = 0;
            this.btnTaikhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTaikhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaikhoan.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Account;
            this.btnTaikhoan.Location = new System.Drawing.Point(3, 563);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(254, 74);
            this.btnTaikhoan.TabIndex = 9;
            this.btnTaikhoan.Text = "Tài khoản";
            this.btnTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaikhoan.UseVisualStyleBackColor = false;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.lbl_Title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(260, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 40);
            this.panel3.TabIndex = 10;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(58, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(115, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Trang Chủ";
            // 
            // pnl_Body
            // 
            this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Body.BackColor = System.Drawing.Color.White;
            this.pnl_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Body.Location = new System.Drawing.Point(260, 113);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(1148, 692);
            this.pnl_Body.TabIndex = 7;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1408, 803);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.panel1);
            this.Name = "Manager";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnQuanLiSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnBCTK;
        private System.Windows.Forms.Button btnTaikhoan;
    }
}