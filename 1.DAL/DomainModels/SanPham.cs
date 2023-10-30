using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    [Table("tableHang")]
    public class SanPham
    {
        [Key]
        public int MaHang { get; set; }
        [StringLength(50)]
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public float DonGiaBan { get; set; }
        public float DonGiaNhap { get; set; }
        [StringLength(400)]
        public string HinhAnh { get; set; }
        [StringLength(20)]
        public string GhiChu { get; set; }
        [StringLength(20)]
        public string MaNV { get; set; }
        //
        [ForeignKey(nameof(MaNV))]
        [InverseProperty(nameof(NhanVien.SanPhams))]
        public virtual NhanVien MaNVNavigation { get; set; }
    }
}

