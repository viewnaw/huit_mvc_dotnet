using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class KhachHang
{
    [Key]
    public int MaKH { get; set; }
    public string TenKH { get; set; }
    public string MatKhau { get; set; }
    public string GioiTinh { get; set; }
    public int NamSinh { get; set; }
    public string Avarta { get; set; }
    public string DienThoai { get; set; }
    public string Email { get; set; }
    public string DiaChi { get; set; }
}