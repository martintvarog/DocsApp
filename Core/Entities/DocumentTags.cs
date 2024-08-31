namespace Core.Entities;

public class DocumentTags
{
    public int DocumentId { get; set; }

    public int TagId { get; set; }

    public Document Document { get; set; } = null!;

    public Tag Tag { get; set; } = null!;
}