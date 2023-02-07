namespace Core.Entities;

public sealed record Data
{
    public string Some { get; init; } = string.Empty;
    
    public string Optional { get; init; } = string.Empty;
}