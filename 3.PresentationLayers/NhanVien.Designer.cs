namespace _3.PresentationLayers
{
    partial class NhanVien
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_dangxuat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_quantri = new System.Windows.Forms.RadioButton();
            this.rdb_nhanvien = new System.Windows.Forms.RadioButton();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.rdb_KHD = new System.Windows.Forms.RadioButton();
            this.lb_tennhanvien = new System.Windows.Forms.Label();
            this.rdb_HD = new System.Windows.Forms.RadioButton();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_tinhtrang = new System.Windows.Forms.Label();
            this.lb_vaitro = new System.Windows.Forms.Label();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(40, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 267);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ Liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 203);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mật Khẩu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên Nhân Viên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 220;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Vai Trò";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 220;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tình Trạng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 220;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(807, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Tìm Kiếm Tại Đây";
            this.textBox1.Size = new System.Drawing.Size(339, 28);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_dangxuat);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Location = new System.Drawing.Point(1022, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 248);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.BackColor = System.Drawing.Color.White;
            this.bt_dangxuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_dangxuat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_dangxuat.Location = new System.Drawing.Point(24, 161);
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.Size = new System.Drawing.Size(140, 34);
            this.bt_dangxuat.TabIndex = 3;
            this.bt_dangxuat.Text = "Back";
            this.bt_dangxuat.UseVisualStyleBackColor = false;
            this.bt_dangxuat.Click += new System.EventHandler(this.bt_dangxuat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.White;
            this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(24, 121);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(140, 34);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.White;
            this.bt_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sua.Location = new System.Drawing.Point(24, 81);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(140, 34);
            this.bt_sua.TabIndex = 1;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.White;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(24, 40);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(140, 34);
            this.bt_them.TabIndex = 0;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_matkhau);
            this.groupBox1.Controls.Add(this.rdb_KHD);
            this.groupBox1.Controls.Add(this.lb_tennhanvien);
            this.groupBox1.Controls.Add(this.rdb_HD);
            this.groupBox1.Controls.Add(this.tb_ten);
            this.groupBox1.Controls.Add(this.tb_matkhau);
            this.groupBox1.Controls.Add(this.lb_tinhtrang);
            this.groupBox1.Controls.Add(this.lb_vaitro);
            this.groupBox1.Location = new System.Drawing.Point(40, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 248);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_quantri);
            this.panel1.Controls.Add(this.rdb_nhanvien);
            this.panel1.Location = new System.Drawing.Point(616, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 69);
            this.panel1.TabIndex = 15;
            // 
            // rdb_quantri
            // 
            this.rdb_quantri.AutoSize = true;
            this.rdb_quantri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_quantri.Location = new System.Drawing.Point(175, 17);
            this.rdb_quantri.Name = "rdb_quantri";
            this.rdb_quantri.Size = new System.Drawing.Size(86, 24);
            this.rdb_quantri.TabIndex = 12;
            this.rdb_quantri.TabStop = true;
            this.rdb_quantri.Text = "Quản trị";
            this.rdb_quantri.UseVisualStyleBackColor = true;
            this.rdb_quantri.Click += new System.EventHandler(this.rdb_quantri_Click);
            // 
            // rdb_nhanvien
            // 
            this.rdb_nhanvien.AutoSize = true;
            this.rdb_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_nhanvien.Location = new System.Drawing.Point(25, 17);
            this.rdb_nhanvien.Name = "rdb_nhanvien";
            this.rdb_nhanvien.Size = new System.Drawing.Size(101, 24);
            this.rdb_nhanvien.TabIndex = 11;
            this.rdb_nhanvien.TabStop = true;
            this.rdb_nhanvien.Text = "Nhân viên";
            this.rdb_nhanvien.UseVisualStyleBackColor = true;
            this.rdb_nhanvien.Click += new System.EventHandler(this.rdb_nhanvien_Click);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(181, 36);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(267, 27);
            this.tb_email.TabIndex = 6;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_email.Location = new System.Drawing.Point(15, 40);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 23);
            this.lb_email.TabIndex = 3;
            this.lb_email.Text = "Email";
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_matkhau.Location = new System.Drawing.Point(15, 87);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(87, 23);
            this.lb_matkhau.TabIndex = 4;
            this.lb_matkhau.Text = "Mật Khẩu";
            // 
            // rdb_KHD
            // 
            this.rdb_KHD.AutoSize = true;
            this.rdb_KHD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_KHD.Location = new System.Drawing.Point(791, 90);
            this.rdb_KHD.Name = "rdb_KHD";
            this.rdb_KHD.Size = new System.Drawing.Size(154, 24);
            this.rdb_KHD.TabIndex = 14;
            this.rdb_KHD.TabStop = true;
            this.rdb_KHD.Text = "Không Hoạt Động";
            this.rdb_KHD.UseVisualStyleBackColor = true;
            this.rdb_KHD.Click += new System.EventHandler(this.rdb_KHD_Click);
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.AutoSize = true;
            this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tennhanvien.Location = new System.Drawing.Point(15, 140);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(124, 23);
            this.lb_tennhanvien.TabIndex = 5;
            this.lb_tennhanvien.Text = "Tên Nhân Viên";
            // 
            // rdb_HD
            // 
            this.rdb_HD.AutoSize = true;
            this.rdb_HD.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_HD.Location = new System.Drawing.Point(641, 90);
            this.rdb_HD.Name = "rdb_HD";
            this.rdb_HD.Size = new System.Drawing.Size(105, 24);
            this.rdb_HD.TabIndex = 13;
            this.rdb_HD.TabStop = true;
            this.rdb_HD.Text = "Hoạt Động";
            this.rdb_HD.UseVisualStyleBackColor = true;
            this.rdb_HD.Click += new System.EventHandler(this.rdb_HD_Click);
            // 
            // tb_ten
            // 
            this.tb_ten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ten.Location = new System.Drawing.Point(181, 136);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(267, 27);
            this.tb_ten.TabIndex = 8;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_matkhau.Location = new System.Drawing.Point(181, 86);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(267, 27);
            this.tb_matkhau.TabIndex = 7;
            // 
            // lb_tinhtrang
            // 
            this.lb_tinhtrang.AutoSize = true;
            this.lb_tinhtrang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tinhtrang.Location = new System.Drawing.Point(513, 90);
            this.lb_tinhtrang.Name = "lb_tinhtrang";
            this.lb_tinhtrang.Size = new System.Drawing.Size(96, 23);
            this.lb_tinhtrang.TabIndex = 10;
            this.lb_tinhtrang.Text = "Tình Trạng";
            // 
            // lb_vaitro
            // 
            this.lb_vaitro.AutoSize = true;
            this.lb_vaitro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_vaitro.Location = new System.Drawing.Point(513, 40);
            this.lb_vaitro.Name = "lb_vaitro";
            this.lb_vaitro.Size = new System.Drawing.Size(65, 23);
            this.lb_vaitro.TabIndex = 9;
            this.lb_vaitro.Text = "Vai Trò";
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_nhanvien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_nhanvien.Location = new System.Drawing.Point(497, 28);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(158, 38);
            this.lb_nhanvien.TabIndex = 20;
            this.lb_nhanvien.Text = "Nhân Viên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1247, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_nhanvien);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button bt_dangxuat;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
        private GroupBox groupBox1;
        private Panel panel1;
        private RadioButton rdb_quantri;
        private RadioButton rdb_nhanvien;
        private TextBox tb_email;
        private Label lb_email;
        private Label lb_matkhau;
        private RadioButton rdb_KHD;
        private Label lb_tennhanvien;
        private RadioButton rdb_HD;
        private TextBox tb_ten;
        private TextBox tb_matkhau;
        private Label lb_tinhtrang;
        private Label lb_vaitro;
        private Label lb_nhanvien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}