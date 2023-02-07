using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Core.Infrastructure;

public interface IDocumentService
{
    Task<IReadOnlyCollection<Document>> GetDocumentByIdAsync(string id);

    Task<bool> AddDocumentAsync(DocumentDto document);

    Task<bool> UpdateDocumentAsync(DocumentDto document);
}