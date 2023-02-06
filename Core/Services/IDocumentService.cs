using Core.Entities;

namespace Core.Services;

public interface IDocumentService
{
    Task<List<Document>> GetDocumentByIdAsync(string id);

    Task<bool> AddDocumentAsync(Document document);

    Task<bool> UpdateDocumentAsync(Document document);
    
    StringWriter ConvertDocumentXmlAsync(Document document);
}