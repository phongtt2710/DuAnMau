using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    [Table("tableNhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            SanPhams = new HashSet<SanPham>();
            KhachHangs = new HashSet<KhachHang>();
        }
        public int Id { get; set; }
        [Key]
        [StringLength(20)]
        public string MaNV { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string TenNV { get; set; }
        public bool VaiTro { get; set; }
        public bool TinhTrang { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        [InverseProperty(nameof(SanPham.MaNVNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }

        [InverseProperty(nameof(KhachHang.MaNVNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
