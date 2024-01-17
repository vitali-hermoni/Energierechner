using Energierechner.Auth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Energierechner.Auth.Data;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }


    public DbSet<AppUser> AppUser { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);
        //builder.SeddData();
    }
}
