using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NhanVien
{
    [Key]
    public int MaNV { get; set; }
    public string MatKhau { get; set; }
    public string TenNV { get; set; }
    public string GioiTinh { get; set; }
    public int NamSinh { get; set; }
    public int VaiTro { get; set; }
}