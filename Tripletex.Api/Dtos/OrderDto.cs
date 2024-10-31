namespace Tripletex.Api.Dtos;

// Order DTO
public record OrderDto(
    int OrderId, // Unique ID from the webshop
    string OrderNo, // Order number in Tripletex (can be generated)
    DateTime OrderDate,
    CustomerDto Customer,
    List<ProductDto> Products,
    string PaymentMethod, // e.g., "VISA", "Klarna"
    decimal ShippingCost
);
