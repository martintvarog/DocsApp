using System.Xml.Serialization;
using Core.Entities;
using Core.Infrastructure;
using Core.Infrastructure.DTOs;

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

    public Task<bool> AddDocumentAsync(Document document)
        => _documentRepository.AddDocumentAsync(document);

    public Task<bool> UpdateDocumentAsync(Document document)
        => _documentRepository.UpdateDocumentAsync(document);

    public StringWriter ConvertDocumentXmlAsync(DocumentDto document)
    {
        var xmlSerializer = new XmlSerializer(typeof(DocumentDto));
        var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, document);
        return stringWriter;
    }
}