using Core.Entities;
using Core.Infrastructure.DTOs;

namespace Infrastructure.Extensions;

public static class DataMapper
{
    public static Data MapToData(this DataDto dataDto)
        => new()
        {
            Optional = dataDto.Optional,
            Some = dataDto.Some
        };

    public static DataDto MapToData(this Data data)
        => new()
        {
            Optional = data.Optional,
            Some = data.Some
        };
}