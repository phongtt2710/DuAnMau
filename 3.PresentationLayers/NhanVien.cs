using _1.DAL.Context;
using _1.DAL.DomainModels;
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
    public partial class NhanVien : Form
    {
        DatabaseContext _context = new DatabaseContext();
        private _1.DAL.DomainModels.NhanVien _nhanvien;
        private IQuanLyNhanVienService _iQuanLyNhanVienService;
        private ViewHienThiNhanVien _viewHienThiNV;
        public NhanVien()
        {
            InitializeComponent();
            _nhanvien = new _1.DAL.DomainModels.NhanVien();
            _iQuanLyNhanVienService = new QuanLyNhanVienService();
            _viewHienThiNV = new ViewHienThiNhanVien();
            rdb_HD.Checked = true;
            rdb_nhanvien.Checked = true;
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
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (validate())
                    {
                        var item = _iQuanLyNhanVienService.LayDanhSach().Where(p => p.Email == tb_email.Text).FirstOrDefault();
                        if (item != null)
                        {
                            MessageBox.Show("Email đã tồn tại");
                        }
                        else
                        {
                            _nhanvien.Id = _iQuanLyNhanVienService.LayDanhSach().Count;
                            _nhanvien.MaNV = "NV" + _nhanvien.Id;
                            _nhanvien.Email = tb_email.Text;
                            _nhanvien.TenNV = tb_ten.Text;
                            _nhanvien.MatKhau = tb_matkhau.Text;
                            _nhanvien.VaiTro = rdb_nhanvien.Checked;
                            _nhanvien.TinhTrang = rdb_HD.Checked;
                            _iQuanLyNhanVienService.Them(_nhanvien);
                            MessageBox.Show("Thêm thành công");
                            tb_email.Clear();
                            tb_matkhau.Clear();
                            tb_ten.Clear();
                            ShowThongTin();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
            tb_email.Text = dataGridViewRow.Cells[0].Value.ToString();
            tb_ten.Text = dataGridViewRow.Cells[2].Value.ToString();
            rdb_nhanvien.Checked = (dataGridViewRow.Cells[3].Value.ToString() == "Nhân viên" ? true : false);
            rdb_quantri.Checked = (dataGridViewRow.Cells[3].Value.ToString() == "Quản trị" ? true : false);
            rdb_HD.Checked = (dataGridViewRow.Cells[4].Value.ToString() == "Hoạt Động" ? true : false);
            rdb_KHD.Checked = (dataGridViewRow.Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false);
            tb_matkhau.Text = dataGridViewRow.Cells[1].Value.ToString();
        }
        private bool validate()
        {
            if (tb_email.Text == "" || tb_matkhau.Text == "" || tb_ten.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return false;
            }
            if (tb_matkhau.Text.Length < 6 || !tb_matkhau.Text.Any(char.IsNumber))
            {
                MessageBox.Show("Mật Khẩu phải >= 6 kí tự và có ít nhất 1 chữ số");
                return false;
            }
            return true;
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
                        foreach (var item in _iQuanLyNhanVienService.LayDanhSach().Where(nv => nv.Email == tb_email.Text))
                        {
                            item.TenNV = tb_ten.Text;
                            item.VaiTro = true ? rdb_nhanvien.Checked : rdb_quantri.Checked;
                            item.TinhTrang = true ? rdb_HD.Checked : rdb_KHD.Checked;
                            _iQuanLyNhanVienService.Sua(item);
                        }
                        MessageBox.Show("Sửa Thành Công");
                        tb_email.Clear();
                        tb_matkhau.Clear();
                        tb_ten.Clear();
                        ShowThongTin();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    foreach (var item in _iQuanLyNhanVienService.LayDanhSach().Where(nv => nv.Email == tb_email.Text))
                    {
                        _iQuanLyNhanVienService.Xoa(item);
                    }
                    MessageBox.Show("Xóa Thành Công");
                    tb_email.Clear();
                    tb_matkhau.Clear();
                    tb_ten.Clear();
                    ShowThongTin();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
        }
        private void rdb_KHD_Click(object sender, EventArgs e)
        {
            rdb_HD.Checked = false;
        }

        private void rdb_HD_Click(object sender, EventArgs e)
        {
            rdb_KHD.Checked = false;
        }

        private void rdb_nhanvien_Click(object sender, EventArgs e)
        {
            rdb_quantri.Checked = false;
        }

        private void rdb_quantri_Click(object sender, EventArgs e)
        {
            rdb_nhanvien.Checked = false;
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
        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
    }
}
