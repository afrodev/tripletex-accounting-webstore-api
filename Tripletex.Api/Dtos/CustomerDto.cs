namespace Tripletex.Api.Dtos;

// Kunde DTO
public record CustomerDto(
    int? BookCustomerId, // Kundenummer i Tripletex (kan være null for nye kunder)
    int StoreCustomerID, // Unik ID fra nettbutikken
    string Name, // API onlie wants name as one field lol
    string? OrganizationNo,
    string Email,
    string? Phone,
    string? Mobile,
    AddressDto Address
);
