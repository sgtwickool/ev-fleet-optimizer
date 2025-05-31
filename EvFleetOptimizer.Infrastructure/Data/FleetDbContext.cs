using Microsoft.EntityFrameworkCore;
using EvFleetOptimizer.Core.Entities;

namespace EvFleetOptimizer.Infrastructure.Data;

public class FleetDbContext : DbContext
{
    public FleetDbContext(DbContextOptions<FleetDbContext> options) : base(options) { }

    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Depot> Depots { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<ChargingSession> ChargingSessions { get; set; }
    public DbSet<DepotScheduleEntry> DepotScheduleEntries { get; set; }
    public DbSet<PublicCharger> PublicChargers { get; set; }
    public DbSet<PublicChargerPriceHistory> PublicChargerPriceHistories { get; set; }
    public DbSet<TimeOfUseTariff> TimeOfUseTariffs { get; set; }

    // Optionally override OnModelCreating for relationships/configuration
}
