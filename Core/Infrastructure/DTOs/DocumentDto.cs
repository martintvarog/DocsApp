namespace Core.Infrastructure.DTOs;

public class DocumentDto
{
    public string Id { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new();

    public DataDto Data { get; set; } = default!;

}