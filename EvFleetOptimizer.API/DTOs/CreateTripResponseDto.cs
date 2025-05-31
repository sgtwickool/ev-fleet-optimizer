namespace EvFleetOptimizer.API.DTOs;

public class CreateTripResponseDto
{
    public int TripId { get; set; }
    public List<VehicleSuggestionDto> VehicleSuggestions { get; set; } = new();
}
