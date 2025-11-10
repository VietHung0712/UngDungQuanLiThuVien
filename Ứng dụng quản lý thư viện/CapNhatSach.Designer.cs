namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class CapNhatSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIDSach = new System.Windows.Forms.Panel();
            this.lblIDSach = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlTacGiaSach = new System.Windows.Forms.Panel();
            this.lblTacGiaSach = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.pnlTheLoaiSach = new System.Windows.Forms.Panel();
            this.lblTheLoaiSach = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.pnlNamXB = new System.Windows.Forms.Panel();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.pnlTenSach = new System.Windows.Forms.Panel();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pnlGiaBanSach = new System.Windows.Forms.Panel();
            this.lblGiaBanSach = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlIDSach.SuspendLayout();
            this.pnlTacGiaSach.SuspendLayout();
            this.pnlTheLoaiSach.SuspendLayout();
            this.pnlNamXB.SuspendLayout();
            this.pnlTenSach.SuspendLayout();
            this.pnlGiaBanSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.dGV);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 246);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.picImage);
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1134, 233);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Controls.Add(this.pnlIDSach, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTacGiaSach, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlTheLoaiSach, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlNamXB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlTenSach, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlGiaBanSach, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudSoLuong, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 233);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pnlIDSach
            // 
            this.pnlIDSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIDSach.AutoSize = true;
            this.pnlIDSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlIDSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIDSach.Controls.Add(this.lblIDSach);
            this.pnlIDSach.Controls.Add(this.txtID);
            this.pnlIDSach.Location = new System.Drawing.Point(3, 3);
            this.pnlIDSach.Name = "pnlIDSach";
            this.pnlIDSach.Size = new System.Drawing.Size(376, 70);
            this.pnlIDSach.TabIndex = 0;
            // 
            // lblIDSach
            // 
            this.lblIDSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDSach.AutoSize = true;
            this.lblIDSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSach.Location = new System.Drawing.Point(7, 20);
            this.lblIDSach.Name = "lblIDSach";
            this.lblIDSach.Size = new System.Drawing.Size(89, 25);
            this.lblIDSach.TabIndex = 1;
            this.lblIDSach.Text = "ID Sách";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(200, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 30);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTacGiaSach
            // 
            this.pnlTacGiaSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTacGiaSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTacGiaSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTacGiaSach.Controls.Add(this.lblTacGiaSach);
            this.pnlTacGiaSach.Controls.Add(this.txtTacGia);
            this.pnlTacGiaSach.Location = new System.Drawing.Point(3, 80);
            this.pnlTacGiaSach.Name = "pnlTacGiaSach";
            this.pnlTacGiaSach.Size = new System.Drawing.Size(376, 70);
            this.pnlTacGiaSach.TabIndex = 2;
            // 
            // lblTacGiaSach
            // 
            this.lblTacGiaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTacGiaSach.AutoSize = true;
            this.lblTacGiaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGiaSach.Location = new System.Drawing.Point(7, 20);
            this.lblTacGiaSach.Name = "lblTacGiaSach";
            this.lblTacGiaSach.Size = new System.Drawing.Size(88, 25);
            this.lblTacGiaSach.TabIndex = 1;
            this.lblTacGiaSach.Text = "Tác Giả";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTacGia.Location = new System.Drawing.Point(200, 20);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(122, 30);
            this.txtTacGia.TabIndex = 2;
            this.txtTacGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTheLoaiSach
            // 
            this.pnlTheLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTheLoaiSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTheLoaiSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTheLoaiSach.Controls.Add(this.lblTheLoaiSach);
            this.pnlTheLoaiSach.Controls.Add(this.txtTheLoai);
            this.pnlTheLoaiSach.Location = new System.Drawing.Point(385, 80);
            this.pnlTheLoaiSach.Name = "pnlTheLoaiSach";
            this.pnlTheLoaiSach.Size = new System.Drawing.Size(376, 70);
            this.pnlTheLoaiSach.TabIndex = 3;
            // 
            // lblTheLoaiSach
            // 
            this.lblTheLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTheLoaiSach.AutoSize = true;
            this.lblTheLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoaiSach.Location = new System.Drawing.Point(7, 20);
            this.lblTheLoaiSach.Name = "lblTheLoaiSach";
            this.lblTheLoaiSach.Size = new System.Drawing.Size(97, 25);
            this.lblTheLoaiSach.TabIndex = 1;
            this.lblTheLoaiSach.Text = "Thể Loại";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTheLoai.Location = new System.Drawing.Point(200, 20);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(122, 30);
            this.txtTheLoai.TabIndex = 3;
            this.txtTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlNamXB
            // 
            this.pnlNamXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNamXB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlNamXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNamXB.Controls.Add(this.lblNamXB);
            this.pnlNamXB.Controls.Add(this.txtNamXB);
            this.pnlNamXB.Location = new System.Drawing.Point(3, 157);
            this.pnlNamXB.Name = "pnlNamXB";
            this.pnlNamXB.Size = new System.Drawing.Size(376, 72);
            this.pnlNamXB.TabIndex = 4;
            // 
            // lblNamXB
            // 
            this.lblNamXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXB.Location = new System.Drawing.Point(7, 20);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(151, 25);
            this.lblNamXB.TabIndex = 1;
            this.lblNamXB.Text = "Năm Xuất Bản";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(200, 20);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(122, 30);
            this.txtNamXB.TabIndex = 4;
            this.txtNamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTenSach
            // 
            this.pnlTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTenSach.AutoSize = true;
            this.pnlTenSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTenSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTenSach.Controls.Add(this.lblTenSach);
            this.pnlTenSach.Controls.Add(this.txtTen);
            this.pnlTenSach.Location = new System.Drawing.Point(385, 3);
            this.pnlTenSach.Name = "pnlTenSach";
            this.pnlTenSach.Size = new System.Drawing.Size(376, 70);
            this.pnlTenSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            this.lblTenSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(7, 20);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(106, 25);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTen.Location = new System.Drawing.Point(200, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(122, 30);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGiaBanSach
            // 
            this.pnlGiaBanSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGiaBanSach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlGiaBanSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiaBanSach.Controls.Add(this.lblGiaBanSach);
            this.pnlGiaBanSach.Controls.Add(this.txtGiaBan);
            this.pnlGiaBanSach.Location = new System.Drawing.Point(385, 157);
            this.pnlGiaBanSach.Name = "pnlGiaBanSach";
            this.pnlGiaBanSach.Size = new System.Drawing.Size(376, 72);
            this.pnlGiaBanSach.TabIndex = 5;
            // 
            // lblGiaBanSach
            // 
            this.lblGiaBanSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGiaBanSach.AutoSize = true;
            this.lblGiaBanSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBanSach.Location = new System.Drawing.Point(7, 20);
            this.lblGiaBanSach.Name = "lblGiaBanSach";
            this.lblGiaBanSach.Size = new System.Drawing.Size(89, 25);
            this.lblGiaBanSach.TabIndex = 1;
            this.lblGiaBanSach.Text = "Giá Bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaBan.Location = new System.Drawing.Point(200, 20);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(122, 30);
            this.txtGiaBan.TabIndex = 5;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(767, 80);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(110, 38);
            this.nudSoLuong.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(767, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 71);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.picImage.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.App;
            this.picImage.Location = new System.Drawing.Point(880, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(254, 233);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 13;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNhapLai, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 508);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1158, 71);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Add_Document;
            this.btnThem.Location = new System.Drawing.Point(100, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(186, 50);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Visible = false;
            this.btnThem.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Changed;
            this.btnSua.Location = new System.Drawing.Point(389, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(186, 50);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapLai.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Refresh;
            this.btnNhapLai.Location = new System.Drawing.Point(678, 3);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(186, 50);
            this.btnNhapLai.TabIndex = 1;
            this.btnNhapLai.Text = "&Nhập Lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Visible = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLaiSach_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(967, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 50);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // dGV
            // 
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            this.dGV.ColumnHeadersHeight = 40;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV.Location = new System.Drawing.Point(8, 252);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 30;
            this.dGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV.RowTemplate.Height = 40;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1136, 232);
            this.dGV.TabIndex = 11;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVCapNhatSach_CellClick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(159, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Cập Nhật Sách";
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
            this.button1.TabIndex = 10;
            this.button1.Text = "Quay Lại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CapNhatSach";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Sách";
            this.Load += new System.EventHandler(this.CapNhatSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlIDSach.ResumeLayout(false);
            this.pnlIDSach.PerformLayout();
            this.pnlTacGiaSach.ResumeLayout(false);
            this.pnlTacGiaSach.PerformLayout();
            this.pnlTheLoaiSach.ResumeLayout(false);
            this.pnlTheLoaiSach.PerformLayout();
            this.pnlNamXB.ResumeLayout(false);
            this.pnlNamXB.PerformLayout();
            this.pnlTenSach.ResumeLayout(false);
            this.pnlTenSach.PerformLayout();
            this.pnlGiaBanSach.ResumeLayout(false);
            this.pnlGiaBanSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlIDSach;
        private System.Windows.Forms.Label lblIDSach;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlGiaBanSach;
        private System.Windows.Forms.Label lblGiaBanSach;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Panel pnlTacGiaSach;
        private System.Windows.Forms.Label lblTacGiaSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Panel pnlTheLoaiSach;
        private System.Windows.Forms.Label lblTheLoaiSach;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Panel pnlNamXB;
        private System.Windows.Forms.Label lblNamXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Panel pnlTenSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}