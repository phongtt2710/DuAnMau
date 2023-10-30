using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PresentationLayers
{
    public partial class Login : Form
    {
        IQuanLyNhanVienService _iIQuanLyNhanVienService;
        public Login()
        {
            InitializeComponent();
            _iIQuanLyNhanVienService = new QuanLyNhanVienService();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            var item = _iIQuanLyNhanVienService.LayDanhSach().Where(p => p.Email == tb_taikhoan.Text && p.MatKhau == tb_matkhau.Text).FirstOrDefault();
            if (item != null)
            {
                if (item.VaiTro == false)
                {
                    this.Hide();
                    new Menu().Show();
                }
                else
                {
                    this.Hide();
                    new MenuNV().Show();
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu không hợp lệ");
            }
        }
        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuenPass().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_taikhoan.Text != "" && tb_matkhau.Text != "")
            {
                if (checkBox1.Checked == true)
                {
                    string use = tb_taikhoan.Text;
                    string pass = tb_matkhau.Text;
                    Properties.Settings.Default.user = use;
                    Properties.Settings.Default.pass = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_taikhoan.Text = Properties.Settings.Default.user;
            tb_matkhau.Text = Properties.Settings.Default.pass;
            if (Properties.Settings.Default.user != "")
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chuongtrinh().Show();
        }
    }
}
