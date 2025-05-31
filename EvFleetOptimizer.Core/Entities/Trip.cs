namespace EvFleetOptimizer.Core.Entities;

public class Trip
{
    public int Id { get; set; }
    public int VehicleId { get; set; } // FK to Vehicle
    public Vehicle? Vehicle { get; set; }
    public int DriverId { get; set; } // FK to Driver
    public Driver? Driver { get; set; }
    public int OriginLocationId { get; set; } // FK to Location
    public Location? OriginLocation { get; set; }
    public int DestinationLocationId { get; set; } // FK to Location
    public Location? DestinationLocation { get; set; }
    public DateTime ScheduledStart { get; set; }
    public DateTime ScheduledEnd { get; set; }
    public double EstimatedDistanceKm { get; set; } // from routing API
    public double EstimatedEnergyConsumptionKWh { get; set; } // e.g. 25.0 KWh
    public bool RequiresPublicCharging { get; set; } // true if route > range
    public int? SuggestedChargingSessionId { get; set; } // linking to public charger (optional)
    public ChargingSession? SuggestedChargingSession { get; set; }
}

