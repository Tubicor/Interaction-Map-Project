using InteractiveMapProject.Contracts.Dtos.FieldOfIntervention;
using InteractiveMapProject.Contracts.Entities;

namespace InteractiveMapProject.Contracts.Dtos;

public class ProfessionalUpdateRequestDto
{
    public Guid ProfessionalId { get; set; } = default!;

    public string Name { get; set; } = default!;

    public string EstablishmentType { get; set; } = default!;

    public string ManagementType { get; set; } = default!;

    public Address Address { get; set; } = default!;

    public string PhoneNumber { get; set; }

    public string Email { get; set; } = default!;

    public ContactPerson ContactPerson { get; set; } = default!;

    public IEnumerable<FieldOfInterventionGetRequestDto> Audiences { get; set; } = default!;

    public IEnumerable<FieldOfInterventionGetRequestDto> PlacesOfIntervention { get; set; } = default!;

    public IEnumerable<FieldOfInterventionGetRequestDto> Missions { get; set; } = default!;

    public string? Description { get; set; } = default!;
}
