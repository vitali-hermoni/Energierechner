using Energierechner.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Energierechner.Service.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
        
    }


    public DbSet<ElectricityMeterModel> ElectricityMeters { get; set; }
    public DbSet<ElectricityMeterReadingsModel> ElectricityMeterReadings { get; set; }
    public DbSet<GasMeterModel> GasMeters { get; set; }
    public DbSet<HotWaterMeterModel> HotWaterMeters { get; set; }
}
