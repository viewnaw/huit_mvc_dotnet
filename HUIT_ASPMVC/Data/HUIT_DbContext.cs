using System;
using System.Data.Entity;
using System.Collections.Generic;

namespace HUIT_ASPMVC.Data
{
    public class HUIT_DbContext : DbContext
    {
        public HUIT_DbContext() : base("name=DefaultConnection") { }

        public DbSet<Sach> Sachs { get; set; }
        public DbSet<LoaiSach> LoaiSachs { get; set; }
        public DbSet<Tbl_HinhAnh> HinhAnhs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<TinhTrang> TinhTrangs { get; set; }
    }
}