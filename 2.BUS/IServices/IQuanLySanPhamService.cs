using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuanLySanPhamService
    {
        List<SanPham> LayDanhSachSP();
        List<ViewHienThiSanPham> getViewSanPham();
        bool addSP(SanPham sanpham);
        bool updateSP(SanPham sanpham);
        bool RemoveSP(SanPham sanpham);
    }
}
