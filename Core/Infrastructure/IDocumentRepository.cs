using Core.Entities;

namespace Core.Infrastructure;

public interface IDocumentRepository
{
    Task<Document> GetDocumentByIdAsync(string id);

    Task<bool> AddDocumentAsync(Document document);

    Task<bool> UpdateDocumentAsync(Document document);
}