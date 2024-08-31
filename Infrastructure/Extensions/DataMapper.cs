using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Infrastructure.Extensions;

public static class DataMapper
{
    public static AdditionalData MapToData(this DataDto dataDto)
        => new()
        {
            Optional = dataDto.Optional,
            Some = dataDto.Some
        };

    public static DataDto MapToData(this AdditionalData additionalData)
        => new()
        {
            Optional = additionalData.Optional,
            Some = additionalData.Some
        };
}