using Core.Entities;
using Core.Infrastructure;
using Core.Infrastructure.DTOs;
using Infrastructure.Extensions;

namespace Infrastructure.DocumentService;

public class DocumentService : IDocumentService
{
    private readonly IDocumentRepository _documentRepository;

    public DocumentService(IDocumentRepository documentRepository)
    {
        _documentRepository = documentRepository;
    }

    public async Task<List<Document>> GetDocumentByIdAsync(string id)
        => await _documentRepository.GetDocumentByIdAsync(id);

    public Task<bool> AddDocumentAsync(DocumentDto document)
        => _documentRepository.AddDocumentAsync(document.MapToDocument());

    public Task<bool> UpdateDocumentAsync(DocumentDto document)
        => _documentRepository.UpdateDocumentAsync(document.MapToDocument());
}