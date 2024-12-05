using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReverseEngineering_EF_Scoffolding_UsingPMC.Entities;

namespace ReverseEngineering_EF_Scoffolding_UsingPMC.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WalletsS> WalletsSes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMINISTRATOR\\SQLEXPRESS;Initial Catalog=DigitalCurrency ;User ID=h1;Password=h1; Integrated Security = SSPI;Trusted_Connection=True;Trusted_Connection=yes;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WalletsS>(entity =>
        {
            entity.HasKey(e => e.Idd).HasName("PK__Wallets__3214EC07A5F84E00");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
