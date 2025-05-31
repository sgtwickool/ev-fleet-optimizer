namespace EvFleetOptimizer.API.DTOs;

public class VehicleSuggestionDto
{
    public int VehicleId { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public double EstimatedRange { get; set; }
    public double BatteryLevel { get; set; }
}
