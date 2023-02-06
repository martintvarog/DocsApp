namespace Infrastructure.EntityFrameworkCore.Entities;

public sealed class DocumentEntity
{
    public string Id { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public DataEntity Data { get; set; } = new();
}