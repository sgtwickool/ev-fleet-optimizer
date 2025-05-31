using Microsoft.AspNetCore.Mvc;
using EvFleetOptimizer.API.DTOs;

namespace EvFleetOptimizer.API.Controllers;

[ApiController]
[Route("api/trips")]
public class TripsController : ControllerBase
{
    [HttpPost]
    public ActionResult<CreateTripResponseDto> CreateTrip([FromBody] CreateTripRequestDto tripRequest)
    {
        // TODO: Validate, create new trip, return vehicle suggestions
        return Ok(new CreateTripResponseDto()); // Placeholder
    }
}
