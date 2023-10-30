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
    public class KhachHangRepository : IKhachHangRepository
    {
        private DatabaseContext _DBcontext;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepository()
        {
            _lstKhachHang = new List<KhachHang>();
            _DBcontext = new DatabaseContext();
            LayDanhSachKhachHang();
        }
        public List<KhachHang> LayDanhSachKhachHang()
        {
            _lstKhachHang = _DBcontext.KhachHangs.ToList();
            return _lstKhachHang;
        }
        public bool themKH(KhachHang kh)
        {
            _DBcontext.KhachHangs.Add(kh);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool suaKH(KhachHang kh)
        {
            _DBcontext.KhachHangs.Update(kh);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool xoaKH(KhachHang kh)
        {
            _DBcontext.KhachHangs.Remove(kh);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
