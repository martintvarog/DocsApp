namespace Core.Infrastructure.DTOs;

public sealed record DataDto
{
    public string Some { get; init; } = string.Empty;
    
    public string Optional { get; init; } = string.Empty;
}