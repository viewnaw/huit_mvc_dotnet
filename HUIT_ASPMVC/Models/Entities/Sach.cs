using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sach
{
    [Key]
    public int MaSach { get; set; }
    public string TenSach { get; set; }
    public int NamXB { get; set; }
    public int SoTrang { get; set; }
    public decimal GiaBan { get; set; }
    public string NoiDung { get; set; }
    public int LoaiSach { get; set; }
}