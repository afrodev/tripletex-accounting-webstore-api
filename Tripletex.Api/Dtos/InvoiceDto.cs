namespace Tripletex.Api.Dtos;

// Invoice DTO
public record InvoiceDto(
    string InvoiceNo, // Invoice number in Tripletex (can be generated)
    DateTime InvoiceDate,
    DateTime DueDate,
    string OrderNo, // Reference to the order number
    int CustomerNo, // Customer number in Tripletex
    string KID, // KID number (optional)
    string ReferenceNo, // Reference number (optional)
    string Comments, // Comments (optional)
    string Currency // Currency (e.g., "NOK")
);