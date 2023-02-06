using System.Xml.Serialization;
using Core.Entities;
using Core.Infrastructure;

namespace Core.Services;

public class DocumentService : IDocumentService
{
    private readonly IDocumentRepository _documentRepository;

    public DocumentService(IDocumentRepository documentRepository)
    {
        _documentRepository = documentRepository;
    }

    public async Task<List<Document>> GetDocumentByIdAsync(string id)
        => await _documentRepository.GetDocumentByIdAsync(id);

    public Task<bool> AddDocumentAsync(Document document)
        => _documentRepository.AddDocumentAsync(document);

    public Task<bool> UpdateDocumentAsync(Document document)
        => _documentRepository.UpdateDocumentAsync(document);

    public StringWriter ConvertDocumentXmlAsync(Document document)
    {
        var xmlSerializer = new XmlSerializer(typeof(Document));
        var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, document);
        return stringWriter;
    }
}