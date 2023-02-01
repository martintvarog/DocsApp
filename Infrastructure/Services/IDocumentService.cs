using Core.Entities;
using Infrastructure.Requests;

namespace Infrastructure.Services;

public interface IDocumentService
{
    Task<List<Document>> GetDocumentByIdAsync(string id);

    Task<bool> AddDocumentAsync(DocumentDto document);

    Task<bool> UpdateDocumentAsync(DocumentDto document);
}