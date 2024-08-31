namespace Core.Entities;

public class Document
{
    public int DocumentId { get; set; }
    
    public int AdditionalDataId { get; set; }

    public List<DocumentTags> DocumentTags { get; set; } = new();

    public AdditionalData? AdditionalData { get; set; }
}