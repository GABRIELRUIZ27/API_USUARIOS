using System;
using System.Collections.Generic;
using ASP.NET_WebAPI6.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_USER_MT.Entities;

public partial class UserContext : DbContext
{
    public UserContext()
    {
    }

    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=jpr2023;database=user");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
