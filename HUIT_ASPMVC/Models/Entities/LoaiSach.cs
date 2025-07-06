using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class LoaiSach
{
    [Key]
    public int MaLoai { get; set; }
    public string TenLoai { get; set; }
    public string GhiChu { get; set; }
}