namespace Core.Infrastructure.DTOs;

public sealed record DocumentDto
{
    public int DocumentId { get; init; }

    public List<int> TagIds { get; init; } = new();

    public DataDto? Data { get; init; }
}