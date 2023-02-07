using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Infrastructure.Extensions;

public static class DocumentMapper
{
    public static Document MapToDocument(this DocumentDto documentDto)
        => new Document(documentDto.Id, documentDto.Tags, documentDto.Data.MapToData());

    public static DocumentDto MapToDocument(this Document document)
        => new()
        {
            Id = document.Id,
            Tags = document.Tags,
            Data = document.Data.MapToData()
        };
}