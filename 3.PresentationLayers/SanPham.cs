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
    public partial class SanPham : Form
    {
        DatabaseContext _context = new DatabaseContext();
        public string linkanh = "";
        public double sl;
        public double gn;
        public double gb;
        private _1.DAL.DomainModels.SanPham _SanPham;
        private IQuanLySanPhamService _iQuanLySanPhamService;
        private ViewHienThiSanPham _ViewHienThiSP;
        public SanPham()
        {
            InitializeComponent();
            _SanPham = new _1.DAL.DomainModels.SanPham();
            _iQuanLySanPhamService = new QuanLySanPhamService();
            _ViewHienThiSP = new ViewHienThiSanPham();
            ShowThongTinSP();
        }
        public void ShowThongTinSP()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in _iQuanLySanPhamService.LayDanhSachSP())
            {
                dataGridView1.Rows.Add(t.TenHang, t.SoLuong, t.DonGiaNhap, t.DonGiaBan);
            }
        }      
        private void pic_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //if (pictureBox_normal.Image != null)
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh không?",
            //        "...", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {

            //        if (op.ShowDialog() == DialogResult.OK)
            //        {
            //            pictureBox_normal.Image = Image.FromFile(op.FileName);
            //            pictureBox_normal.SizeMode = PictureBoxSizeMode.StretchImage;
            //            MessageBox.Show(op.FileName);
            //        }
            //    }
            //}
            //if (pictureBox_normal.Image == null)
            //{
            //    if (op.ShowDialog() == DialogResult.OK)
            //    {
            //        linkanh = op.FileName;
            //        pictureBox_normal.Image = Image.FromFile(op.FileName);
            //        pictureBox_normal.SizeMode = PictureBoxSizeMode.CenterImage;
            //        MessageBox.Show(op.FileName);
            //    }
            //}
        }

        private void pictureBox_normal_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog(); 
            if (pictureBox_normal.Image != null) 
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh ko?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        linkanh = op.FileName;
                        pictureBox_normal.Image = Image.FromFile(op.FileName);
                        pictureBox_normal.SizeMode = PictureBoxSizeMode.StretchImage;
                        MessageBox.Show(op.FileName);
                    }
                }
            }
            if (pictureBox_normal.Image == null)
            {
                if (op.ShowDialog() == DialogResult.OK)
                {                   
                    linkanh = op.FileName;
                    pictureBox_normal.Image = Image.FromFile(op.FileName);
                    pictureBox_normal.SizeMode = PictureBoxSizeMode.CenterImage;
                    MessageBox.Show(op.FileName);
                }
            }
        }
        private bool validate()
        {
            if (tb_tenhang.Text == "" || tb_soluong.Text == "" || tb_gianhap.Text == "" || tb_giaban.Text == "" || pictureBox_normal == null)
            {
                MessageBox.Show("Không được để trống");
                return false;
            }
            if (tb_soluong.Text == "0")
            {
                MessageBox.Show("Số lượng sản phẩm không được = 0");
                return false;
            }
            if (Convert.ToInt32(tb_gianhap.Text) > Convert.ToInt32(tb_giaban.Text))
            {
                MessageBox.Show("Giá nhập không được lớn hơn giá bán");
                return false;
            }
            bool check = Double.TryParse(tb_soluong.Text, out sl);
            if (check == false)
            {
                MessageBox.Show("Số lượng phải là số nguyên");
                return false;
            }
            bool check1 = Double.TryParse(tb_gianhap.Text, out gn);
            if (check1 == false)
            {
                MessageBox.Show("Giá nhập phải là số nguyên");
                return false;
            }
            bool check2 = Double.TryParse(tb_giaban.Text, out gb);
            if (check2 == false)
            {
                MessageBox.Show("Giá bán phải là số nguyên");
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
                        _SanPham.TenHang = tb_tenhang.Text;
                        _SanPham.SoLuong = int.Parse(tb_soluong.Text);
                        _SanPham.DonGiaNhap = float.Parse(tb_gianhap.Text);
                        _SanPham.DonGiaBan = float.Parse(tb_giaban.Text);
                        _SanPham.HinhAnh = linkanh;
                        _SanPham.GhiChu = "Không";
                        _SanPham.MaNV = "NV0";
                        _iQuanLySanPhamService.addSP(_SanPham);
                        MessageBox.Show("Thêm thành công");
                        tb_tenhang.Clear();
                        tb_soluong.Clear();
                        tb_gianhap.Clear();
                        tb_giaban.Clear();
                        ShowThongTinSP();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
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
                        foreach (var item in _iQuanLySanPhamService.LayDanhSachSP().Where(sp => sp.TenHang == tb_tenhang.Text))
                        {
                            item.SoLuong = int.Parse(tb_soluong.Text);
                            item.DonGiaNhap = float.Parse(tb_gianhap.Text);
                            item.DonGiaBan = float.Parse(tb_giaban.Text);
                            item.HinhAnh = linkanh;
                            _iQuanLySanPhamService.updateSP(item);
                        }                                          
                        MessageBox.Show("Sửa Thành Công");
                        tb_tenhang.Clear();
                        tb_soluong.Clear();
                        tb_gianhap.Clear();
                        tb_giaban.Clear();
                        ShowThongTinSP();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
            tb_tenhang.Text = dt.Cells[0].Value.ToString();
            tb_soluong.Text = dt.Cells[1].Value.ToString();
            tb_gianhap.Text = dt.Cells[2].Value.ToString();
            tb_giaban.Text = dt.Cells[3].Value.ToString();
            var pic = _iQuanLySanPhamService.LayDanhSachSP().Where(p => p.TenHang == tb_tenhang.Text).Select(p => p.HinhAnh).FirstOrDefault();
#pragma warning disable CS8604 // Possible null reference argument.
            pictureBox_normal.Image = Image.FromFile(pic);
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    foreach (var item in _iQuanLySanPhamService.LayDanhSachSP().Where(sp => sp.TenHang == tb_tenhang.Text))
                    {
                        _iQuanLySanPhamService.RemoveSP(item);
                    }
                    MessageBox.Show("Xóa Thành Công");
                    tb_tenhang.Clear();
                    tb_soluong.Clear();
                    tb_gianhap.Clear();
                    tb_giaban.Clear();
                    ShowThongTinSP();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tim = _iQuanLySanPhamService.LayDanhSachSP().Where(e => e.TenHang.Contains(textBox1.Text));
            dataGridView1.Rows.Clear();
            foreach (var t in tim)
            {
                dataGridView1.Rows.Add(t.TenHang, t.SoLuong, t.DonGiaNhap, t.DonGiaBan);
            }
        }
    }
}
