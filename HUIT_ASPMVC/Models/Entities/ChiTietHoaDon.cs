using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ChiTietHoaDon
{
    [Key, Column(Order = 0)]
    public int MaHD { get; set; }
    [Key, Column(Order = 1)]
    public int MaSach { get; set; }
    public int SoLuong { get; set; }
    public decimal GiaBan { get; set; }
}