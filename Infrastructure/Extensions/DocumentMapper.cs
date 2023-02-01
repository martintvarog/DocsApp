using Core.Entities;
using Infrastructure.Requests;

namespace Infrastructure.Extensions;

public static class DocumentMapper
{
    public static Document MapToEntity(this DocumentDto dto)
        => new(Id: dto.Id, Tags: dto.Tags, Data: dto.Data);
}