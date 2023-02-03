using System.Xml.Serialization;

namespace Infrastructure.Requests;

[SoapInclude(typeof(Data))]
public class DocumentDto
{
    public string Id { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new();
    
    public Data Data { get; set; } = default!;
}

public class Data
{
}