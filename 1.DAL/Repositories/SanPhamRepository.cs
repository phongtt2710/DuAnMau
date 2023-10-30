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
    public class SanPhamRepository : ISanPhamRepository
    {
        private DatabaseContext _DBcontext;
        private List<SanPham> _lstSanPham;
        public SanPhamRepository()
        {
            _DBcontext = new DatabaseContext();
            _lstSanPham = new List<SanPham>();
            LayDanhSachSP();
        }
        public List<SanPham> LayDanhSachSP()
        {
            _lstSanPham = _DBcontext.SanPhams.ToList();
            return _lstSanPham;
        }
        public bool addSP(SanPham sp)
        {
            _DBcontext.SanPhams.Add(sp);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool updateSP(SanPham sp)
        {
            _DBcontext.SanPhams.Update(sp);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool removeSP(SanPham sp)
        {
            _DBcontext.SanPhams.Remove(sp);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
