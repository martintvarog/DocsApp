using Core.Entities;
using Infrastructure.Requests;

namespace Infrastructure.Extensions;

public static class DocumentMapper
{
    public static Document MapDocument(this DocumentDto dto)
        => new(Id: dto.Id, Tags: dto.Tags, Data: dto.Data);

    public static DocumentDto MapDocument(this Document entity)
        => new()
        {
            Id = entity.Id,
            Tags = entity.Tags,
            Data = entity.Data
        };
}