using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuanLyKhachHangService
    {
        List<KhachHang> LayDanhSachKhachHang();
        List<ViewHienThiKhachHang> getViewKhachHang();
        bool ThemKH(KhachHang kh);
        bool SuaKH(KhachHang kh);
        bool XoaKH(KhachHang kh);
    }
}
