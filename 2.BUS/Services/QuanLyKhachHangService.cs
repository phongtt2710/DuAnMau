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
    public class QuanLyKhachHangService : IQuanLyKhachHangService
    {
        private IKhachHangRepository _iKhachHangRepository;
        private List<KhachHang> _lstKhachHang;
        private List<ViewHienThiKhachHang> _lstViewKH;
        public QuanLyKhachHangService()
        {
            _iKhachHangRepository = new KhachHangRepository();
            _lstKhachHang = new List<KhachHang>();
            _lstViewKH = new List<ViewHienThiKhachHang>();
            LayDanhSachKhachHang();
        }
        public List<KhachHang> LayDanhSachKhachHang()
        {
            return _lstKhachHang = _iKhachHangRepository.LayDanhSachKhachHang();
        }
        public List<ViewHienThiKhachHang> getViewKhachHang()
        {
            _lstViewKH = (from a in LayDanhSachKhachHang()
                        select new ViewHienThiKhachHang { KhachHang = a }).ToList();
            return _lstViewKH;
        }
        public bool ThemKH(KhachHang kh)
        {
            _iKhachHangRepository.themKH(kh);
            return true;
        }
        public bool SuaKH(KhachHang kh)
        {
            _iKhachHangRepository.suaKH(kh);
            return true;
        }
        public bool XoaKH(KhachHang kh)
        {
            _iKhachHangRepository.xoaKH(kh);
            return true;
        }
    }
}
