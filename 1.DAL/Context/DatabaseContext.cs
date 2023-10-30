using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
           : base(options)
        {

        }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        //cofigure chuỗi kết nối vào db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //lưu ý chỉ cần thay tên  ở Data Source
                optionsBuilder.UseSqlServer("Data Source=PHONGTT2710\\SQLEXPRESS;Initial Catalog=DuAnMau;Persist Security Info=True;User ID=phong;Password=123");
            }
        }

    }
}
