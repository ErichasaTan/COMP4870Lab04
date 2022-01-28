using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using lab03.Models;

namespace lab03.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
   base.OnModelCreating(modelBuilder);
   
   modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
   modelBuilder.Entity<City>().HasData(SampleData.GetCities());
}
public DbSet<City>? Cities { get; set; }
public DbSet<Province>? Provinces { get; set; }    
}
