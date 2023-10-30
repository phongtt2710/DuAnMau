﻿using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        List<KhachHang> LayDanhSachKhachHang();
        bool themKH(KhachHang kh);
        bool suaKH(KhachHang kh);
        bool xoaKH(KhachHang kh);
    }
}
