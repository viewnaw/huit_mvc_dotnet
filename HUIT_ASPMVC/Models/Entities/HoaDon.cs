using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class HoaDon
{
    [Key, Column(Order = 0)]
    public int MaHD { get; set; }
    [Key, Column(Order = 1)]
    public int MaKH { get; set; }
    [Key, Column(Order = 2)]
    public int MaNV { get; set; }
    public DateTime NgayLap { get; set; }
    public decimal TongTien { get; set; }
    public int TinhTrang { get; set; }
    public string DiaChiGiaoHang { get; set; }
    public bool DaThanhToan { get; set; }
}