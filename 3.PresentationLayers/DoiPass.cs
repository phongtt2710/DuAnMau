using _1.DAL.Context;
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
    public partial class DoiPass : Form
    {
        private IQuanLyNhanVienService _iQuanLyNhanVienService;

        public DoiPass()
        {
            InitializeComponent();
            _iQuanLyNhanVienService = new QuanLyNhanVienService();
        }
        private bool validate()
        {
            if (tb_matkhaumoi.Text.Length < 6 || !tb_matkhaumoi.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Mật Khẩu phải >= 6 kí tự và có ít nhất 1 chữ số");
                return false;               
            }
            if (tb_matkhaumoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                return false;
            }
            if (tb_xacnhan.Text == "")
            {
                MessageBox.Show("Chưa xác nhận mật khẩu mới");
                return false;
            }
            if (tb_matkhaumoi.Text != tb_xacnhan.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return false;
            }
            return true;
        }
        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                var item = _iQuanLyNhanVienService.LayDanhSach().Where(p => p.Email == tb_taikhoan.Text).First();
                if (item != null)
                {
                    if (validate())
                    {
                        item.MatKhau = tb_matkhaumoi.Text;
                        _iQuanLyNhanVienService.Sua(item);
                        MessageBox.Show("Đổi mật khẩu thành công");
                        tb_taikhoan.Clear();
                        tb_matkhau.Clear();
                        tb_matkhaumoi.Clear();
                        tb_xacnhan.Clear();
                    }
                }
                else
                {
                    throw new Exception("Tài khoản không tồn tại");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}
