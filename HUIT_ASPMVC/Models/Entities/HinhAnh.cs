using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tblHinhAnh")]
public class Tbl_HinhAnh
{
    [Key, Column(Order = 0)]
    public int ID { get; set; }
    [Key, Column(Order = 1)]
    public int MaSach { get; set; }
    public string HinhAnh { get; set; }
}