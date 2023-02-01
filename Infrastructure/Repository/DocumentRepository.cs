using Core.Entities;
using Core.Infrastructure;

namespace Infrastructure.Repository;

public class DocumentRepository : IDocumentRepository
{
    private readonly List<Document> _documents = new();

    public Task<List<Document>> GetDocumentByIdAsync(string id)
        => Task.FromResult(_documents.Where(d => d.Id == id).ToList());


    public Task<bool> AddDocumentAsync(Document document)
    {
        _documents.Add(document);
        return Task.FromResult(true);
    }

    public async Task<bool> UpdateDocumentAsync(Document document)
    {
        var documentToUpdate = await GetDocumentByIdAsync(document.Id);
        if (!documentToUpdate.Any())
            return false;

        var index = _documents.IndexOf(documentToUpdate.First());
        _documents[index] = document;

        return true;
    }
}