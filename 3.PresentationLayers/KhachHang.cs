using _1.DAL.Context;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
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
    public partial class KhachHang : Form
    {
        DatabaseContext _context = new DatabaseContext();
        public double sdt;
        private _1.DAL.DomainModels.KhachHang _khachHang;              
        private IQuanLyKhachHangService _iQuanLyKhachHangService;
        private ViewHienThiKhachHang _viewHienThiKH;
        public KhachHang()
        {
            InitializeComponent();
            _khachHang = new _1.DAL.DomainModels.KhachHang();          
            _iQuanLyKhachHangService = new QuanLyKhachHangService();
            _viewHienThiKH = new ViewHienThiKhachHang();
            rdb_nam.Checked = true;
            ShowThongTinKH();
        }
        public void ShowThongTinKH()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang()) 
            {
              dataGridView1.Rows.Add(item.TenKhach, item.Phai, item.DiaChi, item.DienThoai);
            }
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
            tb_ten.Text = dt.Cells[0].Value.ToString();
            tb_diachi.Text = dt.Cells[2].Value.ToString();
            tb_sdt.Text = dt.Cells[3].Value.ToString();
            rdb_nam.Checked = (dt.Cells[1].Value.ToString() == "Nam" ? true : false);
            rdb_nu.Checked = (dt.Cells[1].Value.ToString() == "Nữ" ? true : false);
        }
        private bool validate()
        {
            if (tb_ten.Text == "" || tb_sdt.Text == "" || tb_diachi.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return false;
            }
            bool check = Double.TryParse(tb_sdt.Text, out sdt);
            if (check == false)
            {
                MessageBox.Show("Số điện thoại phải là số");
                return false;
            }
            return true;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (validate())
                    {
                        _khachHang.MaNV = "NV0";
                        _khachHang.TenKhach = tb_ten.Text;
                        _khachHang.DiaChi = tb_diachi.Text;
                        _khachHang.DienThoai = tb_sdt.Text;
                        _khachHang.Phai = rdb_nam.Checked == true ? "Nam" : "Nữ";          
                       _iQuanLyKhachHangService.ThemKH(_khachHang);      
                        MessageBox.Show("Thêm thành công");
                        tb_ten.Clear();
                        tb_sdt.Clear();
                        tb_diachi.Clear();
                        ShowThongTinKH();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(kh => kh.TenKhach == tb_ten.Text))
                    {
                        _iQuanLyKhachHangService.XoaKH(item);
                    }
                    MessageBox.Show("Xóa Thành Công");
                    tb_ten.Clear();
                    tb_sdt.Clear();
                    tb_diachi.Clear();
                    ShowThongTinKH();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Sửa không", "Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (validate())
                    {
                        foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(kh => kh.TenKhach == tb_ten.Text))
                        {
                            item.DiaChi = tb_diachi.Text;
                            item.DienThoai = tb_sdt.Text;
                            item.Phai = rdb_nam.Checked == true ? "Nam" : "Nữ";   
                            _iQuanLyKhachHangService.SuaKH(item);
                        }                        
                        MessageBox.Show("Sửa Thành Công");
                        tb_ten.Clear();
                        tb_sdt.Clear();
                        tb_diachi.Clear();
                        ShowThongTinKH();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tim = _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(e => e.TenKhach.Contains(textBox1.Text));
            dataGridView1.Rows.Clear();
            foreach (var item in tim)
            {
                dataGridView1.Rows.Add(item.TenKhach, item.Phai, item.DiaChi, item.DienThoai);
            }
        }
    }
}
