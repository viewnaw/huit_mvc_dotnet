using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
[Table("tblVaiTro")]
public class VaiTro
{
    [Key]
    public int IDVaiTro { get; set; }
    public string TenVaiTro { get; set; }
    public string MoTa { get; set; }
}