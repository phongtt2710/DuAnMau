using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QuanLyNhanVienService : IQuanLyNhanVienService
    {
        //code các chức năng trên giao diện tại đây
        //Muốn tác động vào CSDL cần phải gọi vào interface của tầng DAL
        private INhanVienRepository _inhanVienRepositories;
        private List<NhanVien> _lstNhanVien;       
        private List<ViewHienThiNhanVien> _lstView;
        public QuanLyNhanVienService()
        {
            _inhanVienRepositories = new NhanVienRepository();
            _lstNhanVien = new List<NhanVien>();           
            _lstView = new List<ViewHienThiNhanVien>();
            LayDanhSach();
        }
        public List<NhanVien> LayDanhSach()
        {
            return _lstNhanVien = _inhanVienRepositories.LayDanhSach();
        }
        public List<ViewHienThiNhanVien> getViewNhanVien()
        {
            _lstView = (from a in LayDanhSach()
                        select new ViewHienThiNhanVien { NhanVien = a }).ToList();
            return _lstView;
        }
        public bool Them(NhanVien nhanVien)
        {
            _inhanVienRepositories.them(nhanVien);
            return true;
        }
        public bool Sua(NhanVien nhanVien)
        {
            _inhanVienRepositories.sua(nhanVien);
            return true;
        }
        public bool Xoa(NhanVien nhanVien)
        {
            _inhanVienRepositories.xoa(nhanVien);
            return true;
        }
    }
}
