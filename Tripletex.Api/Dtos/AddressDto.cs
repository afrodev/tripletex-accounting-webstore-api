namespace Tripletex.Api.Dtos;

// Address DTO
public record AddressDto(
    string Line1,
    string Line2,
    string PostalCode,
    string City,
    string Country
);
