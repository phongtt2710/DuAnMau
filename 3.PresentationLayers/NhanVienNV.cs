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
    public partial class NhanVienNV : Form
    {
        private _1.DAL.DomainModels.NhanVien _nhanvien;
        private IQuanLyNhanVienService _iQuanLyNhanVienService;
        private ViewHienThiNhanVien _viewHienThiNV;
        public NhanVienNV()
        {
            InitializeComponent();
            _nhanvien = new _1.DAL.DomainModels.NhanVien();
            _iQuanLyNhanVienService = new QuanLyNhanVienService();
            _viewHienThiNV = new ViewHienThiNhanVien();
            ShowThongTin();
        }
        public void ShowThongTin()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in _iQuanLyNhanVienService.LayDanhSach())
            {
                dataGridView1.Rows.Add(t.Email, t.MatKhau, t.TenNV, t.VaiTro == true ? "Nhân viên" : "Quản trị", t.TinhTrang == true ? "Hoạt Động" : "Không Hoạt Động");
            }
        }
        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuNV().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tim = _iQuanLyNhanVienService.LayDanhSach().Where(e => e.TenNV.Contains(textBox1.Text));
            dataGridView1.Rows.Clear();
            foreach (var t in tim)
            {
                dataGridView1.Rows.Add(t.Email, t.MatKhau, t.TenNV, t.VaiTro == true ? "Nhân viên" : "Quản trị", t.TinhTrang == true ? "Hoạt Động" : "Không Hoạt Động");
            }
        }
    }
}
