namespace _3.PresentationLayers
{
    partial class QuenPass
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
            this.lb_doipass = new System.Windows.Forms.Label();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_laypass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_doipass
            // 
            this.lb_doipass.AutoSize = true;
            this.lb_doipass.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_doipass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_doipass.Location = new System.Drawing.Point(308, 56);
            this.lb_doipass.Name = "lb_doipass";
            this.lb_doipass.Size = new System.Drawing.Size(238, 41);
            this.lb_doipass.TabIndex = 10;
            this.lb_doipass.Text = "Quên Mật Khẩu";
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_taikhoan.Location = new System.Drawing.Point(189, 149);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(64, 28);
            this.lb_taikhoan.TabIndex = 15;
            this.lb_taikhoan.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(293, 143);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(267, 34);
            this.tb_email.TabIndex = 16;
            // 
            // bt_laypass
            // 
            this.bt_laypass.BackColor = System.Drawing.Color.White;
            this.bt_laypass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_laypass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_laypass.Location = new System.Drawing.Point(293, 216);
            this.bt_laypass.Name = "bt_laypass";
            this.bt_laypass.Size = new System.Drawing.Size(151, 40);
            this.bt_laypass.TabIndex = 19;
            this.bt_laypass.Text = "Lấy Lại MK";
            this.bt_laypass.UseVisualStyleBackColor = false;
            this.bt_laypass.Click += new System.EventHandler(this.bt_laypass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(471, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuenPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_laypass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.lb_doipass);
            this.Name = "QuenPass";
            this.Text = "QuenPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_doipass;
        private Label lb_taikhoan;
        private TextBox tb_email;
        private Button bt_laypass;
        private Button button1;
    }
}