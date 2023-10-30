using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepository
    {
        bool them(NhanVien nhanvien); // Thêm nhân viên
        bool sua(NhanVien nhanvien); // Sửa nhân viên
        bool xoa(NhanVien nhanvien); // Xóa nhân viên
        List<NhanVien> LayDanhSach(); // Lấy danh sách nhân viên
    }
}
