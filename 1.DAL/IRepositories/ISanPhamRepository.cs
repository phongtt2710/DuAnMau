using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ISanPhamRepository
    {
        List<SanPham> LayDanhSachSP();
        bool addSP(SanPham sp);
        bool updateSP(SanPham sp);
        bool removeSP(SanPham sp);
    }
}
