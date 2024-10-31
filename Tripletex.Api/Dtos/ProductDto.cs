namespace Tripletex.Api.Dtos;

// Product DTO
// MUST HAVE THE SAME ID IN TRIPLETEX AND WEBSTORE!!!!!!!!-----
public record ProductDto(
    int ProductId, // Unique ID from the webshop
    string Name,
    decimal Price,
    int Count,
    int? TripletexProductId, // ID of the matching product in Tripletex (optional. WILL PROBS REMOVE)
    int AccountNumber // Regnskapskonto for the product
);
