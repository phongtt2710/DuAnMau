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
    public partial class QuenPass : Form
    {
        private IQuanLyNhanVienService _iQuanLyNhanVienService;
        public QuenPass()
        {
            InitializeComponent();
            _iQuanLyNhanVienService = new QuanLyNhanVienService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
      
        private void bt_laypass_Click(object sender, EventArgs e)
        {
            var item = _iQuanLyNhanVienService.LayDanhSach().Where(p => p.Email == tb_email.Text).FirstOrDefault();
            if (item != null)
            {
                MessageBox.Show("Mật Khẩu là: " + item.MatKhau);
            }
            else
            {
                MessageBox.Show("Bạn nhập sai email");
            }
        }
    }
}
