namespace Core.Entities;

public class Tag
{
    public int TagId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public List<DocumentTags> DocumentTags { get; set; } = new();
}