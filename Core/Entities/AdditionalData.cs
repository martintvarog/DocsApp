namespace Core.Entities;

public class AdditionalData
{
    public int AdditionalDataId { get; set; }
    
    public int DocumentId { get; set; }

    public string? Some { get; set; }
    
    public string? Optional { get; set; } 
}