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
    public class QuanLySanPhamService : IQuanLySanPhamService
    {
        private ISanPhamRepository _iSanPhamRepository;
        private List<SanPham> _lstSanPham;
        private List<ViewHienThiSanPham> _lstViewSP;
        public QuanLySanPhamService()
        {
            _iSanPhamRepository = new SanPhamRepository();
            _lstSanPham = new List<SanPham>();
            _lstViewSP = new List<ViewHienThiSanPham>();
            LayDanhSachSP();
        }
        public List<SanPham> LayDanhSachSP()
        {
            return _lstSanPham = _iSanPhamRepository.LayDanhSachSP();
        }
        public List<ViewHienThiSanPham> getViewSanPham()
        {
            _lstViewSP = (from a in LayDanhSachSP()
                        select new ViewHienThiSanPham{ sanpham = a }).ToList();
            return _lstViewSP;
        }
        public bool addSP(SanPham sanpham)
        {
            _iSanPhamRepository.addSP(sanpham);
            return true;
        }
        public bool updateSP(SanPham sanpham)
        {
           _iSanPhamRepository.updateSP(sanpham);
            return true;
        }
        public bool RemoveSP(SanPham sanpham)
        {
            _iSanPhamRepository.removeSP(sanpham);
            return true;
        }
    }
}
