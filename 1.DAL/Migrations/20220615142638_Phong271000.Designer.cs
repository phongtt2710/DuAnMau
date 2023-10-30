﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220615142638_Phong271000")]
    partial class Phong271000
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Property<string>("DienThoai")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Phai")
                        .HasMaxLength(5)
                        .HasColumnType("bit");

                    b.Property<string>("TenKhach")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DienThoai");

                    b.HasIndex("MaNV");

                    b.ToTable("tableKhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TinhTrang")
                        .HasColumnType("bit");

                    b.Property<bool>("VaiTro")
                        .HasColumnType("bit");

                    b.HasKey("MaNV");

                    b.ToTable("tableNhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Property<int>("MaHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHang"), 1L, 1);

                    b.Property<float>("DonGiaBan")
                        .HasColumnType("real");

                    b.Property<float>("DonGiaNhap")
                        .HasColumnType("real");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaHang");

                    b.HasIndex("MaNV");

                    b.ToTable("tableHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.NhanVien", "MaNVNavigation")
                        .WithMany("KhachHangs")
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaNVNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.NhanVien", "MaNVNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaNVNavigation");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Navigation("KhachHangs");

                    b.Navigation("SanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
