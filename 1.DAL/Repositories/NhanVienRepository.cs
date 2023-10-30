using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class NhanVienRepository : INhanVienRepository
    {

        private DatabaseContext _DBcontext;
        private List<NhanVien> _lstNhanVien;
        public NhanVienRepository()
        {
            _DBcontext = new DatabaseContext();
            _lstNhanVien = new List<NhanVien>();
            LayDanhSach();
        }
        public List<NhanVien> LayDanhSach()
        {
            _lstNhanVien = _DBcontext.NhanViens.ToList();
            return _lstNhanVien;
        }
        public bool them(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Add(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool sua(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Update(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool xoa(NhanVien nhanvien)
        {
            _DBcontext.NhanViens.Remove(nhanvien);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
