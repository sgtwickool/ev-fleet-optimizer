namespace EvFleetOptimizer.Core.Entities;

public class ChargingSession
{
    public int Id { get; set; }
    public int VehicleId { get; set; } // FK to Vehicle
    public Vehicle? Vehicle { get; set; }
    public int? DepotId { get; set; } // FK to Depot if depot charge
    public Depot? Depot { get; set; }
    public int? PublicChargerId { get; set; } // FK to PublicCharger if public
    public PublicCharger? PublicCharger { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public double EnergyDeliveredKWh { get; set; }
    public double CostGBP { get; set; } // computed based on tariff
    public bool IsCompleted { get; set; }
}
