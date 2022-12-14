using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeesMvc.Models.Entities;

public partial class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Companie__3214EC07C11BDBFB");

            entity.Property(e => e.CompanyName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07CB44BE3B");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
