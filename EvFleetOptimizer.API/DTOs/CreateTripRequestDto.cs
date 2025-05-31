namespace EvFleetOptimizer.API.DTOs;

public class CreateTripRequestDto
{
    public int OriginLocationId { get; set; }
    public int DestinationLocationId { get; set; }
    public DateTime StartTime { get; set; }
    public int? PreferredVehicleId { get; set; }
    // Add more trip parameters as needed
}
