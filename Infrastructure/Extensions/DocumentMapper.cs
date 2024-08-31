using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Infrastructure.Extensions;

public static class DocumentMapper
{
    public static Document MapToDocument(this DocumentDto documentDto) =>
        new()
        {
            DocumentId = documentDto.DocumentId,
            DocumentTags = documentDto.TagIds.Select(tagId => new DocumentTags { TagId = tagId }).ToList(),
            AdditionalData = documentDto.Data?.MapToData()
        };

    public static DocumentDto MapToDocument(this Document document)
        => new()
        {
            DocumentId = document.DocumentId,
            TagIds = document.DocumentTags.Select(documentTag => documentTag.TagId).ToList(),
            Data = document.AdditionalData?.MapToData()
        };
}