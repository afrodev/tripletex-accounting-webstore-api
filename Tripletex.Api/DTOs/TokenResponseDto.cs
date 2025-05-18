using System.Text.Json.Serialization;

namespace Tripletex.Api.Dtos;

public record class TokenResponseDto
{
    [JsonPropertyName("value")]
    public string Token { get; set;} = string.Empty;

    [JsonPropertyName("expirationDate")]
    public DateTime ExpirationDate { get; set; }
}
// Date format 2025-02-28