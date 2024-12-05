using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReverseEngineering_EF_Scoffolding_UsingPMC.Entities;

[Table("Wallets_s")]
public partial class WalletsS
{
    [Key]
    public int Idd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Holder { get; set; } = null!;

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Balance { get; set; }
}
