using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TinhTrang
{
    [Key]
    public int ID { get; set; }
    public string TinhTrangHoaDon { get; set; }
}