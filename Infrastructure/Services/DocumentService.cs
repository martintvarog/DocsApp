using System.Xml.Serialization;
using Core.Entities;
using Core.Infrastructure;
using Infrastructure.Extensions;
using Infrastructure.Requests;

namespace Infrastructure.Services;

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
        => _documentRepository.AddDocumentAsync(document.MapDocument());


    public Task<bool> UpdateDocumentAsync(DocumentDto document)
        => _documentRepository.UpdateDocumentAsync(document.MapDocument());

    public StringWriter ConvertDocumentXmlAsync(DocumentDto document)
    {
        var xmlSerializer = new XmlSerializer(typeof(DocumentDto));
        var stringWriter = new StringWriter();
        xmlSerializer.Serialize(stringWriter, document);
        return stringWriter;
    }
}