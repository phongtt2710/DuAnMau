using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    [Table("tableKhachHang")]
    public class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string DienThoai { get; set; }
        [StringLength(50)]
        public string TenKhach { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(5)]
        public string Phai { get; set; }
        [StringLength(20)]
        public string MaNV { get; set; }
        //
        [ForeignKey(nameof(MaNV))]
        [InverseProperty(nameof(NhanVien.KhachHangs))]
        public virtual NhanVien MaNVNavigation { get; set; }
    }
}
