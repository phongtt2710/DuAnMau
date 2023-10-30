namespace _3.PresentationLayers
{
    partial class SanPham
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_dangxuat = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_normal = new System.Windows.Forms.PictureBox();
            this.tb_giaban = new System.Windows.Forms.TextBox();
            this.tb_gianhap = new System.Windows.Forms.TextBox();
            this.lb_tenhang = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.tb_soluong = new System.Windows.Forms.TextBox();
            this.tb_tenhang = new System.Windows.Forms.TextBox();
            this.lb_giaban = new System.Windows.Forms.Label();
            this.lb_gianhap = new System.Windows.Forms.Label();
            this.lb_sanpham = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_normal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(-9, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 267);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ Liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1131, 203);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 290;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 290;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá Nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 290;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá Bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 290;
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
            this.groupBox2.Controls.Add(this.Xóa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Location = new System.Drawing.Point(973, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 248);
            this.groupBox2.TabIndex = 26;
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
            // Xóa
            // 
            this.Xóa.BackColor = System.Drawing.Color.White;
            this.Xóa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Xóa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Xóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xóa.Location = new System.Drawing.Point(24, 121);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(140, 34);
            this.Xóa.TabIndex = 2;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseVisualStyleBackColor = false;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
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
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_normal);
            this.groupBox1.Controls.Add(this.tb_giaban);
            this.groupBox1.Controls.Add(this.tb_gianhap);
            this.groupBox1.Controls.Add(this.lb_tenhang);
            this.groupBox1.Controls.Add(this.lb_soluong);
            this.groupBox1.Controls.Add(this.tb_soluong);
            this.groupBox1.Controls.Add(this.tb_tenhang);
            this.groupBox1.Controls.Add(this.lb_giaban);
            this.groupBox1.Controls.Add(this.lb_gianhap);
            this.groupBox1.Location = new System.Drawing.Point(-9, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 248);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // pictureBox_normal
            // 
            this.pictureBox_normal.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox_normal.Location = new System.Drawing.Point(610, 28);
            this.pictureBox_normal.Name = "pictureBox_normal";
            this.pictureBox_normal.Size = new System.Drawing.Size(192, 191);
            this.pictureBox_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_normal.TabIndex = 18;
            this.pictureBox_normal.TabStop = false;
            this.pictureBox_normal.Click += new System.EventHandler(this.pictureBox_normal_Click);
            // 
            // tb_giaban
            // 
            this.tb_giaban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_giaban.Location = new System.Drawing.Point(147, 192);
            this.tb_giaban.Name = "tb_giaban";
            this.tb_giaban.Size = new System.Drawing.Size(267, 27);
            this.tb_giaban.TabIndex = 16;
            // 
            // tb_gianhap
            // 
            this.tb_gianhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_gianhap.Location = new System.Drawing.Point(147, 143);
            this.tb_gianhap.Name = "tb_gianhap";
            this.tb_gianhap.Size = new System.Drawing.Size(267, 27);
            this.tb_gianhap.TabIndex = 15;
            // 
            // lb_tenhang
            // 
            this.lb_tenhang.AutoSize = true;
            this.lb_tenhang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_tenhang.Location = new System.Drawing.Point(15, 51);
            this.lb_tenhang.Name = "lb_tenhang";
            this.lb_tenhang.Size = new System.Drawing.Size(85, 23);
            this.lb_tenhang.TabIndex = 4;
            this.lb_tenhang.Text = "Tên Hàng";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_soluong.Location = new System.Drawing.Point(15, 103);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(87, 23);
            this.lb_soluong.TabIndex = 5;
            this.lb_soluong.Text = "Số Lượng";
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_soluong.Location = new System.Drawing.Point(147, 99);
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(267, 27);
            this.tb_soluong.TabIndex = 8;
            // 
            // tb_tenhang
            // 
            this.tb_tenhang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_tenhang.Location = new System.Drawing.Point(147, 47);
            this.tb_tenhang.Name = "tb_tenhang";
            this.tb_tenhang.Size = new System.Drawing.Size(267, 27);
            this.tb_tenhang.TabIndex = 7;
            // 
            // lb_giaban
            // 
            this.lb_giaban.AutoSize = true;
            this.lb_giaban.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_giaban.Location = new System.Drawing.Point(16, 196);
            this.lb_giaban.Name = "lb_giaban";
            this.lb_giaban.Size = new System.Drawing.Size(71, 23);
            this.lb_giaban.TabIndex = 10;
            this.lb_giaban.Text = "Giá Bán";
            // 
            // lb_gianhap
            // 
            this.lb_gianhap.AutoSize = true;
            this.lb_gianhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gianhap.Location = new System.Drawing.Point(16, 147);
            this.lb_gianhap.Name = "lb_gianhap";
            this.lb_gianhap.Size = new System.Drawing.Size(84, 23);
            this.lb_gianhap.TabIndex = 9;
            this.lb_gianhap.Text = "Giá Nhập";
            // 
            // lb_sanpham
            // 
            this.lb_sanpham.AutoSize = true;
            this.lb_sanpham.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_sanpham.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_sanpham.Location = new System.Drawing.Point(448, 24);
            this.lb_sanpham.Name = "lb_sanpham";
            this.lb_sanpham.Size = new System.Drawing.Size(152, 38);
            this.lb_sanpham.TabIndex = 24;
            this.lb_sanpham.Text = "Sản Phẩm";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_sanpham);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_normal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button bt_dangxuat;
        private Button Xóa;
        private Button bt_sua;
        private Button bt_them;
        private GroupBox groupBox1;
        private PictureBox pictureBox_normal;
        private TextBox tb_giaban;
        private TextBox tb_gianhap;
        private Label lb_tenhang;
        private Label lb_soluong;
        private TextBox tb_soluong;
        private TextBox tb_tenhang;
        private Label lb_giaban;
        private Label lb_gianhap;
        private Label lb_sanpham;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}