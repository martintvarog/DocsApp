using Core.Entities;

namespace Core.Infrastructure;

public interface IDocumentRepository
{
    Task<List<Document>> GetDocumentByIdAsync(int id);

    Task<bool> AddDocumentAsync(Document document);

    Task<bool> UpdateDocumentAsync(Document document);
}