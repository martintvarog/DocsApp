namespace Core.Infrastructure.DTOs;

public sealed record DocumentDto
{
    public string Id { get; init; } = string.Empty;

    public List<string> Tags { get; init; } = new();

    public DataDto Data { get; init; } = default!;
}