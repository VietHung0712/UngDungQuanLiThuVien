namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class TimKiemSach
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Cancel;
            this.button1.Location = new System.Drawing.Point(970, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Quay Lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.tlpTimKiem);
            this.panel1.Controls.Add(this.dGV);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 579);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtSoLuong, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtGiaBan, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNamXB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTheLoai, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTacGia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(776, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 224);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(3, 189);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(334, 27);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.Text = "Số lượng";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(3, 158);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(334, 27);
            this.txtGiaBan.TabIndex = 6;
            this.txtGiaBan.Text = "Giá bán";
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(3, 127);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.ReadOnly = true;
            this.txtNamXB.Size = new System.Drawing.Size(334, 27);
            this.txtNamXB.TabIndex = 5;
            this.txtNamXB.Text = "Nắm xuất bản";
            this.txtNamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(3, 96);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.Size = new System.Drawing.Size(334, 27);
            this.txtTheLoai.TabIndex = 4;
            this.txtTheLoai.Text = "Thể loại";
            this.txtTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacGia.Location = new System.Drawing.Point(3, 65);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.Size = new System.Drawing.Size(334, 27);
            this.txtTacGia.TabIndex = 3;
            this.txtTacGia.Text = "Tác giả";
            this.txtTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(3, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(334, 27);
            this.txtTen.TabIndex = 2;
            this.txtTen.Text = "Tên sách";
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(3, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(334, 27);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID Sách";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.App;
            this.picImage.Location = new System.Drawing.Point(776, 337);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(340, 201);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 5;
            this.picImage.TabStop = false;
            // 
            // tlpTimKiem
            // 
            this.tlpTimKiem.BackColor = System.Drawing.Color.Teal;
            this.tlpTimKiem.ColumnCount = 2;
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTimKiem.Controls.Add(this.lblTimKiem, 0, 0);
            this.tlpTimKiem.Controls.Add(this.txtTimKiem, 1, 0);
            this.tlpTimKiem.Location = new System.Drawing.Point(40, 32);
            this.tlpTimKiem.Name = "tlpTimKiem";
            this.tlpTimKiem.RowCount = 1;
            this.tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTimKiem.Size = new System.Drawing.Size(415, 60);
            this.tlpTimKiem.TabIndex = 4;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.White;
            this.lblTimKiem.Location = new System.Drawing.Point(3, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(160, 25);
            this.lblTimKiem.TabIndex = 2;
            this.lblTimKiem.Text = "Thông tin";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(169, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(243, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dGV
            // 
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            this.dGV.ColumnHeadersHeight = 60;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV.Location = new System.Drawing.Point(40, 107);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 30;
            this.dGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(730, 431);
            this.dGV.TabIndex = 3;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKiemSach_CellClick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(159, 25);
            this.lbl_title.TabIndex = 13;
            this.lbl_title.Text = "Tìm Kiếm Sách";
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemSach";
            this.Text = "TimKiemSach";
            this.Load += new System.EventHandler(this.TimKiemSach_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tlpTimKiem.ResumeLayout(false);
            this.tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}