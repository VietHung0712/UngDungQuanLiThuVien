namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class DocGia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnSoThe = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tlpControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic);
            this.panel1.Controls.Add(this.tlpControl);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 726);
            this.panel1.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.App;
            this.pic.Location = new System.Drawing.Point(6, 3);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(478, 127);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // tlpControl
            // 
            this.tlpControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpControl.ColumnCount = 2;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.Controls.Add(this.btnNhapLai, 1, 1);
            this.tlpControl.Controls.Add(this.btnXoa, 0, 1);
            this.tlpControl.Controls.Add(this.btnSua, 1, 0);
            this.tlpControl.Controls.Add(this.btnThem, 0, 0);
            this.tlpControl.Location = new System.Drawing.Point(45, 638);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 2;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.Size = new System.Drawing.Size(400, 85);
            this.tlpControl.TabIndex = 1;
            this.tlpControl.Visible = false;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapLai.BackColor = System.Drawing.Color.Teal;
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Location = new System.Drawing.Point(262, 45);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(135, 35);
            this.btnNhapLai.TabIndex = 3;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(3, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Teal;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(262, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.txtNamSinh);
            this.panel13.Location = new System.Drawing.Point(3, 418);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(478, 71);
            this.panel13.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Năm sinh";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(39, 62);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(400, 2);
            this.panel14.TabIndex = 10;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamSinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(193, 24);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(246, 25);
            this.txtNamSinh.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txtDiaChi);
            this.panel11.Location = new System.Drawing.Point(3, 252);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(478, 74);
            this.panel11.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(39, 62);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 2);
            this.panel12.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(193, 24);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 25);
            this.txtDiaChi.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.txtSDT);
            this.panel9.Location = new System.Drawing.Point(3, 335);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(478, 74);
            this.panel9.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện thoại";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(39, 62);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 2);
            this.panel10.TabIndex = 10;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(193, 24);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(246, 25);
            this.txtSDT.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.txtGioiTinh);
            this.panel7.Location = new System.Drawing.Point(3, 169);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(478, 74);
            this.panel7.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới tính";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(39, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 2);
            this.panel8.TabIndex = 10;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiTinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.Location = new System.Drawing.Point(193, 24);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(246, 25);
            this.txtGioiTinh.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtTen);
            this.panel5.Location = new System.Drawing.Point(3, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(478, 74);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và tên";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(39, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 2);
            this.panel6.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(193, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 25);
            this.txtTen.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 74);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID/ Số Thẻ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(39, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 2);
            this.panel3.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(193, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 25);
            this.txtID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dGV);
            this.panel2.Controls.Add(this.btnSoThe);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(517, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 726);
            this.panel2.TabIndex = 1;
            // 
            // dGV
            // 
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            this.dGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV.ColumnHeadersHeight = 40;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGV.Location = new System.Drawing.Point(3, 136);
            this.dGV.Name = "dGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGV.RowHeadersWidth = 30;
            this.dGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV.RowTemplate.Height = 50;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(693, 582);
            this.dGV.TabIndex = 12;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // btnSoThe
            // 
            this.btnSoThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSoThe.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoThe.ForeColor = System.Drawing.Color.White;
            this.btnSoThe.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.safety_reader;
            this.btnSoThe.Location = new System.Drawing.Point(483, 5);
            this.btnSoThe.Name = "btnSoThe";
            this.btnSoThe.Size = new System.Drawing.Size(213, 125);
            this.btnSoThe.TabIndex = 4;
            this.btnSoThe.Text = "Thẻ Thư Viện";
            this.btnSoThe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSoThe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoThe.UseVisualStyleBackColor = false;
            this.btnSoThe.Click += new System.EventHandler(this.btnSoThe_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.99525F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.00475F));
            this.tableLayoutPanel3.Controls.Add(this.btnTimKiem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(28, 45);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 54);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Teal;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(243, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(141, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(3, 17);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(234, 34);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1228, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tlpControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Button btnSoThe;
        private System.Windows.Forms.DataGridView dGV;
    }
}