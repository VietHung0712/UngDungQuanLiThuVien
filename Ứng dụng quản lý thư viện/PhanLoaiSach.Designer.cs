namespace Ứng_dụng_quản_lý_thư_viện
{
    partial class PhanLoaiSach
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
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnhanLoai = new System.Windows.Forms.Button();
            this.tlpPhanLoai = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PhanLoai = new System.Windows.Forms.Label();
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPhanLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.tlpPhanLoai.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.button1.TabIndex = 10;
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
            this.panel1.Controls.Add(this.dGV);
            this.panel1.Controls.Add(this.btnhanLoai);
            this.panel1.Controls.Add(this.tlpPhanLoai);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 579);
            this.panel1.TabIndex = 2;
            // 
            // dGV
            // 
            this.dGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV.BackgroundColor = System.Drawing.Color.White;
            this.dGV.ColumnHeadersHeight = 40;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGV.Location = new System.Drawing.Point(40, 189);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 30;
            this.dGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(1075, 349);
            this.dGV.TabIndex = 3;
            // 
            // btnhanLoai
            // 
            this.btnhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhanLoai.Image = global::Ứng_dụng_quản_lý_thư_viện.Properties.Resources.play;
            this.btnhanLoai.Location = new System.Drawing.Point(905, 111);
            this.btnhanLoai.Name = "btnhanLoai";
            this.btnhanLoai.Size = new System.Drawing.Size(210, 51);
            this.btnhanLoai.TabIndex = 2;
            this.btnhanLoai.Text = "Thực Hiện";
            this.btnhanLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhanLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhanLoai.UseVisualStyleBackColor = true;
            this.btnhanLoai.Click += new System.EventHandler(this.btnhanLoai_Click);
            // 
            // tlpPhanLoai
            // 
            this.tlpPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPhanLoai.BackColor = System.Drawing.Color.Teal;
            this.tlpPhanLoai.ColumnCount = 2;
            this.tlpPhanLoai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPhanLoai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpPhanLoai.Controls.Add(this.lbl_PhanLoai, 0, 0);
            this.tlpPhanLoai.Controls.Add(this.txtPhanLoai, 1, 0);
            this.tlpPhanLoai.Location = new System.Drawing.Point(700, 40);
            this.tlpPhanLoai.Name = "tlpPhanLoai";
            this.tlpPhanLoai.RowCount = 1;
            this.tlpPhanLoai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhanLoai.Size = new System.Drawing.Size(415, 60);
            this.tlpPhanLoai.TabIndex = 4;
            // 
            // lbl_PhanLoai
            // 
            this.lbl_PhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PhanLoai.AutoSize = true;
            this.lbl_PhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhanLoai.ForeColor = System.Drawing.Color.White;
            this.lbl_PhanLoai.Location = new System.Drawing.Point(3, 0);
            this.lbl_PhanLoai.Name = "lbl_PhanLoai";
            this.lbl_PhanLoai.Size = new System.Drawing.Size(160, 25);
            this.lbl_PhanLoai.TabIndex = 2;
            this.lbl_PhanLoai.Text = "Thông Tin";
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhanLoai.Location = new System.Drawing.Point(169, 3);
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.Size = new System.Drawing.Size(243, 30);
            this.txtPhanLoai.TabIndex = 1;
            this.txtPhanLoai.TextChanged += new System.EventHandler(this.txtPhanLoai_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.cbPhanLoai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 60);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cbPhanLoai
            // 
            this.cbPhanLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhanLoai.ForeColor = System.Drawing.Color.Black;
            this.cbPhanLoai.FormattingEnabled = true;
            this.cbPhanLoai.ItemHeight = 25;
            this.cbPhanLoai.Items.AddRange(new object[] {
            "Tác Giả",
            "Thể Loại",
            "Năm Xuất Bản",
            "Giá Bán"});
            this.cbPhanLoai.Location = new System.Drawing.Point(169, 3);
            this.cbPhanLoai.Name = "cbPhanLoai";
            this.cbPhanLoai.Size = new System.Drawing.Size(243, 33);
            this.cbPhanLoai.TabIndex = 0;
            this.cbPhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbPhanLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phân loại";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 23);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(165, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Phân Loại Sách";
            // 
            // PhanLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanLoaiSach";
            this.Text = "PhanLoaiSach";
            this.Load += new System.EventHandler(this.PhanLoaiSach_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.tlpPhanLoai.ResumeLayout(false);
            this.tlpPhanLoai.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPhanLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpPhanLoai;
        private System.Windows.Forms.Label lbl_PhanLoai;
        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnhanLoai;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label lbl_title;
    }
}