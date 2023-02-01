namespace Infrastructure.Requests;

public abstract class DocumentDto
{
    public string Id { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new();

    public dynamic Data { get; set; } = default!;
}