using _1.DAL.DomainModels;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuanLyNhanVienService
    {
        bool Them(NhanVien nhanVien);
        bool Sua(NhanVien nhanVien);
        bool Xoa(NhanVien nhanVien);
        List<NhanVien> LayDanhSach();
        List<ViewHienThiNhanVien> getViewNhanVien();


    }
}
